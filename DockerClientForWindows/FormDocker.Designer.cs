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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocker));
            this.lvwDocker = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.btnGetDocker = new System.Windows.Forms.Button();
            this.gridContainers = new System.Windows.Forms.DataGridView();
            this.colState = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelSelectedContainer = new System.Windows.Forms.Panel();
            this.lblContainer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogsForContainer = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelSelectedContainer.SuspendLayout();
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
            // btnGetDocker
            // 
            this.btnGetDocker.Location = new System.Drawing.Point(12, 12);
            this.btnGetDocker.Name = "btnGetDocker";
            this.btnGetDocker.Size = new System.Drawing.Size(169, 29);
            this.btnGetDocker.TabIndex = 4;
            this.btnGetDocker.Text = "Get Docker Containers";
            this.btnGetDocker.UseVisualStyleBackColor = true;
            this.btnGetDocker.Click += new System.EventHandler(this.btnGetDocker_Click);
            // 
            // gridContainers
            // 
            this.gridContainers.AllowUserToAddRows = false;
            this.gridContainers.AllowUserToDeleteRows = false;
            this.gridContainers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.colState,
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
            this.panelSelectedContainer.Controls.Add(this.btnStop);
            this.panelSelectedContainer.Controls.Add(this.lblContainer);
            this.panelSelectedContainer.Controls.Add(this.label1);
            this.panelSelectedContainer.Location = new System.Drawing.Point(6, 22);
            this.panelSelectedContainer.Name = "panelSelectedContainer";
            this.panelSelectedContainer.Size = new System.Drawing.Size(500, 350);
            this.panelSelectedContainer.TabIndex = 2;
            this.panelSelectedContainer.Visible = false;
            // 
            // lblContainer
            // 
            this.lblContainer.AutoSize = true;
            this.lblContainer.Location = new System.Drawing.Point(13, 42);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Size = new System.Drawing.Size(0, 15);
            this.lblContainer.TabIndex = 3;
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
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(16, 96);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(147, 34);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop Container";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
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
            this.Controls.Add(this.btnGetDocker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDocker";
            this.Text = "Docker for Windows";
            ((System.ComponentModel.ISupportInitialize)(this.gridContainers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelSelectedContainer.ResumeLayout(false);
            this.panelSelectedContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvwDocker;
        private ColumnHeader columnHeader1;
        private Button btnGetDocker;
        private DataGridView gridContainers;
        private DataGridViewImageColumn colState;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private GroupBox groupBox1;
        private Label lblLogsForContainer;
        private Panel panelSelectedContainer;
        private Label lblContainer;
        private Label label1;
        private Button btnStop;
    }
}