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
            txtOld = new TextBox();
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
            btnBack.Location = new Point(95, 182);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(228, 37);
            btnBack.TabIndex = 21;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.FromArgb(64, 64, 64);
            btnChange.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnChange.ForeColor = SystemColors.ControlLightLight;
            btnChange.Image = Properties.Resources.person_add_20dp_FILL0_wght300_GRAD0_opsz20;
            btnChange.ImageAlign = ContentAlignment.MiddleRight;
            btnChange.Location = new Point(95, 141);
            btnChange.Margin = new Padding(3, 2, 3, 2);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(228, 37);
            btnChange.TabIndex = 20;
            btnChange.Text = "Change Password";
            btnChange.TextAlign = ContentAlignment.MiddleLeft;
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // txtConform
            // 
            txtConform.BackColor = Color.FromArgb(64, 64, 64);
            txtConform.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtConform.ForeColor = SystemColors.Window;
            txtConform.Location = new Point(220, 93);
            txtConform.Margin = new Padding(3, 2, 3, 2);
            txtConform.Name = "txtConform";
            txtConform.PasswordChar = '*';
            txtConform.Size = new Size(184, 32);
            txtConform.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(3, 94);
            label4.Name = "label4";
            label4.Size = new Size(200, 30);
            label4.TabIndex = 18;
            label4.Text = "Conform Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(64, 64, 64);
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.Window;
            txtPassword.Location = new Point(220, 58);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(184, 32);
            txtPassword.TabIndex = 17;
            // 
            // txtOld
            // 
            txtOld.BackColor = Color.FromArgb(64, 64, 64);
            txtOld.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtOld.ForeColor = SystemColors.Window;
            txtOld.Location = new Point(220, 22);
            txtOld.Margin = new Padding(3, 2, 3, 2);
            txtOld.Name = "txtOld";
            txtOld.Size = new Size(184, 32);
            txtOld.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(39, 58);
            label3.Name = "label3";
            label3.Size = new Size(158, 30);
            label3.TabIndex = 15;
            label3.Text = "New Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(95, 22);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 14;
            label2.Text = "Password:";
            // 
            // Change
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(425, 244);
            Controls.Add(btnBack);
            Controls.Add(btnChange);
            Controls.Add(txtConform);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtOld);
            Controls.Add(label3);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtOld;
        private Label label3;
        private Label label2;
    }
}