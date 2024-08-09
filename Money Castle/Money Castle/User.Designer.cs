namespace Money_Castle
{
    partial class User
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblUser = new Label();
            lblDate = new Label();
            lblIncome = new Label();
            lblSaving = new Label();
            lblDebt = new Label();
            lblPercent = new Label();
            btnChange = new Button();
            btnReload = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlText;
            btnLogout.Image = Properties.Resources.logout_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnLogout.Location = new Point(21, 417);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 61);
            btnLogout.TabIndex = 37;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ControlText;
            btnSetting.Image = Properties.Resources.settings_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnSetting.Location = new Point(21, 333);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(75, 68);
            btnSetting.TabIndex = 36;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.info_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnHelp.ImageAlign = ContentAlignment.MiddleRight;
            btnHelp.Location = new Point(-3, 243);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(119, 85);
            btnHelp.TabIndex = 35;
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
            btnUser.Location = new Point(-3, 161);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(119, 85);
            btnUser.TabIndex = 34;
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
            btnInput.Location = new Point(-3, 79);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(119, 85);
            btnInput.TabIndex = 33;
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
            btnDetails.Location = new Point(-3, -3);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(119, 85);
            btnDetails.TabIndex = 32;
            btnDetails.Text = "Details";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 45);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 38;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(122, 99);
            label2.Name = "label2";
            label2.Size = new Size(222, 38);
            label2.TabIndex = 39;
            label2.Text = "Date of creation:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(230, 147);
            label3.Name = "label3";
            label3.Size = new Size(114, 38);
            label3.TabIndex = 40;
            label3.Text = "Income:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(179, 195);
            label4.Name = "label4";
            label4.Size = new Size(165, 38);
            label4.TabIndex = 41;
            label4.Text = "Saving goal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(195, 251);
            label5.Name = "label5";
            label5.Size = new Size(149, 38);
            label5.TabIndex = 42;
            label5.Text = "Total Debt:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(139, 307);
            label6.Name = "label6";
            label6.Size = new Size(205, 38);
            label6.TabIndex = 43;
            label6.Text = "Saving Percent:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(350, 52);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(76, 31);
            lblUser.TabIndex = 44;
            lblUser.Text = "label7";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(350, 103);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(76, 31);
            lblDate.TabIndex = 45;
            lblDate.Text = "label7";
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblIncome.Location = new Point(350, 153);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(76, 31);
            lblIncome.TabIndex = 46;
            lblIncome.Text = "label7";
            // 
            // lblSaving
            // 
            lblSaving.AutoSize = true;
            lblSaving.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaving.Location = new Point(350, 201);
            lblSaving.Name = "lblSaving";
            lblSaving.Size = new Size(76, 31);
            lblSaving.TabIndex = 47;
            lblSaving.Text = "label7";
            // 
            // lblDebt
            // 
            lblDebt.AutoSize = true;
            lblDebt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebt.Location = new Point(350, 259);
            lblDebt.Name = "lblDebt";
            lblDebt.Size = new Size(76, 31);
            lblDebt.TabIndex = 48;
            lblDebt.Text = "label7";
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPercent.Location = new Point(350, 315);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(76, 31);
            lblPercent.TabIndex = 49;
            lblPercent.Text = "label7";
            // 
            // btnChange
            // 
            btnChange.BackColor = SystemColors.ActiveCaptionText;
            btnChange.Location = new Point(289, 403);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(137, 53);
            btnChange.TabIndex = 50;
            btnChange.Text = "Change Password";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.ControlText;
            btnReload.Image = Properties.Resources.refresh_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnReload.Location = new Point(529, 37);
            btnReload.Margin = new Padding(3, 4, 3, 4);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(66, 65);
            btnReload.TabIndex = 51;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 493);
            Controls.Add(btnReload);
            Controls.Add(btnChange);
            Controls.Add(lblPercent);
            Controls.Add(lblDebt);
            Controls.Add(lblSaving);
            Controls.Add(lblIncome);
            Controls.Add(lblDate);
            Controls.Add(lblUser);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnSetting);
            Controls.Add(btnHelp);
            Controls.Add(btnUser);
            Controls.Add(btnInput);
            Controls.Add(btnDetails);
            ForeColor = SystemColors.ControlLightLight;
            Name = "User";
            Text = "User Info";
            Load += User_Load;
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
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblUser;
        private Label lblDate;
        private Label lblIncome;
        private Label lblSaving;
        private Label lblDebt;
        private Label lblPercent;
        private Button btnChange;
        private Button btnReload;
    }
}