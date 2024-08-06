namespace Money_Castle
{
    partial class Raw_data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblDebt = new Label();
            lblPaid = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnLogout = new Button();
            btnSetting = new Button();
            btnHelp = new Button();
            btnUser = new Button();
            btnInput = new Button();
            btnDetails = new Button();
            btnSort = new Button();
            cmbSort = new ComboBox();
            btnGraph = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(262, 10);
            label1.Name = "label1";
            label1.Size = new Size(69, 31);
            label1.TabIndex = 0;
            label1.Text = "Debt:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(177, 52);
            label2.Name = "label2";
            label2.Size = new Size(154, 31);
            label2.TabIndex = 1;
            label2.Text = "Debt paid off:";
            // 
            // lblDebt
            // 
            lblDebt.AutoSize = true;
            lblDebt.Location = new Point(336, 17);
            lblDebt.Name = "lblDebt";
            lblDebt.Size = new Size(40, 20);
            lblDebt.TabIndex = 2;
            lblDebt.Text = "debt";
            // 
            // lblPaid
            // 
            lblPaid.AutoSize = true;
            lblPaid.Location = new Point(336, 63);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(40, 20);
            lblPaid.TabIndex = 3;
            lblPaid.Text = "debt";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(159, 122);
            listView1.Name = "listView1";
            listView1.Size = new Size(546, 174);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Store";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Type";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cost";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Date";
            columnHeader4.Width = 100;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlText;
            btnLogout.Image = Properties.Resources.logout_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnLogout.Location = new Point(21, 419);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 62);
            btnLogout.TabIndex = 19;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ControlText;
            btnSetting.Image = Properties.Resources.settings_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnSetting.Location = new Point(21, 336);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(75, 68);
            btnSetting.TabIndex = 18;
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.info_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnHelp.ImageAlign = ContentAlignment.MiddleRight;
            btnHelp.Location = new Point(-2, 244);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(119, 86);
            btnHelp.TabIndex = 17;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.ControlText;
            btnUser.Image = Properties.Resources.badge_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnUser.ImageAlign = ContentAlignment.MiddleRight;
            btnUser.Location = new Point(-2, 163);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(119, 86);
            btnUser.TabIndex = 16;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnInput
            // 
            btnInput.BackColor = SystemColors.ControlText;
            btnInput.Image = Properties.Resources.upload_file_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnInput.ImageAlign = ContentAlignment.MiddleRight;
            btnInput.Location = new Point(-2, 81);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(119, 86);
            btnInput.TabIndex = 15;
            btnInput.Text = "Input";
            btnInput.TextAlign = ContentAlignment.MiddleLeft;
            btnInput.UseVisualStyleBackColor = false;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = SystemColors.ControlText;
            btnDetails.Image = Properties.Resources.trending_up_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnDetails.ImageAlign = ContentAlignment.MiddleRight;
            btnDetails.Location = new Point(-2, -1);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(119, 86);
            btnDetails.TabIndex = 14;
            btnDetails.Text = "Details";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            btnSort.BackColor = SystemColors.InactiveCaptionText;
            btnSort.ForeColor = SystemColors.ControlLightLight;
            btnSort.Location = new Point(282, 346);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(94, 29);
            btnSort.TabIndex = 20;
            btnSort.Text = "Sort by";
            btnSort.UseVisualStyleBackColor = false;
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Type of store", "Cost", "Date" });
            cmbSort.Location = new Point(382, 346);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(151, 28);
            cmbSort.TabIndex = 21;
            // 
            // btnGraph
            // 
            btnGraph.BackColor = SystemColors.InactiveCaptionText;
            btnGraph.ForeColor = SystemColors.ButtonHighlight;
            btnGraph.Image = Properties.Resources.signal_cellular_alt_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnGraph.ImageAlign = ContentAlignment.MiddleRight;
            btnGraph.Location = new Point(321, 381);
            btnGraph.Name = "btnGraph";
            btnGraph.Size = new Size(152, 61);
            btnGraph.TabIndex = 22;
            btnGraph.Text = "View Graphs";
            btnGraph.TextAlign = ContentAlignment.MiddleLeft;
            btnGraph.UseVisualStyleBackColor = false;
            btnGraph.Click += btnGraph_Click;
            // 
            // Raw_data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(800, 502);
            Controls.Add(btnGraph);
            Controls.Add(cmbSort);
            Controls.Add(btnSort);
            Controls.Add(btnLogout);
            Controls.Add(btnSetting);
            Controls.Add(btnHelp);
            Controls.Add(btnUser);
            Controls.Add(btnInput);
            Controls.Add(btnDetails);
            Controls.Add(listView1);
            Controls.Add(lblPaid);
            Controls.Add(lblDebt);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Raw_data";
            Text = "Raw data";
            Load += Raw_data_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblDebt;
        private Label lblPaid;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnLogout;
        private Button btnSetting;
        private Button btnHelp;
        private Button btnUser;
        private Button btnInput;
        private Button btnDetails;
        private Button btnSort;
        private ComboBox cmbSort;
        private Button btnGraph;
    }
}