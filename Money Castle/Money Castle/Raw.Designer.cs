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
            SuspendLayout();
            // 
            // lblDebtotal
            // 
            lblDebtotal.AutoSize = true;
            lblDebtotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebtotal.Location = new Point(229, 8);
            lblDebtotal.Name = "lblDebtotal";
            lblDebtotal.Size = new Size(56, 25);
            lblDebtotal.TabIndex = 0;
            lblDebtotal.Text = "Debt:";
            // 
            // lblDebtPaid
            // 
            lblDebtPaid.AutoSize = true;
            lblDebtPaid.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebtPaid.Location = new Point(155, 39);
            lblDebtPaid.Name = "lblDebtPaid";
            lblDebtPaid.Size = new Size(126, 25);
            lblDebtPaid.TabIndex = 1;
            lblDebtPaid.Text = "Debt paid off:";
            // 
            // lblDebt
            // 
            lblDebt.AutoSize = true;
            lblDebt.Location = new Point(294, 13);
            lblDebt.Name = "lblDebt";
            lblDebt.Size = new Size(31, 15);
            lblDebt.TabIndex = 2;
            lblDebt.Text = "debt";
            // 
            // lblPaid
            // 
            lblPaid.AutoSize = true;
            lblPaid.Location = new Point(294, 47);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(31, 15);
            lblPaid.TabIndex = 3;
            lblPaid.Text = "debt";
            // 
            // lsvOutput
            // 
            lsvOutput.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvOutput.ForeColor = SystemColors.MenuText;
            lsvOutput.Location = new Point(139, 92);
            lsvOutput.Margin = new Padding(3, 2, 3, 2);
            lsvOutput.Name = "lsvOutput";
            lsvOutput.Size = new Size(478, 132);
            lsvOutput.TabIndex = 4;
            lsvOutput.UseCompatibleStateImageBehavior = false;
            lsvOutput.View = System.Windows.Forms.View.Details;
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
            btnLogout.Location = new Point(18, 314);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(66, 46);
            btnLogout.TabIndex = 19;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ControlText;
            btnSetting.Image = Properties.Resources.settings_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnSetting.Location = new Point(18, 252);
            btnSetting.Margin = new Padding(3, 2, 3, 2);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(66, 51);
            btnSetting.TabIndex = 18;
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.info_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnHelp.ImageAlign = ContentAlignment.MiddleRight;
            btnHelp.Location = new Point(-2, 183);
            btnHelp.Margin = new Padding(3, 2, 3, 2);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(104, 64);
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
            btnUser.Location = new Point(-2, 122);
            btnUser.Margin = new Padding(3, 2, 3, 2);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(104, 64);
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
            btnInput.Location = new Point(-2, 61);
            btnInput.Margin = new Padding(3, 2, 3, 2);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(104, 64);
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
            btnDetails.Margin = new Padding(3, 2, 3, 2);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(104, 64);
            btnDetails.TabIndex = 14;
            btnDetails.Text = "Details";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.UseVisualStyleBackColor = false;
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Type", "Date", "Store" });
            cmbSort.Location = new Point(333, 259);
            cmbSort.Margin = new Padding(3, 2, 3, 2);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(133, 23);
            cmbSort.TabIndex = 21;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // btnGraph
            // 
            btnGraph.BackColor = SystemColors.InactiveCaptionText;
            btnGraph.ForeColor = SystemColors.ButtonHighlight;
            btnGraph.Image = Properties.Resources.signal_cellular_alt_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnGraph.ImageAlign = ContentAlignment.MiddleRight;
            btnGraph.Location = new Point(281, 286);
            btnGraph.Margin = new Padding(3, 2, 3, 2);
            btnGraph.Name = "btnGraph";
            btnGraph.Size = new Size(133, 46);
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
            label3.Location = new Point(268, 258);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 23;
            label3.Text = "Sort by:";
            // 
            // Raw_data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(700, 376);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}