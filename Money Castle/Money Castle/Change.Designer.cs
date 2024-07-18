namespace Money_Castle
{
    partial class Change
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
            btnBack = new Button();
            btnChange = new Button();
            txtConform = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(64, 64, 64);
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ControlLightLight;
            btnBack.Image = Properties.Resources.keyboard_backspace_20dp_FILL0_wght300_GRAD0_opsz20;
            btnBack.ImageAlign = ContentAlignment.MiddleRight;
            btnBack.Location = new Point(109, 243);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(260, 49);
            btnBack.TabIndex = 21;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.FromArgb(64, 64, 64);
            btnChange.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnChange.ForeColor = SystemColors.ControlLightLight;
            btnChange.Image = Properties.Resources.person_add_20dp_FILL0_wght300_GRAD0_opsz20;
            btnChange.ImageAlign = ContentAlignment.MiddleRight;
            btnChange.Location = new Point(109, 188);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(260, 49);
            btnChange.TabIndex = 20;
            btnChange.Text = "Change Password";
            btnChange.TextAlign = ContentAlignment.MiddleLeft;
            btnChange.UseVisualStyleBackColor = false;
            // 
            // txtConform
            // 
            txtConform.BackColor = Color.FromArgb(64, 64, 64);
            txtConform.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtConform.ForeColor = SystemColors.Window;
            txtConform.Location = new Point(251, 124);
            txtConform.Name = "txtConform";
            txtConform.PasswordChar = '*';
            txtConform.Size = new Size(210, 39);
            txtConform.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(3, 125);
            label4.Name = "label4";
            label4.Size = new Size(254, 38);
            label4.TabIndex = 18;
            label4.Text = "Conform Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(64, 64, 64);
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.Window;
            txtPassword.Location = new Point(251, 77);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 39);
            txtPassword.TabIndex = 17;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(64, 64, 64);
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = SystemColors.Window;
            txtUsername.Location = new Point(251, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 38);
            txtUsername.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(45, 78);
            label3.Name = "label3";
            label3.Size = new Size(202, 38);
            label3.TabIndex = 15;
            label3.Text = "New Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(109, 30);
            label2.Name = "label2";
            label2.Size = new Size(138, 38);
            label2.TabIndex = 14;
            label2.Text = "Password:";
            // 
            // Change
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(486, 326);
            Controls.Add(btnBack);
            Controls.Add(btnChange);
            Controls.Add(txtConform);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Change";
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnChange;
        public TextBox txtConform;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
    }
}