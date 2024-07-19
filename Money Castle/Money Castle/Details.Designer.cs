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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)chtDebt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtTotal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(515, 21);
            label1.Name = "label1";
            label1.Size = new Size(67, 41);
            label1.TabIndex = 3;
            label1.Text = "Tax:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(343, 76);
            label2.Name = "label2";
            label2.Size = new Size(239, 41);
            label2.TabIndex = 4;
            label2.Text = "Income after tax:";
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
            lblTax.Location = new Point(601, 21);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(57, 41);
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
            button1.Location = new Point(548, 426);
            button1.Name = "button1";
            button1.Size = new Size(191, 53);
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
            legend1.Name = "Legend1";
            chtDebt.Legends.Add(legend1);
            chtDebt.Location = new Point(178, 133);
            chtDebt.Name = "chtDebt";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chtDebt.Series.Add(series1);
            chtDebt.Size = new Size(302, 226);
            chtDebt.TabIndex = 14;
            chtDebt.Text = "chart1";
            // 
            // chtCost
            // 
            chartArea2.Name = "ChartArea1";
            chtCost.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chtCost.Legends.Add(legend2);
            chtCost.Location = new Point(500, 133);
            chtCost.Name = "chtCost";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chtCost.Series.Add(series2);
            chtCost.Size = new Size(302, 226);
            chtCost.TabIndex = 15;
            chtCost.Text = "chart2";
            // 
            // chtTotal
            // 
            chartArea3.Name = "ChartArea1";
            chtTotal.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chtTotal.Legends.Add(legend3);
            chtTotal.Location = new Point(826, 133);
            chtTotal.Name = "chtTotal";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chtTotal.Series.Add(series3);
            chtTotal.Size = new Size(302, 226);
            chtTotal.TabIndex = 16;
            chtTotal.Text = "chart3";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ControlText;
            btnLogout.Image = Properties.Resources.logout_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnLogout.Location = new Point(22, 425);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 62);
            btnLogout.TabIndex = 25;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = SystemColors.ControlText;
            btnSetting.Image = Properties.Resources.settings_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnSetting.Location = new Point(22, 342);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(75, 68);
            btnSetting.TabIndex = 24;
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.ControlText;
            btnHelp.Image = Properties.Resources.info_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnHelp.ImageAlign = ContentAlignment.MiddleRight;
            btnHelp.Location = new Point(-1, 250);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(119, 86);
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
            btnUser.Location = new Point(-1, 169);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(119, 86);
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
            btnInput.Location = new Point(-1, 87);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(119, 86);
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
            btnDetails.Location = new Point(-1, 5);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(119, 86);
            btnDetails.TabIndex = 20;
            btnDetails.Text = "Details";
            btnDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnDetails.UseVisualStyleBackColor = false;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1182, 501);
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
    }
}