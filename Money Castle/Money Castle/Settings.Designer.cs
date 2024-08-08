namespace Money_Castle
{
    partial class Settings
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
            cmbColour = new ComboBox();
            label2 = new Label();
            cmbLan = new ComboBox();
            label3 = new Label();
            cmbBoot = new ComboBox();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlText;
            btnLogout.Image = Properties.Resources.logout_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnLogout.Location = new Point(19, 309);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(66, 46);
            btnLogout.TabIndex = 37;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ControlText;
            btnSetting.Image = Properties.Resources.settings_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnSetting.Location = new Point(19, 247);
            btnSetting.Margin = new Padding(3, 2, 3, 2);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(66, 51);
            btnSetting.TabIndex = 36;
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.info_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnHelp.ImageAlign = ContentAlignment.MiddleRight;
            btnHelp.Location = new Point(-1, 178);
            btnHelp.Margin = new Padding(3, 2, 3, 2);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(104, 64);
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
            btnUser.Location = new Point(-1, 117);
            btnUser.Margin = new Padding(3, 2, 3, 2);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(104, 64);
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
            btnInput.Location = new Point(-1, 56);
            btnInput.Margin = new Padding(3, 2, 3, 2);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(104, 64);
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
            btnDetails.Location = new Point(-1, -6);
            btnDetails.Margin = new Padding(3, 2, 3, 2);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(104, 64);
            btnDetails.TabIndex = 32;
            btnDetails.Text = "Details";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(172, 35);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 38;
            label1.Text = "Colour Theme:";
            // 
            // cmbColour
            // 
            cmbColour.FormattingEnabled = true;
            cmbColour.Items.AddRange(new object[] { "Dark Mode", "Light Mode" });
            cmbColour.Location = new Point(318, 38);
            cmbColour.Margin = new Padding(3, 2, 3, 2);
            cmbColour.Name = "cmbColour";
            cmbColour.Size = new Size(133, 23);
            cmbColour.TabIndex = 39;
            cmbColour.SelectedIndexChanged += cmbColour_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(208, 85);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 40;
            label2.Text = "Language:";
            // 
            // cmbLan
            // 
            cmbLan.FormattingEnabled = true;
            cmbLan.Items.AddRange(new object[] { "English" });
            cmbLan.Location = new Point(318, 87);
            cmbLan.Margin = new Padding(3, 2, 3, 2);
            cmbLan.Name = "cmbLan";
            cmbLan.Size = new Size(133, 23);
            cmbLan.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(181, 135);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 42;
            label3.Text = "Boot on Start:";
            // 
            // cmbBoot
            // 
            cmbBoot.FormattingEnabled = true;
            cmbBoot.Items.AddRange(new object[] { "Yes", "No" });
            cmbBoot.Location = new Point(318, 137);
            cmbBoot.Margin = new Padding(3, 2, 3, 2);
            cmbBoot.Name = "cmbBoot";
            cmbBoot.Size = new Size(133, 23);
            cmbBoot.TabIndex = 43;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(700, 366);
            Controls.Add(cmbBoot);
            Controls.Add(label3);
            Controls.Add(cmbLan);
            Controls.Add(label2);
            Controls.Add(cmbColour);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnSetting);
            Controls.Add(btnHelp);
            Controls.Add(btnUser);
            Controls.Add(btnInput);
            Controls.Add(btnDetails);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Settings";
            Text = "Settings";
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
        private ComboBox cmbColour;
        private Label label2;
        private ComboBox cmbLan;
        private Label label3;
        private ComboBox cmbBoot;
    }
}