using Docker.DotNet;
using Docker.DotNet.Models;
using ImageResources = DockerClientForWindows.Properties.Resources;

namespace DockerClientForWindows
{
    public partial class FormDocker : Form
    {
        DockerClient client;
        IList<ContainerListResponse> containers;

        ContainerListResponse currentContainer;

        public FormDocker()
        {
            InitializeComponent();
            Task.Run(async () => await LoadContainers()).Wait();
            BindContainersDataGrid();
        }

        async private void btnGetDocker_Click(object sender, EventArgs e)
        {
            await LoadContainers();
            BindContainersDataGrid();
        }

        async private Task LoadContainers()
        {
            client = new DockerClientConfiguration().CreateClient();
            try
            {
                containers = await client.Containers.ListContainersAsync(new ContainersListParameters() { All = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load docker containers.", "Is Docker Running?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindContainersDataGrid()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = containers;
            gridContainers.AutoGenerateColumns = false;
            gridContainers.DataSource = bs;
        }

        private void gridContainers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((sender as DataGridView).DataSource != null)
            {
                if (e.ColumnIndex == 0) //State Image
                {
                    e.Value = ImageResources.ResourceManager.GetObject($"{e.Value}");
                }
                else if (e.ColumnIndex == 2) //ID
                {
                    DataGridViewCell cell = this.gridContainers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.ToolTipText = $"{e.Value}";
                    e.Value = $"{e.Value}".Substring(0, 10);
                }
            }
        }

        private void gridContainers_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                DataGridViewRow gridRow = ((sender as DataGridView).SelectedRows.Count > 0) ? (sender as DataGridView).SelectedRows[0] : null;
                if (gridRow != null)
                {
                    currentContainer = gridRow.DataBoundItem as ContainerListResponse;

                    lblLogsForContainer.Text = $"Logs for {currentContainer.Image}";
                    ViewLog();

                    ShowContainerDetails();
                }
            }
        }

        private void ShowContainerDetails()
        {
            panelSelectedContainer.Visible = true;
            lblImage.Text = currentContainer.Image;
            lblID.Text = currentContainer.ID;
            lblCreated.Text = currentContainer.Created.ToString();
            lblStatus.Text = currentContainer.Status;

            pbImage.Image = ImageResources.ResourceManager.GetObject($"{currentContainer.State}32") as Image;
            btnStart.Visible = (currentContainer.State == "stopped" || currentContainer.State == "exited");
            btnStop.Visible = (currentContainer.State == "running");
        }

        async private void ViewLog()
        {
            lvwDocker.Items.Clear();

            var logs = await client.Containers.GetContainerLogsAsync(currentContainer.ID, false, new ContainerLogsParameters() { ShowStdout = true, ShowStderr = true });
            (string stdOut, string strErr) = await logs.ReadOutputToEndAsync(CancellationToken.None);
            string[] logLines = GetStrings(stdOut);
            foreach (string logLine in logLines)
            {
                lvwDocker.Items.Add(logLine);
            }
        }


        private string[] GetStrings(string rawString)
        {
            return rawString.Split("\r\n");
        }

        async private void btnStop_Click(object sender, EventArgs e)
        {
            progressDocker.Value = 0;
            progressDocker.Visible = true;
            var stopped = await client.Containers.StopContainerAsync(currentContainer.ID, new ContainerStopParameters() { WaitBeforeKillSeconds = 5 });
            progressDocker.Visible = false;
            UpdateCurrentContainer();
        }

        async private void btnStart_Click(object sender, EventArgs e)
        {
            progressDocker.Value = 0;
            progressDocker.Visible = true;
            var started = await client.Containers.StartContainerAsync(currentContainer.ID, new ContainerStartParameters());
            progressDocker.Visible = false;
            UpdateCurrentContainer();
        }

        async private void UpdateCurrentContainer()
        {
            IList<ContainerListResponse> updatedContainers = await client.Containers.ListContainersAsync(new ContainersListParameters()
            {
                All = true,
                Filters = new Dictionary<string, IDictionary<string, bool>>
                {
                    {
                        "id", new Dictionary<string, bool>
                        {
                            { currentContainer.ID, true},
                        }
                    }
                }
            });

            currentContainer = updatedContainers.FirstOrDefault();

            if (currentContainer != null)
            {
                int currentIndex = containers.ToList().FindIndex(c => c.ID == currentContainer.ID);
                if (currentIndex >= 0)
                {
                    containers[currentIndex] = currentContainer;
                }
                ViewLog();
                BindContainersDataGrid();
                gridContainers.Rows[currentIndex].Selected = true;
            }
        }
    }
}