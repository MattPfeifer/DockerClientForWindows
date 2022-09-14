using Docker.DotNet;
using Docker.DotNet.Models;
using System.Reflection;
using System.Text;
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
        }

        async private void btnGetDocker_Click(object sender, EventArgs e)
        {
            client = new DockerClientConfiguration().CreateClient();

            containers = await client.Containers.ListContainersAsync(new ContainersListParameters());// { Limit = 20 });
            //var x = await client.Containers.ListProcessesAsync(new ContainerListProcessesParameters());// { Limit = 20 });

            BindContainersDataGrid();
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
                    //Image stateImage = Resources.running;
                    e.Value = ImageResources.ResourceManager.GetObject(e.Value.ToString());// ImageResources.running; // Image.FromFile("//images/running.png");
                }
                else if (e.ColumnIndex == 2) //ID
                {
                    DataGridViewCell cell = this.gridContainers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.ToolTipText = e.Value.ToString();
                    e.Value = e.Value.ToString().Substring(0, 10);
                    //TODO: Set the cell to the entire value
                    //toolTipInfo.SetToolTip(e.)
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

                    panelSelectedContainer.Visible = true;
                    lblContainer.Text = currentContainer.Image;

                    ViewLog();
                }
            }
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

        private async void btnStop_Click(object sender, EventArgs e)
        {
            var stopped = await client.Containers.StartContainerAsync(currentContainer.ID, new ContainerStartParameters());
            //Stopped not working yet



                //Look into the ones below.

            //TODO:  Create Container?  Any reason to do this?  Maybe i could kick off graphql this way???
            //TODO:  client.Containers.GetContainerStatsAsync?  What would this even do.
            // Anything else from https://github.com/dotnet/Docker.DotNet

            //A refresh of containers and the log for the current
        }
    }
}