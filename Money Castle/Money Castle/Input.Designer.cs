namespace Money_Castle
{
    partial class Input
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
            btnLogout = new Button();
            btnSetting = new Button();
            btnHelp = new Button();
            btnUser = new Button();
            btnInput = new Button();
            btnDetails = new Button();
            label1 = new Label();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            txtStore = new TextBox();
            txtCost = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIncome = new TextBox();
            txtSavingdes = new TextBox();
            txtSavingAmont = new TextBox();
            cmbPercent = new ComboBox();
            txtDebtDes = new TextBox();
            txtDebtAmount = new TextBox();
            txtDebtPaid = new TextBox();
            btnUpdate = new Button();
            cmbPeriod = new ComboBox();
            cmbType = new ComboBox();
            txtMonthly = new TextBox();
            dtpDebtTime = new DateTimePicker();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlText;
            btnLogout.Image = Properties.Resources.logout_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnLogout.Location = new Point(17, 315);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(66, 46);
            btnLogout.TabIndex = 31;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ControlText;
            btnSetting.Image = Properties.Resources.settings_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnSetting.Location = new Point(17, 253);
            btnSetting.Margin = new Padding(3, 2, 3, 2);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(66, 51);
            btnSetting.TabIndex = 30;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.info_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnHelp.ImageAlign = ContentAlignment.MiddleRight;
            btnHelp.Location = new Point(-4, 184);
            btnHelp.Margin = new Padding(3, 2, 3, 2);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(104, 64);
            btnHelp.TabIndex = 29;
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
            btnUser.Location = new Point(-4, 123);
            btnUser.Margin = new Padding(3, 2, 3, 2);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(104, 64);
            btnUser.TabIndex = 28;
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
            btnInput.Location = new Point(-4, 62);
            btnInput.Margin = new Padding(3, 2, 3, 2);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(104, 64);
            btnInput.TabIndex = 27;
            btnInput.Text = "Input";
            btnInput.TextAlign = ContentAlignment.MiddleLeft;
            btnInput.UseVisualStyleBackColor = false;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = SystemColors.ControlText;
            btnDetails.Image = Properties.Resources.trending_up_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnDetails.ImageAlign = ContentAlignment.MiddleRight;
            btnDetails.Location = new Point(-4, 0);
            btnDetails.Margin = new Padding(3, 2, 3, 2);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(104, 64);
            btnDetails.TabIndex = 26;
            btnDetails.Text = "Details";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(146, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 32;
            label1.Text = "Income:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(146, 69);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 33;
            label2.Text = "Add a Cost:";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "MM/yyyy";
            dtpDate.ImeMode = ImeMode.Off;
            dtpDate.Location = new Point(249, 70);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(219, 23);
            dtpDate.TabIndex = 34;
            dtpDate.Value = new DateTime(2024, 7, 19, 12, 38, 34, 0);
            // 
            // txtStore
            // 
            txtStore.Location = new Point(473, 70);
            txtStore.Margin = new Padding(3, 2, 3, 2);
            txtStore.Name = "txtStore";
            txtStore.PlaceholderText = "Store";
            txtStore.Size = new Size(110, 23);
            txtStore.TabIndex = 35;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(588, 70);
            txtCost.Margin = new Padding(3, 2, 3, 2);
            txtCost.Name = "txtCost";
            txtCost.PlaceholderText = "Cost";
            txtCost.Size = new Size(110, 23);
            txtCost.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(138, 123);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 37;
            label3.Text = "Saving Goal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(192, 203);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 38;
            label4.Text = "Debt:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(138, 166);
            label5.Name = "label5";
            label5.Size = new Size(210, 21);
            label5.TabIndex = 39;
            label5.Text = "Percent of income in savings:";
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(221, 22);
            txtIncome.Margin = new Padding(3, 2, 3, 2);
            txtIncome.Name = "txtIncome";
            txtIncome.PlaceholderText = "Income";
            txtIncome.Size = new Size(110, 23);
            txtIncome.TabIndex = 40;
            // 
            // txtSavingdes
            // 
            txtSavingdes.Location = new Point(249, 126);
            txtSavingdes.Margin = new Padding(3, 2, 3, 2);
            txtSavingdes.Name = "txtSavingdes";
            txtSavingdes.PlaceholderText = "Description";
            txtSavingdes.Size = new Size(110, 23);
            txtSavingdes.TabIndex = 41;
            // 
            // txtSavingAmont
            // 
            txtSavingAmont.Location = new Point(364, 126);
            txtSavingAmont.Margin = new Padding(3, 2, 3, 2);
            txtSavingAmont.Name = "txtSavingAmont";
            txtSavingAmont.PlaceholderText = "Amount";
            txtSavingAmont.Size = new Size(110, 23);
            txtSavingAmont.TabIndex = 42;
            // 
            // cmbPercent
            // 
            cmbPercent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPercent.FormattingEnabled = true;
            cmbPercent.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95", "100" });
            cmbPercent.Location = new Point(364, 166);
            cmbPercent.Margin = new Padding(3, 2, 3, 2);
            cmbPercent.Name = "cmbPercent";
            cmbPercent.Size = new Size(133, 23);
            cmbPercent.TabIndex = 43;
            // 
            // txtDebtDes
            // 
            txtDebtDes.Location = new Point(241, 206);
            txtDebtDes.Margin = new Padding(3, 2, 3, 2);
            txtDebtDes.Name = "txtDebtDes";
            txtDebtDes.PlaceholderText = "Description";
            txtDebtDes.Size = new Size(91, 23);
            txtDebtDes.TabIndex = 44;
            // 
            // txtDebtAmount
            // 
            txtDebtAmount.Location = new Point(336, 206);
            txtDebtAmount.Margin = new Padding(3, 2, 3, 2);
            txtDebtAmount.Name = "txtDebtAmount";
            txtDebtAmount.PlaceholderText = "Amount";
            txtDebtAmount.Size = new Size(78, 23);
            txtDebtAmount.TabIndex = 45;
            // 
            // txtDebtPaid
            // 
            txtDebtPaid.Location = new Point(419, 206);
            txtDebtPaid.Margin = new Padding(3, 2, 3, 2);
            txtDebtPaid.Name = "txtDebtPaid";
            txtDebtPaid.PlaceholderText = "Amount Paid off";
            txtDebtPaid.Size = new Size(106, 23);
            txtDebtPaid.TabIndex = 46;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaptionText;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Image = Properties.Resources.upgrade_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(304, 272);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 42);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "Update FIle";
            btnUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbPeriod
            // 
            cmbPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriod.FormattingEnabled = true;
            cmbPeriod.Items.AddRange(new object[] { "Weekly", "Fortnightly", "Monthly", "Yearly" });
            cmbPeriod.Location = new Point(336, 22);
            cmbPeriod.Margin = new Padding(3, 2, 3, 2);
            cmbPeriod.Name = "cmbPeriod";
            cmbPeriod.Size = new Size(133, 23);
            cmbPeriod.TabIndex = 48;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Food", "Bills ", "Entertainment", "Other" });
            cmbType.Location = new Point(703, 69);
            cmbType.Margin = new Padding(3, 2, 3, 2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(98, 23);
            cmbType.TabIndex = 49;
            // 
            // txtMonthly
            // 
            txtMonthly.Location = new Point(530, 206);
            txtMonthly.Margin = new Padding(3, 2, 3, 2);
            txtMonthly.Name = "txtMonthly";
            txtMonthly.PlaceholderText = "Monthly Payment";
            txtMonthly.Size = new Size(106, 23);
            txtMonthly.TabIndex = 50;
            // 
            // dtpDebtTime
            // 
            dtpDebtTime.CustomFormat = "MM/yyyy";
            dtpDebtTime.Location = new Point(642, 206);
            dtpDebtTime.Name = "dtpDebtTime";
            dtpDebtTime.Size = new Size(200, 23);
            dtpDebtTime.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(642, 184);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 52;
            label6.Text = "Debt start date:";
            // 
            // Input
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(873, 369);
            Controls.Add(label6);
            Controls.Add(dtpDebtTime);
            Controls.Add(txtMonthly);
            Controls.Add(cmbType);
            Controls.Add(cmbPeriod);
            Controls.Add(btnUpdate);
            Controls.Add(txtDebtPaid);
            Controls.Add(txtDebtAmount);
            Controls.Add(txtDebtDes);
            Controls.Add(cmbPercent);
            Controls.Add(txtSavingAmont);
            Controls.Add(txtSavingdes);
            Controls.Add(txtIncome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCost);
            Controls.Add(txtStore);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnSetting);
            Controls.Add(btnHelp);
            Controls.Add(btnUser);
            Controls.Add(btnInput);
            Controls.Add(btnDetails);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Input";
            Text = "Input";
            Load += Input_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Button btnSetting;
        private Button btnHelp;
        private Button btnUser;
        private Button btnInput;
        private Button btnDetails;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpDate;
        private TextBox txtStore;
        private TextBox txtCost;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIncome;
        private TextBox txtSavingdes;
        private TextBox txtSavingAmont;
        private ComboBox cmbPercent;
        private TextBox txtDebtDes;
        private TextBox txtDebtAmount;
        private TextBox txtDebtPaid;
        private Button btnUpdate;
        private ComboBox cmbPeriod;
        private ComboBox cmbType;
        private TextBox txtMonthly;
        private DateTimePicker dtpDebtTime;
        private Label label6;
    }
}