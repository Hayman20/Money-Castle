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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raw_data));
            lblDebtotal = new Label();
            lblDebtPaid = new Label();
            lblDebt = new Label();
            lblPaid = new Label();
            lsvOutput = new ListView();
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
            cmbSort = new ComboBox();
            btnGraph = new Button();
            label3 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblDebtotal
            // 
            lblDebtotal.AutoSize = true;
            lblDebtotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebtotal.Location = new Point(262, 11);
            lblDebtotal.Name = "lblDebtotal";
            lblDebtotal.Size = new Size(69, 31);
            lblDebtotal.TabIndex = 0;
            lblDebtotal.Text = "Debt:";
            // 
            // lblDebtPaid
            // 
            lblDebtPaid.AutoSize = true;
            lblDebtPaid.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebtPaid.Location = new Point(177, 52);
            lblDebtPaid.Name = "lblDebtPaid";
            lblDebtPaid.Size = new Size(154, 31);
            lblDebtPaid.TabIndex = 1;
            lblDebtPaid.Text = "Debt paid off:";
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
            // lsvOutput
            // 
            lsvOutput.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvOutput.ForeColor = SystemColors.MenuText;
            lsvOutput.Location = new Point(159, 123);
            lsvOutput.Name = "lsvOutput";
            lsvOutput.Size = new Size(546, 175);
            lsvOutput.TabIndex = 4;
            lsvOutput.UseCompatibleStateImageBehavior = false;
            lsvOutput.View = System.Windows.Forms.View.Details;
            lsvOutput.SelectedIndexChanged += lsvOutput_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Store";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cost";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Type";
            columnHeader4.Width = 100;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlText;
            btnLogout.Image = Properties.Resources.logout_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnLogout.Location = new Point(21, 419);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 61);
            btnLogout.TabIndex = 19;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
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
            btnSetting.Click += btnSetting_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.info_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnHelp.ImageAlign = ContentAlignment.MiddleRight;
            btnHelp.Location = new Point(-2, 244);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(119, 85);
            btnHelp.TabIndex = 17;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.ControlText;
            btnUser.Image = Properties.Resources.badge_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnUser.ImageAlign = ContentAlignment.MiddleRight;
            btnUser.Location = new Point(-2, 163);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(119, 85);
            btnUser.TabIndex = 16;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnInput
            // 
            btnInput.BackColor = SystemColors.ControlText;
            btnInput.Image = Properties.Resources.upload_file_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnInput.ImageAlign = ContentAlignment.MiddleRight;
            btnInput.Location = new Point(-2, 81);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(119, 85);
            btnInput.TabIndex = 15;
            btnInput.Text = "Input";
            btnInput.TextAlign = ContentAlignment.MiddleLeft;
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = SystemColors.ControlText;
            btnDetails.Image = Properties.Resources.trending_up_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnDetails.ImageAlign = ContentAlignment.MiddleRight;
            btnDetails.Location = new Point(-2, -1);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(119, 85);
            btnDetails.TabIndex = 14;
            btnDetails.Text = "Details";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Type", "Date", "Store" });
            cmbSort.Location = new Point(381, 345);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(151, 28);
            cmbSort.TabIndex = 21;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // btnGraph
            // 
            btnGraph.BackColor = SystemColors.InactiveCaptionText;
            btnGraph.ForeColor = SystemColors.ButtonHighlight;
            btnGraph.Image = Properties.Resources.signal_cellular_alt_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnGraph.ImageAlign = ContentAlignment.MiddleRight;
            btnGraph.Location = new Point(275, 381);
            btnGraph.Name = "btnGraph";
            btnGraph.Size = new Size(152, 75);
            btnGraph.TabIndex = 22;
            btnGraph.Text = "View Graphs";
            btnGraph.TextAlign = ContentAlignment.MiddleLeft;
            btnGraph.UseVisualStyleBackColor = false;
            btnGraph.Click += btnGraph_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(306, 344);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 23;
            label3.Text = "Sort by:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.InactiveCaptionText;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(458, 381);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 75);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete Cost";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Raw_data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(800, 501);
            Controls.Add(btnDelete);
            Controls.Add(label3);
            Controls.Add(btnGraph);
            Controls.Add(cmbSort);
            Controls.Add(btnLogout);
            Controls.Add(btnSetting);
            Controls.Add(btnHelp);
            Controls.Add(btnUser);
            Controls.Add(btnInput);
            Controls.Add(btnDetails);
            Controls.Add(lsvOutput);
            Controls.Add(lblPaid);
            Controls.Add(lblDebt);
            Controls.Add(lblDebtPaid);
            Controls.Add(lblDebtotal);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Raw_data";
            Text = "Raw data";
            Load += Raw_data_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDebtotal;
        private Label lblDebtPaid;
        private Label lblDebt;
        private Label lblPaid;
        private ListView lsvOutput;
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
        private ComboBox cmbSort;
        private Button btnGraph;
        private Label label3;
        private Button btnDelete;
    }
}