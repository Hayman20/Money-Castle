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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            lblIncome = new Label();
            lblTax = new Label();
            button1 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)chtDebt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtTotal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(451, 16);
            label1.Name = "label1";
            label1.Size = new Size(52, 32);
            label1.TabIndex = 3;
            label1.Text = "Tax:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(412, 57);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 4;
            label2.Text = "Income:";
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblIncome.Location = new Point(526, 57);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(93, 32);
            lblIncome.TabIndex = 5;
            lblIncome.Text = "income";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTax.Location = new Point(526, 16);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(45, 32);
            lblTax.TabIndex = 6;
            lblTax.Text = "tax";
            lblTax.Click += lblTax_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.monitoring_20dp_FILL0_wght400_GRAD0_opsz20;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(465, 562);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(167, 40);
            button1.TabIndex = 7;
            button1.Text = "View raw data";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chtDebt
            // 
            chartArea1.Name = "ChartArea1";
            chtDebt.ChartAreas.Add(chartArea1);
            chtDebt.Location = new Point(118, 137);
            chtDebt.Margin = new Padding(3, 2, 3, 2);
            chtDebt.Name = "chtDebt";
            chtDebt.Size = new Size(264, 170);
            chtDebt.TabIndex = 14;
            chtDebt.Text = "Debt";
            title1.Name = "Title1";
            title1.Text = "Debt";
            chtDebt.Titles.Add(title1);
            chtDebt.Click += chtDebt_Click;
            // 
            // chtCost
            // 
            chtCost.Location = new Point(412, 138);
            chtCost.Margin = new Padding(3, 2, 3, 2);
            chtCost.Name = "chtCost";
            chtCost.Size = new Size(293, 395);
            chtCost.TabIndex = 15;
            chtCost.Text = "chart2";
            chtCost.Click += chtCost_Click;
            // 
            // chtTotal
            // 
            chartArea2.Name = "ChartArea1";
            chtTotal.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            chtTotal.Legends.Add(legend1);
            chtTotal.Location = new Point(720, 138);
            chtTotal.Margin = new Padding(3, 2, 3, 2);
            chtTotal.Name = "chtTotal";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chtTotal.Series.Add(series1);
            chtTotal.Size = new Size(264, 170);
            chtTotal.TabIndex = 16;
            chtTotal.Text = "chart3";
            chtTotal.Click += chtTotal_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlText;
            btnLogout.Image = Properties.Resources.logout_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnLogout.Location = new Point(19, 319);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(66, 46);
            btnLogout.TabIndex = 25;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ControlText;
            btnSetting.Image = Properties.Resources.settings_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnSetting.Location = new Point(19, 256);
            btnSetting.Margin = new Padding(3, 2, 3, 2);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(66, 51);
            btnSetting.TabIndex = 24;
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.info_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnHelp.ImageAlign = ContentAlignment.MiddleRight;
            btnHelp.Location = new Point(-1, 188);
            btnHelp.Margin = new Padding(3, 2, 3, 2);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(104, 64);
            btnHelp.TabIndex = 23;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.ControlText;
            btnUser.Image = Properties.Resources.badge_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnUser.ImageAlign = ContentAlignment.MiddleRight;
            btnUser.Location = new Point(-1, 127);
            btnUser.Margin = new Padding(3, 2, 3, 2);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(104, 64);
            btnUser.TabIndex = 22;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnInput
            // 
            btnInput.BackColor = SystemColors.ControlText;
            btnInput.Image = Properties.Resources.upload_file_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnInput.ImageAlign = ContentAlignment.MiddleRight;
            btnInput.Location = new Point(-1, 65);
            btnInput.Margin = new Padding(3, 2, 3, 2);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(104, 64);
            btnInput.TabIndex = 21;
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
            btnDetails.Location = new Point(-1, 4);
            btnDetails.Margin = new Padding(3, 2, 3, 2);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(104, 64);
            btnDetails.TabIndex = 20;
            btnDetails.Text = "Details";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(364, 99);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 26;
            label3.Text = "Net income:";
            // 
            // lblNet
            // 
            lblNet.AutoSize = true;
            lblNet.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNet.Location = new Point(516, 99);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(139, 32);
            lblNet.TabIndex = 27;
            lblNet.Text = "Net income";
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.ControlText;
            btnReload.Image = Properties.Resources.refresh_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnReload.Location = new Point(278, 40);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(58, 49);
            btnReload.TabIndex = 28;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1034, 632);
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
            Controls.Add(button1);
            Controls.Add(lblTax);
            Controls.Add(lblIncome);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Window;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button button1;
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
    }
}