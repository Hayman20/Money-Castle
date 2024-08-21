namespace Money_Castle
{
    partial class Raw_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raw_data));
            lsvOutput = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            cmbSort = new ComboBox();
            btnGraph = new Button();
            label3 = new Label();
            btnDelete = new Button();
            cmbType = new ComboBox();
            txtCost = new TextBox();
            txtStore = new TextBox();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            btnAdd = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lsvOutput
            // 
            lsvOutput.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvOutput.ForeColor = SystemColors.MenuText;
            lsvOutput.Location = new Point(124, 64);
            lsvOutput.Name = "lsvOutput";
            lsvOutput.Size = new Size(546, 175);
            lsvOutput.TabIndex = 4;
            lsvOutput.UseCompatibleStateImageBehavior = false;
            lsvOutput.View = System.Windows.Forms.View.Details;
            lsvOutput.SelectedIndexChanged += lsvOutput_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Store";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cost";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Type";
            columnHeader4.Width = 100;
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Type", "Date", "Store" });
            cmbSort.Location = new Point(308, 255);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(151, 28);
            cmbSort.TabIndex = 21;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // btnGraph
            // 
            btnGraph.BackColor = SystemColors.InactiveCaptionText;
            btnGraph.ForeColor = SystemColors.ButtonHighlight;
            btnGraph.Image = Properties.Resources.keyboard_backspace_20dp_FILL0_wght300_GRAD0_opsz20;
            btnGraph.ImageAlign = ContentAlignment.MiddleRight;
            btnGraph.Location = new Point(190, 440);
            btnGraph.Name = "btnGraph";
            btnGraph.Size = new Size(106, 75);
            btnGraph.TabIndex = 22;
            btnGraph.Text = "Back";
            btnGraph.TextAlign = ContentAlignment.MiddleLeft;
            btnGraph.UseVisualStyleBackColor = false;
            btnGraph.Click += btnGraph_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(227, 258);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 23;
            label3.Text = "Sort by:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.InactiveCaptionText;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(466, 440);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 75);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete Cost";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Food", "Bills ", "Entertainment", "Other" });
            cmbType.Location = new Point(308, 390);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(111, 28);
            cmbType.TabIndex = 54;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(308, 357);
            txtCost.Name = "txtCost";
            txtCost.PlaceholderText = "Cost";
            txtCost.Size = new Size(125, 27);
            txtCost.TabIndex = 53;
            // 
            // txtStore
            // 
            txtStore.Location = new Point(308, 324);
            txtStore.Name = "txtStore";
            txtStore.PlaceholderText = "Store";
            txtStore.Size = new Size(125, 27);
            txtStore.TabIndex = 52;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "MM/yyyy";
            dtpDate.ImeMode = ImeMode.Off;
            dtpDate.Location = new Point(308, 294);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 51;
            dtpDate.Value = new DateTime(2024, 7, 19, 12, 38, 34, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(190, 293);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 50;
            label2.Text = "Add a Cost:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.InactiveCaptionText;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Image = Properties.Resources.add_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(308, 440);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 75);
            btnAdd.TabIndex = 55;
            btnAdd.Text = "Add Cost ";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(227, 14);
            label1.Name = "label1";
            label1.Size = new Size(292, 38);
            label1.TabIndex = 56;
            label1.Text = "Add or Remove a Cost";
            // 
            // Raw_data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(800, 530);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(cmbType);
            Controls.Add(txtCost);
            Controls.Add(txtStore);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(label3);
            Controls.Add(btnGraph);
            Controls.Add(cmbSort);
            Controls.Add(lsvOutput);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Raw_data";
            Text = "Costs";
            Load += Raw_data_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lsvOutput;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ComboBox cmbSort;
        private Button btnGraph;
        private Label label3;
        private Button btnDelete;
        private ComboBox cmbType;
        private TextBox txtCost;
        private TextBox txtStore;
        private DateTimePicker dtpDate;
        private Label label2;
        private Button btnAdd;
        private Label label1;
    }
}