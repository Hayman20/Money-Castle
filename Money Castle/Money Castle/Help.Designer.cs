namespace Money_Castle
{
    partial class Help
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ControlText;
            btnSetting.Image = Properties.Resources.settings_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnSetting.Location = new Point(12, 417);
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
            btnHelp.Location = new Point(-2, 243);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(119, 86);
            btnHelp.TabIndex = 35;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.ControlText;
            btnUser.Image = Properties.Resources.badge_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnUser.ImageAlign = ContentAlignment.MiddleRight;
            btnUser.Location = new Point(-2, 162);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(119, 86);
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
            btnInput.Location = new Point(-2, 80);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(119, 86);
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
            btnDetails.Location = new Point(-2, -2);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(119, 86);
            btnDetails.TabIndex = 32;
            btnDetails.Text = "Details";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 21);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 38;
            label1.Text = "Steps to use money castle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 80);
            label2.Name = "label2";
            label2.Size = new Size(463, 20);
            label2.TabIndex = 39;
            label2.Text = "Step 1: Input all correct data into the input areas in the input window";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 126);
            label3.Name = "label3";
            label3.Size = new Size(548, 20);
            label3.TabIndex = 40;
            label3.Text = "Step 2: Add all costs that you wish to track into the costs area in the Input window";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 178);
            label4.Name = "label4";
            label4.Size = new Size(725, 20);
            label4.TabIndex = 41;
            label4.Text = "Step 3: After getting a file updated message open the details window and click the reload button next to tax";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 228);
            label5.Name = "label5";
            label5.Size = new Size(511, 20);
            label5.TabIndex = 42;
            label5.Text = "Step 4: The app is now displaying all relevant data for you to start bugeting ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 276);
            label6.Name = "label6";
            label6.Size = new Size(645, 20);
            label6.TabIndex = 43;
            label6.Text = "PSA: if you wish to delete a cost open the raw data window on the button of the details window ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(231, 309);
            label7.Name = "label7";
            label7.Size = new Size(431, 20);
            label7.TabIndex = 44;
            label7.Text = "and select the record wish to delete and press the delete button";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(201, 460);
            label8.Name = "label8";
            label8.Size = new Size(501, 20);
            label8.TabIndex = 45;
            label8.Text = "For anymore enquiries please contact support at MoneyCastle@gmail.com";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlText;
            btnLogout.Image = Properties.Resources.logout_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnLogout.ImageAlign = ContentAlignment.MiddleRight;
            btnLogout.Location = new Point(-2, 327);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 84);
            btnLogout.TabIndex = 46;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(863, 497);
            Controls.Add(btnLogout);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSetting);
            Controls.Add(btnHelp);
            Controls.Add(btnUser);
            Controls.Add(btnInput);
            Controls.Add(btnDetails);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Help";
            Text = "Help";
            Load += Help_Load;
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnLogout;
    }
}