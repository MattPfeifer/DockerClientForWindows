namespace DockerClientForWindows
{
    partial class FormDocker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocker));
            this.lvwDocker = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.btnGetDocker = new System.Windows.Forms.Button();
            this.lvwContainers = new System.Windows.Forms.ListView();
            this.colImage = new System.Windows.Forms.ColumnHeader();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colCreated = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.lblContainerName = new System.Windows.Forms.Label();
            this.gridContainers = new System.Windows.Forms.DataGridView();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwDocker
            // 
            this.lvwDocker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDocker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwDocker.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwDocker.FullRowSelect = true;
            this.lvwDocker.GridLines = true;
            this.lvwDocker.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwDocker.Location = new System.Drawing.Point(12, 444);
            this.lvwDocker.Name = "lvwDocker";
            this.lvwDocker.Size = new System.Drawing.Size(1094, 127);
            this.lvwDocker.TabIndex = 5;
            this.lvwDocker.UseCompatibleStateImageBehavior = false;
            this.lvwDocker.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Database Stuff";
            this.columnHeader1.Width = 2500;
            // 
            // btnGetDocker
            // 
            this.btnGetDocker.Location = new System.Drawing.Point(12, 12);
            this.btnGetDocker.Name = "btnGetDocker";
            this.btnGetDocker.Size = new System.Drawing.Size(104, 29);
            this.btnGetDocker.TabIndex = 4;
            this.btnGetDocker.Text = "GetDocker";
            this.btnGetDocker.UseVisualStyleBackColor = true;
            this.btnGetDocker.Click += new System.EventHandler(this.btnGetDocker_Click);
            // 
            // lvwContainers
            // 
            this.lvwContainers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colImage,
            this.colID,
            this.colCreated,
            this.colStatus});
            this.lvwContainers.FullRowSelect = true;
            this.lvwContainers.Location = new System.Drawing.Point(12, 47);
            this.lvwContainers.MultiSelect = false;
            this.lvwContainers.Name = "lvwContainers";
            this.lvwContainers.Size = new System.Drawing.Size(1009, 145);
            this.lvwContainers.TabIndex = 6;
            this.lvwContainers.UseCompatibleStateImageBehavior = false;
            this.lvwContainers.View = System.Windows.Forms.View.Details;
            // 
            // colImage
            // 
            this.colImage.Text = "Image";
            this.colImage.Width = 500;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 100;
            // 
            // colCreated
            // 
            this.colCreated.Text = "Created";
            this.colCreated.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 150;
            // 
            // lblContainerName
            // 
            this.lblContainerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContainerName.Location = new System.Drawing.Point(753, 21);
            this.lblContainerName.Name = "lblContainerName";
            this.lblContainerName.Size = new System.Drawing.Size(234, 23);
            this.lblContainerName.TabIndex = 7;
            // 
            // gridContainers
            // 
            this.gridContainers.AllowUserToAddRows = false;
            this.gridContainers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContainers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContainers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridContainers.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridContainers.Location = new System.Drawing.Point(12, 216);
            this.gridContainers.MultiSelect = false;
            this.gridContainers.Name = "gridContainers";
            this.gridContainers.RowTemplate.Height = 25;
            this.gridContainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContainers.Size = new System.Drawing.Size(1009, 209);
            this.gridContainers.TabIndex = 8;
            this.gridContainers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridContainers_CellFormatting);
            this.gridContainers.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gridContainers_RowStateChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Image";
            this.dataGridViewTextBoxColumn1.HeaderText = "Image";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 500;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Created";
            this.dataGridViewTextBoxColumn3.HeaderText = "Created";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // FormDocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 583);
            this.Controls.Add(this.gridContainers);
            this.Controls.Add(this.lblContainerName);
            this.Controls.Add(this.lvwContainers);
            this.Controls.Add(this.lvwDocker);
            this.Controls.Add(this.btnGetDocker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDocker";
            this.Text = "Docker for Windows";
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvwDocker;
        private ColumnHeader columnHeader1;
        private Button btnGetDocker;
        private ListView lvwContainers;
        private ColumnHeader colImage;
        private ColumnHeader colID;
        private ColumnHeader colCreated;
        private ColumnHeader colStatus;
        private Label lblContainerName;
        private DataGridView gridContainers;
        private ToolTip toolTipInfo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}