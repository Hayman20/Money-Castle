namespace Money_Castle
{
    partial class Sign_up
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
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtConform = new TextBox();
            label4 = new Label();
            btnCreate = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 54);
            label1.TabIndex = 1;
            label1.Text = "Money Castle";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(64, 64, 64);
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.Window;
            txtPassword.Location = new Point(272, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 39);
            txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(64, 64, 64);
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = SystemColors.Window;
            txtUsername.Location = new Point(272, 63);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 38);
            txtUsername.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(140, 110);
            label3.Name = "label3";
            label3.Size = new Size(138, 38);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(130, 63);
            label2.Name = "label2";
            label2.Size = new Size(148, 38);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // txtConform
            // 
            txtConform.BackColor = Color.FromArgb(64, 64, 64);
            txtConform.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtConform.ForeColor = SystemColors.Window;
            txtConform.Location = new Point(272, 157);
            txtConform.Name = "txtConform";
            txtConform.PasswordChar = '*';
            txtConform.Size = new Size(210, 39);
            txtConform.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(24, 158);
            label4.Name = "label4";
            label4.Size = new Size(254, 38);
            label4.TabIndex = 9;
            label4.Text = "Conform Password:";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(64, 64, 64);
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Image = Properties.Resources.person_add_20dp_FILL0_wght300_GRAD0_opsz20;
            btnCreate.ImageAlign = ContentAlignment.MiddleRight;
            btnCreate.Location = new Point(183, 241);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(191, 49);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create user";
            btnCreate.TextAlign = ContentAlignment.MiddleLeft;
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(64, 64, 64);
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ControlLightLight;
            btnBack.Image = Properties.Resources.keyboard_backspace_20dp_FILL0_wght300_GRAD0_opsz20;
            btnBack.ImageAlign = ContentAlignment.MiddleRight;
            btnBack.Location = new Point(183, 296);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(191, 49);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(579, 450);
            Controls.Add(btnBack);
            Controls.Add(btnCreate);
            Controls.Add(txtConform);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Window;
            Name = "Sign_up";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        public TextBox txtConform;
        private Label label4;
        private Button btnCreate;
        private Button btnBack;
    }
}