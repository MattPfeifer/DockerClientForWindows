using Docker.DotNet;
using Docker.DotNet.Models;
using System.Reflection;
using System.Text;

namespace DockerClientForWindows
{
    public partial class FormDocker : Form
    {
        DockerClient client;
        IList<ContainerListResponse> containers;

        public FormDocker()
        {
            InitializeComponent();
        }

        async private void btnGetDocker_Click(object sender, EventArgs e)
        {
            client = new DockerClientConfiguration().CreateClient();

            containers = await client.Containers.ListContainersAsync(new ContainersListParameters());// { Limit = 20 });

            BindContainersDataGrid();

            List<ContainerListResponse> gatewayContainers = containers.Where(c => c.Names.Contains("/docker_apigateway_1")).ToList();

            ContainerListResponse? gatewayContainer = gatewayContainers.FirstOrDefault();

            if (gatewayContainer != null)
            {
                var logs = await client.Containers.GetContainerLogsAsync(gatewayContainer.ID, true, new ContainerLogsParameters() { ShowStdout = true, ShowStderr = true });
                (string stdOut, string strErr) = await logs.ReadOutputToEndAsync(CancellationToken.None);
                lvwDocker.Items.Add(stdOut);

                // Create two different encodings.
                Encoding ascii = Encoding.ASCII;
                Encoding unicode = Encoding.Unicode;
                //Encoding Utf8 = Encoding.UTF8;

                // // Convert the string into a byte array.
                byte[] unicodeBytes = unicode.GetBytes(stdOut);

                // // Perform the conversion from one encoding to the other.
                byte[] ascibytes = Encoding.Convert(unicode, ascii, unicodeBytes);

                // // Convert the new byte[] into a char[] and then into a string.
                char[] asciiChars = new char[ascii.GetCharCount(ascibytes, 0, ascibytes.Length)];
                ascii.GetChars(ascibytes, 0, ascibytes.Length, asciiChars, 0);
                string asciiString = new string(asciiChars);




                lvwDocker.Items.Add(asciiString);

                string strX = System.Uri.UnescapeDataString(stdOut);
                lvwDocker.Items.Add(strX);

                string s2 = stdOut.Replace($"\u0001", "");
                s2 = s2.Replace($"\0", "");
                lvwDocker.Items.Add(s2);
                string[] results = s2.Split($"\r\n");
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
                if (e.ColumnIndex == 1) //ID
                {
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
                DataGridViewRow gridRow = ((sender as DataGridView).SelectedRows.Count>0) ? (sender as DataGridView).SelectedRows[0] : null;
                if (gridRow!= null)
                {
                    ContainerListResponse selectedContainer = gridRow.DataBoundItem as ContainerListResponse;
                    lblContainerName.Text = selectedContainer.ID;
                }
            }
        }
    }
}