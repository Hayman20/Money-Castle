namespace Money_Castle
{
    partial class View
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            lblIncome = new Label();
            lblTax = new Label();
            chtDebt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chtCost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chtTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnLogout = new Button();
            btnSetting = new Button();
            btnHelp = new Button();
            btnUser = new Button();
            btnInput = new Button();
            btnDetails = new Button();
            label3 = new Label();
            lblNet = new Label();
            btnReload = new Button();
            lblPaid = new Label();
            lblDebt = new Label();
            lblDebtPaid = new Label();
            lblDebtotal = new Label();
            ((System.ComponentModel.ISupportInitialize)chtDebt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtTotal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(531, 26);
            label1.Name = "label1";
            label1.Size = new Size(74, 46);
            label1.TabIndex = 3;
            label1.Text = "Tax:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(468, 72);
            label2.Name = "label2";
            label2.Size = new Size(138, 46);
            label2.TabIndex = 4;
            label2.Text = "Income:";
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblIncome.Location = new Point(601, 76);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(116, 41);
            lblIncome.TabIndex = 5;
            lblIncome.Text = "income";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTax.Location = new Point(613, 29);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(57, 41);
            lblTax.TabIndex = 6;
            lblTax.Text = "tax";
            lblTax.Click += lblTax_Click;
            // 
            // chtDebt
            // 
            chtDebt.BackColor = Color.FromArgb(64, 64, 64);
            chtDebt.BorderlineColor = Color.Black;
            chartArea1.AxisX.LineColor = Color.White;
            chartArea1.AxisX.TitleForeColor = Color.White;
            chartArea1.AxisX2.TitleForeColor = Color.White;
            chartArea1.AxisY.TitleForeColor = Color.White;
            chartArea1.AxisY2.LineColor = Color.BlanchedAlmond;
            chartArea1.AxisY2.TitleForeColor = Color.White;
            chartArea1.BorderColor = Color.IndianRed;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = Color.Black;
            chtDebt.ChartAreas.Add(chartArea1);
            chtDebt.Location = new Point(135, 183);
            chtDebt.Name = "chtDebt";
            chtDebt.Size = new Size(471, 527);
            chtDebt.TabIndex = 14;
            title1.ForeColor = Color.White;
            title1.Name = "Title1";
            title1.Text = "Debt vs Time based off minimum payments";
            chtDebt.Titles.Add(title1);
            chtDebt.Click += chtDebt_Click;
            // 
            // chtCost
            // 
            chtCost.BackColor = Color.FromArgb(64, 64, 64);
            chartArea2.AxisX.TitleForeColor = Color.White;
            chartArea2.AxisY.TitleForeColor = Color.White;
            chartArea2.BackColor = Color.White;
            chartArea2.BorderColor = Color.Bisque;
            chartArea2.BorderWidth = 4;
            chartArea2.Name = "ChartArea1";
            chtCost.ChartAreas.Add(chartArea2);
            chtCost.Location = new Point(613, 183);
            chtCost.Name = "chtCost";
            chtCost.Size = new Size(419, 527);
            chtCost.TabIndex = 15;
            chtCost.Text = "chart2";
            title2.ForeColor = Color.White;
            title2.Name = "Title1";
            title2.Text = "Gross income vs Costs";
            chtCost.Titles.Add(title2);
            chtCost.Click += chtCost_Click;
            // 
            // chtTotal
            // 
            chtTotal.BackColor = Color.FromArgb(64, 64, 64);
            chartArea3.AxisX.TitleForeColor = Color.White;
            chartArea3.AxisY.TitleForeColor = Color.White;
            chartArea3.BackColor = Color.FromArgb(64, 64, 64);
            chartArea3.Name = "ChartArea1";
            chtTotal.ChartAreas.Add(chartArea3);
            chtTotal.Location = new Point(1039, 183);
            chtTotal.Name = "chtTotal";
            chtTotal.Size = new Size(439, 527);
            chtTotal.TabIndex = 16;
            chtTotal.Text = "chart3";
            title3.ForeColor = Color.White;
            title3.Name = "Title1";
            title3.Text = "Total cost per store";
            chtTotal.Titles.Add(title3);
            chtTotal.Click += chtTotal_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlText;
            btnLogout.Image = Properties.Resources.logout_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnLogout.ImageAlign = ContentAlignment.MiddleRight;
            btnLogout.Location = new Point(1, 332);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 84);
            btnLogout.TabIndex = 25;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ControlText;
            btnSetting.Image = Properties.Resources.settings_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnSetting.Location = new Point(14, 422);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(75, 68);
            btnSetting.TabIndex = 24;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlText;
            btnHelp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnHelp.Image = Properties.Resources.info_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnHelp.ImageAlign = ContentAlignment.MiddleRight;
            btnHelp.Location = new Point(-1, 251);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(119, 85);
            btnHelp.TabIndex = 23;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.ControlText;
            btnUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUser.Image = Properties.Resources.badge_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnUser.ImageAlign = ContentAlignment.MiddleRight;
            btnUser.Location = new Point(-1, 169);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(119, 85);
            btnUser.TabIndex = 22;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnInput
            // 
            btnInput.BackColor = SystemColors.ControlText;
            btnInput.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInput.Image = Properties.Resources.upload_file_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnInput.ImageAlign = ContentAlignment.MiddleRight;
            btnInput.Location = new Point(-1, 87);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(119, 85);
            btnInput.TabIndex = 21;
            btnInput.Text = "Input";
            btnInput.TextAlign = ContentAlignment.MiddleLeft;
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = SystemColors.ControlText;
            btnDetails.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetails.Image = Properties.Resources.trending_up_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnDetails.ImageAlign = ContentAlignment.MiddleRight;
            btnDetails.Location = new Point(-1, 5);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(119, 85);
            btnDetails.TabIndex = 20;
            btnDetails.Text = "Details";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(405, 126);
            label3.Name = "label3";
            label3.Size = new Size(201, 46);
            label3.TabIndex = 26;
            label3.Text = "Net income:";
            // 
            // lblNet
            // 
            lblNet.AutoSize = true;
            lblNet.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNet.Location = new Point(601, 131);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(172, 41);
            lblNet.TabIndex = 27;
            lblNet.Text = "Net income";
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.ControlText;
            btnReload.Image = Properties.Resources.refresh_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnReload.Location = new Point(318, 53);
            btnReload.Margin = new Padding(3, 4, 3, 4);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(66, 65);
            btnReload.TabIndex = 28;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // lblPaid
            // 
            lblPaid.AutoSize = true;
            lblPaid.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaid.Location = new Point(1169, 91);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(80, 41);
            lblPaid.TabIndex = 32;
            lblPaid.Text = "debt";
            // 
            // lblDebt
            // 
            lblDebt.AutoSize = true;
            lblDebt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebt.Location = new Point(1169, 32);
            lblDebt.Name = "lblDebt";
            lblDebt.Size = new Size(80, 41);
            lblDebt.TabIndex = 31;
            lblDebt.Text = "debt";
            // 
            // lblDebtPaid
            // 
            lblDebtPaid.AutoSize = true;
            lblDebtPaid.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebtPaid.Location = new Point(946, 88);
            lblDebtPaid.Name = "lblDebtPaid";
            lblDebtPaid.Size = new Size(226, 46);
            lblDebtPaid.TabIndex = 30;
            lblDebtPaid.Text = "Debt paid off:";
            // 
            // lblDebtotal
            // 
            lblDebtotal.AutoSize = true;
            lblDebtotal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebtotal.Location = new Point(1071, 29);
            lblDebtotal.Name = "lblDebtotal";
            lblDebtotal.Size = new Size(101, 46);
            lblDebtotal.TabIndex = 29;
            lblDebtotal.Text = "Debt:";
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1505, 843);
            Controls.Add(lblPaid);
            Controls.Add(lblDebt);
            Controls.Add(lblDebtPaid);
            Controls.Add(lblDebtotal);
            Controls.Add(btnReload);
            Controls.Add(lblNet);
            Controls.Add(label3);
            Controls.Add(btnLogout);
            Controls.Add(btnSetting);
            Controls.Add(btnHelp);
            Controls.Add(btnUser);
            Controls.Add(btnInput);
            Controls.Add(btnDetails);
            Controls.Add(chtTotal);
            Controls.Add(chtCost);
            Controls.Add(chtDebt);
            Controls.Add(lblTax);
            Controls.Add(lblIncome);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Window;
            Name = "View";
            Text = "Details";
            Load += View_Load;
            ((System.ComponentModel.ISupportInitialize)chtDebt).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        private Label label1;
        private Label label2;
        private Label lblIncome;
        private Label lblTax;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDebt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCost;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTotal;
        private Button btnLogout;
        private Button btnSetting;
        private Button btnHelp;
        private Button btnUser;
        private Button btnInput;
        private Button btnDetails;
        private Label label3;
        private Label lblNet;
        private Button btnReload;
        private Label lblPaid;
        private Label lblDebt;
        private Label lblDebtPaid;
        private Label lblDebtotal;
    }
}