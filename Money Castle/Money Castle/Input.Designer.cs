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
            btnSetting = new Button();
            btnHelp = new Button();
            btnUser = new Button();
            btnInput = new Button();
            btnDetails = new Button();
            label1 = new Label();
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
            txtMonthly = new TextBox();
            dtpDebtTime = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            btnCosts = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ControlText;
            btnSetting.Image = Properties.Resources.settings_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnSetting.Location = new Point(12, 412);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(75, 68);
            btnSetting.TabIndex = 30;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.info_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnHelp.ImageAlign = ContentAlignment.MiddleRight;
            btnHelp.Location = new Point(-5, 245);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(119, 85);
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
            btnUser.Location = new Point(-5, 164);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(119, 85);
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
            btnInput.Location = new Point(-5, 83);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(119, 85);
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
            btnDetails.Location = new Point(-5, 0);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(119, 85);
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
            label1.Location = new Point(167, 88);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 32;
            label1.Text = "Income:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(158, 138);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 37;
            label3.Text = "Saving Goal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(219, 245);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 38;
            label4.Text = "Debt:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(158, 195);
            label5.Name = "label5";
            label5.Size = new Size(262, 28);
            label5.TabIndex = 39;
            label5.Text = "Percent of income in savings:";
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(253, 90);
            txtIncome.Name = "txtIncome";
            txtIncome.PlaceholderText = "Income";
            txtIncome.Size = new Size(125, 27);
            txtIncome.TabIndex = 40;
            // 
            // txtSavingdes
            // 
            txtSavingdes.Location = new Point(285, 142);
            txtSavingdes.Name = "txtSavingdes";
            txtSavingdes.PlaceholderText = "Description";
            txtSavingdes.Size = new Size(125, 27);
            txtSavingdes.TabIndex = 41;
            // 
            // txtSavingAmont
            // 
            txtSavingAmont.Location = new Point(416, 142);
            txtSavingAmont.Name = "txtSavingAmont";
            txtSavingAmont.PlaceholderText = "Amount";
            txtSavingAmont.Size = new Size(125, 27);
            txtSavingAmont.TabIndex = 42;
            // 
            // cmbPercent
            // 
            cmbPercent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPercent.FormattingEnabled = true;
            cmbPercent.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95", "100" });
            cmbPercent.Location = new Point(416, 195);
            cmbPercent.Name = "cmbPercent";
            cmbPercent.Size = new Size(151, 28);
            cmbPercent.TabIndex = 43;
            // 
            // txtDebtDes
            // 
            txtDebtDes.Location = new Point(275, 249);
            txtDebtDes.Name = "txtDebtDes";
            txtDebtDes.PlaceholderText = "Description";
            txtDebtDes.Size = new Size(103, 27);
            txtDebtDes.TabIndex = 44;
            // 
            // txtDebtAmount
            // 
            txtDebtAmount.Location = new Point(384, 249);
            txtDebtAmount.Name = "txtDebtAmount";
            txtDebtAmount.PlaceholderText = "Amount";
            txtDebtAmount.Size = new Size(89, 27);
            txtDebtAmount.TabIndex = 45;
            // 
            // txtDebtPaid
            // 
            txtDebtPaid.Location = new Point(479, 249);
            txtDebtPaid.Name = "txtDebtPaid";
            txtDebtPaid.PlaceholderText = "Amount Paid off";
            txtDebtPaid.Size = new Size(121, 27);
            txtDebtPaid.TabIndex = 46;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaptionText;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Image = Properties.Resources.upgrade_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnUpdate.ImageAlign = ContentAlignment.MiddleRight;
            btnUpdate.Location = new Point(284, 366);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(167, 56);
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
            cmbPeriod.Location = new Point(384, 90);
            cmbPeriod.Name = "cmbPeriod";
            cmbPeriod.Size = new Size(151, 28);
            cmbPeriod.TabIndex = 48;
            // 
            // txtMonthly
            // 
            txtMonthly.Location = new Point(606, 249);
            txtMonthly.Name = "txtMonthly";
            txtMonthly.PlaceholderText = "Monthly Payment";
            txtMonthly.Size = new Size(121, 27);
            txtMonthly.TabIndex = 50;
            // 
            // dtpDebtTime
            // 
            dtpDebtTime.CustomFormat = "MM/yyyy";
            dtpDebtTime.Location = new Point(734, 249);
            dtpDebtTime.Margin = new Padding(3, 4, 3, 4);
            dtpDebtTime.Name = "dtpDebtTime";
            dtpDebtTime.Size = new Size(228, 27);
            dtpDebtTime.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(734, 219);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 52;
            label6.Text = "Debt start date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(253, 25);
            label7.Name = "label7";
            label7.Size = new Size(228, 41);
            label7.TabIndex = 53;
            label7.Text = "User data input:";
            // 
            // btnCosts
            // 
            btnCosts.BackColor = SystemColors.ActiveCaptionText;
            btnCosts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCosts.ForeColor = SystemColors.ControlLightLight;
            btnCosts.Image = Properties.Resources.attach_money_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnCosts.ImageAlign = ContentAlignment.MiddleRight;
            btnCosts.Location = new Point(606, 366);
            btnCosts.Name = "btnCosts";
            btnCosts.Size = new Size(164, 64);
            btnCosts.TabIndex = 54;
            btnCosts.Text = "Input Costs";
            btnCosts.TextAlign = ContentAlignment.MiddleLeft;
            btnCosts.UseVisualStyleBackColor = false;
            btnCosts.Click += btnCosts_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.Image = Properties.Resources.logout_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(-3, 322);
            button1.Name = "button1";
            button1.Size = new Size(117, 84);
            button1.TabIndex = 55;
            button1.Text = "Logout";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Input
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(998, 492);
            Controls.Add(button1);
            Controls.Add(btnCosts);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpDebtTime);
            Controls.Add(txtMonthly);
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
            Controls.Add(label1);
            Controls.Add(btnSetting);
            Controls.Add(btnHelp);
            Controls.Add(btnUser);
            Controls.Add(btnInput);
            Controls.Add(btnDetails);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Input";
            Text = "Input";
            Load += Input_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSetting;
        private Button btnHelp;
        private Button btnUser;
        private Button btnInput;
        private Button btnDetails;
        private Label label1;
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
        private TextBox txtMonthly;
        private DateTimePicker dtpDebtTime;
        private Label label6;
        private Label label7;
        private Button btnCosts;
        private Button button1;
    }
}