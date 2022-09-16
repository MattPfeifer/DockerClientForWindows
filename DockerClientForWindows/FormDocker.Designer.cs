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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocker));
            this.lvwDocker = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.btnGetDockerContainers = new System.Windows.Forms.Button();
            this.gridContainers = new System.Windows.Forms.DataGridView();
            this.colState = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelSelectedContainer = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressDocker = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogsForContainer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelSelectedContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwDocker
            // 
            this.lvwDocker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwDocker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwDocker.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwDocker.FullRowSelect = true;
            this.lvwDocker.GridLines = true;
            this.lvwDocker.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwDocker.Location = new System.Drawing.Point(12, 468);
            this.lvwDocker.Name = "lvwDocker";
            this.lvwDocker.Size = new System.Drawing.Size(1581, 273);
            this.lvwDocker.TabIndex = 5;
            this.lvwDocker.UseCompatibleStateImageBehavior = false;
            this.lvwDocker.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Database Stuff";
            this.columnHeader1.Width = 2500;
            // 
            // btnGetDockerContainers
            // 
            this.btnGetDockerContainers.Location = new System.Drawing.Point(12, 12);
            this.btnGetDockerContainers.Name = "btnGetDockerContainers";
            this.btnGetDockerContainers.Size = new System.Drawing.Size(169, 29);
            this.btnGetDockerContainers.TabIndex = 4;
            this.btnGetDockerContainers.Text = "Refresh Docker Containers";
            this.btnGetDockerContainers.UseVisualStyleBackColor = true;
            this.btnGetDockerContainers.Click += new System.EventHandler(this.btnGetDocker_Click);
            // 
            // gridContainers
            // 
            this.gridContainers.AllowUserToAddRows = false;
            this.gridContainers.AllowUserToDeleteRows = false;
            this.gridContainers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridContainers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContainers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colState,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridContainers.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridContainers.Location = new System.Drawing.Point(12, 47);
            this.gridContainers.MultiSelect = false;
            this.gridContainers.Name = "gridContainers";
            this.gridContainers.RowHeadersVisible = false;
            this.gridContainers.RowTemplate.Height = 25;
            this.gridContainers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContainers.Size = new System.Drawing.Size(1054, 378);
            this.gridContainers.TabIndex = 8;
            this.gridContainers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridContainers_CellFormatting);
            this.gridContainers.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gridContainers_RowStateChanged);
            // 
            // colState
            // 
            this.colState.DataPropertyName = "State";
            this.colState.HeaderText = "";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            this.colState.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Image";
            this.dataGridViewTextBoxColumn1.HeaderText = "Image";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 600;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Created";
            this.dataGridViewTextBoxColumn3.HeaderText = "Created";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panelSelectedContainer);
            this.groupBox1.Location = new System.Drawing.Point(1081, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 378);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Container";
            // 
            // panelSelectedContainer
            // 
            this.panelSelectedContainer.Controls.Add(this.pbImage);
            this.panelSelectedContainer.Controls.Add(this.lblCreated);
            this.panelSelectedContainer.Controls.Add(this.lblStatus);
            this.panelSelectedContainer.Controls.Add(this.lblID);
            this.panelSelectedContainer.Controls.Add(this.label4);
            this.panelSelectedContainer.Controls.Add(this.label3);
            this.panelSelectedContainer.Controls.Add(this.label2);
            this.panelSelectedContainer.Controls.Add(this.progressDocker);
            this.panelSelectedContainer.Controls.Add(this.btnStart);
            this.panelSelectedContainer.Controls.Add(this.btnStop);
            this.panelSelectedContainer.Controls.Add(this.lblImage);
            this.panelSelectedContainer.Controls.Add(this.label1);
            this.panelSelectedContainer.Location = new System.Drawing.Point(6, 22);
            this.panelSelectedContainer.Name = "panelSelectedContainer";
            this.panelSelectedContainer.Size = new System.Drawing.Size(500, 350);
            this.panelSelectedContainer.TabIndex = 2;
            this.panelSelectedContainer.Visible = false;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(13, 236);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(32, 32);
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // lblCreated
            // 
            this.lblCreated.Location = new System.Drawing.Point(13, 129);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(466, 20);
            this.lblCreated.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(13, 185);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(466, 20);
            this.lblStatus.TabIndex = 11;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(13, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(466, 20);
            this.lblID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Created";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // progressDocker
            // 
            this.progressDocker.Location = new System.Drawing.Point(225, 236);
            this.progressDocker.MarqueeAnimationSpeed = 25;
            this.progressDocker.Name = "progressDocker";
            this.progressDocker.Size = new System.Drawing.Size(254, 32);
            this.progressDocker.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressDocker.TabIndex = 6;
            this.progressDocker.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(62, 236);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 32);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Container";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(62, 236);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(147, 32);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop Container";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblImage
            // 
            this.lblImage.Location = new System.Drawing.Point(13, 26);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(466, 20);
            this.lblImage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // lblLogsForContainer
            // 
            this.lblLogsForContainer.AutoSize = true;
            this.lblLogsForContainer.Location = new System.Drawing.Point(12, 450);
            this.lblLogsForContainer.Name = "lblLogsForContainer";
            this.lblLogsForContainer.Size = new System.Drawing.Size(0, 15);
            this.lblLogsForContainer.TabIndex = 10;
            // 
            // FormDocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 753);
            this.Controls.Add(this.lblLogsForContainer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridContainers);
            this.Controls.Add(this.lvwDocker);
            this.Controls.Add(this.btnGetDockerContainers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDocker";
            this.Text = "Docker for Windows";
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelSelectedContainer.ResumeLayout(false);
            this.panelSelectedContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvwDocker;
        private ColumnHeader columnHeader1;
        private Button btnGetDockerContainers;
        private DataGridView gridContainers;
        private DataGridViewImageColumn colState;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private GroupBox groupBox1;
        private Label lblLogsForContainer;
        private Panel panelSelectedContainer;
        private Label lblImage;
        private Label label1;
        private Button btnStop;
        private Button btnStart;
        private ProgressBar progressDocker;
        private Label lblCreated;
        private Label lblStatus;
        private Label lblID;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pbImage;
    }
}