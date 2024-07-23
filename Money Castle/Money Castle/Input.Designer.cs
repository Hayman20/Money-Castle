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
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlText;
            btnLogout.Image = Properties.Resources.logout_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnLogout.Location = new Point(19, 420);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 62);
            btnLogout.TabIndex = 31;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ControlText;
            btnSetting.Image = Properties.Resources.settings_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnSetting.Location = new Point(19, 337);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(75, 68);
            btnSetting.TabIndex = 30;
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.info_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnHelp.ImageAlign = ContentAlignment.MiddleRight;
            btnHelp.Location = new Point(-4, 245);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(119, 86);
            btnHelp.TabIndex = 29;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.ControlText;
            btnUser.Image = Properties.Resources.badge_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnUser.ImageAlign = ContentAlignment.MiddleRight;
            btnUser.Location = new Point(-4, 164);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(119, 86);
            btnUser.TabIndex = 28;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnInput
            // 
            btnInput.BackColor = SystemColors.ControlText;
            btnInput.Image = Properties.Resources.upload_file_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnInput.ImageAlign = ContentAlignment.MiddleRight;
            btnInput.Location = new Point(-4, 82);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(119, 86);
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
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(119, 86);
            btnDetails.TabIndex = 26;
            btnDetails.Text = "Details";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(167, 26);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 32;
            label1.Text = "Income:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(167, 92);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 33;
            label2.Text = "Add a Cost:";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpDate.ImeMode = ImeMode.Off;
            dtpDate.Location = new Point(285, 94);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 34;
            dtpDate.Value = new DateTime(2024, 7, 19, 12, 38, 34, 0);
            // 
            // txtStore
            // 
            txtStore.Location = new Point(541, 94);
            txtStore.Name = "txtStore";
            txtStore.PlaceholderText = "Store";
            txtStore.Size = new Size(125, 27);
            txtStore.TabIndex = 35;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(672, 93);
            txtCost.Name = "txtCost";
            txtCost.PlaceholderText = "Cost";
            txtCost.Size = new Size(125, 27);
            txtCost.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(158, 164);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 37;
            label3.Text = "Saving Goal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(220, 271);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 38;
            label4.Text = "Debt:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(158, 222);
            label5.Name = "label5";
            label5.Size = new Size(262, 28);
            label5.TabIndex = 39;
            label5.Text = "Percent of income in savings:";
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(253, 30);
            txtIncome.Name = "txtIncome";
            txtIncome.PlaceholderText = "Income";
            txtIncome.Size = new Size(125, 27);
            txtIncome.TabIndex = 40;
            // 
            // txtSavingdes
            // 
            txtSavingdes.Location = new Point(285, 168);
            txtSavingdes.Name = "txtSavingdes";
            txtSavingdes.PlaceholderText = "Description";
            txtSavingdes.Size = new Size(125, 27);
            txtSavingdes.TabIndex = 41;
            // 
            // txtSavingAmont
            // 
            txtSavingAmont.Location = new Point(416, 168);
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
            cmbPercent.Location = new Point(416, 222);
            cmbPercent.Name = "cmbPercent";
            cmbPercent.Size = new Size(151, 28);
            cmbPercent.TabIndex = 43;
            // 
            // txtDebtDes
            // 
            txtDebtDes.Location = new Point(275, 275);
            txtDebtDes.Name = "txtDebtDes";
            txtDebtDes.PlaceholderText = "Description";
            txtDebtDes.Size = new Size(103, 27);
            txtDebtDes.TabIndex = 44;
            // 
            // txtDebtAmount
            // 
            txtDebtAmount.Location = new Point(384, 275);
            txtDebtAmount.Name = "txtDebtAmount";
            txtDebtAmount.PlaceholderText = "Amount";
            txtDebtAmount.Size = new Size(88, 27);
            txtDebtAmount.TabIndex = 45;
            // 
            // txtDebtPaid
            // 
            txtDebtPaid.Location = new Point(479, 275);
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
            btnUpdate.Location = new Point(347, 362);
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
            cmbPeriod.Items.AddRange(new object[] { "Weekly", "Fortnightly ", "Mouthly", "Yearly" });
            cmbPeriod.Location = new Point(384, 29);
            cmbPeriod.Name = "cmbPeriod";
            cmbPeriod.Size = new Size(151, 28);
            cmbPeriod.TabIndex = 48;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Food", "Bills ", "Entertainment", "Other" });
            cmbType.Location = new Point(803, 92);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(111, 28);
            cmbType.TabIndex = 49;
            cmbType.Text = "Type";
            // 
            // Input
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(939, 492);
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
    }
}