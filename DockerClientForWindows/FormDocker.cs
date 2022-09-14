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

            foreach (var c in containers)
            {
                ListViewItem item = new ListViewItem();
                //icon for c.State
                item.Tag = c.ID;
                item.Text = c.Image;
                item.SubItems.Add(c.ID.Substring(0,10));
                item.SubItems.Add(c.Created.ToString());
                item.SubItems.Add(c.Status);
                Enum.TryParse<ContainerState>(c.State, out ContainerState state);
                item.BackColor = (state == ContainerState.created || state == ContainerState.running )? Color.LightGreen : Color.LightSalmon;
                lvwContainers.Items.Add(item);
            }

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

            //DataGridViewColumn colName = new DataGridViewColumn();
            //colName.DataPropertyName = "Names[0]";
            //colName.HeaderText = "Name";
            //gridContainers.Columns.Add(colName);

            //DataGridViewColumn colID = new DataGridViewColumn();
            //colID.DataPropertyName = "ID";
            //colID.HeaderText = "ID";
            //gridContainers.Columns.Add(colID);
        }

        //private void gridContainers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (gridContainers.Rows[e.RowIndex].DataBoundItem != null &&
        //        gridContainers.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
        //    {
        //        e.Value = BindProperty(gridContainers.Rows[e.RowIndex].DataBoundItem,
        //            gridContainers.Columns[e.ColumnIndex].DataPropertyName);
        //    }
        //}

        //private string BindProperty(object property, string propertyName)
        //{
        //    string retValue = "";

        //    if (propertyName.Contains("."))
        //    {
        //        PropertyInfo[] arrayProperties;
        //        string leftPropertyName;

        //        leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
        //        arrayProperties = property.GetType().GetProperties();

        //        foreach (PropertyInfo propertyInfo in arrayProperties)
        //        {
        //            if (propertyInfo.Name == leftPropertyName)
        //            {
        //                retValue = BindProperty(propertyInfo.GetValue(property, null),
        //                propertyName.Substring(propertyName.IndexOf(".") + 1));
        //                break;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Type propertyType;
        //        PropertyInfo propertyInfo;

        //        propertyType = property.GetType();
        //        propertyInfo = propertyType.GetProperty(propertyName);
        //        retValue = propertyInfo.GetValue(property, null).ToString();
        //    }

        //    return retValue;
        //}

        //private void lvwContainers_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ListViewItem selectedItem = ((sender as ListView).SelectedIndices.Count > 0) ? (sender as ListView).SelectedItems?[0] : null;
        //    if (selectedItem != null)
        //    {
        //        string selectedID = selectedItem.Tag.ToString();    //ID stored in tag
        //        ContainerListResponse selectedContainer = containers.FirstOrDefault(c => c.ID.Equals(selectedID));

        //        lblContainerName.Text = selectedContainer.ID;

        //    }
        //}

        private void gridContainers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((sender as DataGridView).DataSource != null)
            {
                if (e.ColumnIndex == 1) //ID
                {
                    e.Value = e.Value.ToString().Substring(0, 10);
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