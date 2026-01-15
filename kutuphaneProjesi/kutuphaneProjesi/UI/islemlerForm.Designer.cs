namespace kutuphaneProjesi.UI
{
    partial class islemlerForm
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
            txtUyeTc = new TextBox();
            cmbKitap = new ComboBox();
            lblUyeAd = new Label();
            label1 = new Label();
            btnOduncVer = new Button();
            dgvIslemler = new DataGridView();
            label2 = new Label();
            btnTeslimAl = new Button();
            dtpVerilisTarihi = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvIslemler).BeginInit();
            SuspendLayout();
            // 
            // txtUyeTc
            // 
            txtUyeTc.Location = new Point(112, 59);
            txtUyeTc.Name = "txtUyeTc";
            txtUyeTc.Size = new Size(125, 27);
            txtUyeTc.TabIndex = 0;
            txtUyeTc.TextChanged += txtUyeTC_TextChanged;
            // 
            // cmbKitap
            // 
            cmbKitap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbKitap.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbKitap.FormattingEnabled = true;
            cmbKitap.Location = new Point(100, 102);
            cmbKitap.Name = "cmbKitap";
            cmbKitap.Size = new Size(151, 28);
            cmbKitap.TabIndex = 1;
            // 
            // lblUyeAd
            // 
            lblUyeAd.AutoSize = true;
            lblUyeAd.Location = new Point(29, 105);
            lblUyeAd.Name = "lblUyeAd";
            lblUyeAd.Size = new Size(50, 20);
            lblUyeAd.TabIndex = 2;
            lblUyeAd.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 36);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 3;
            label1.Text = "üye tc";
            // 
            // btnOduncVer
            // 
            btnOduncVer.Location = new Point(248, 381);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(94, 36);
            btnOduncVer.TabIndex = 4;
            btnOduncVer.Text = "ödünç ver";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click_1;
            // 
            // dgvIslemler
            // 
            dgvIslemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIslemler.Location = new Point(74, 177);
            dgvIslemler.Name = "dgvIslemler";
            dgvIslemler.RowHeadersWidth = 51;
            dgvIslemler.Size = new Size(609, 188);
            dgvIslemler.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 154);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // btnTeslimAl
            // 
            btnTeslimAl.Location = new Point(404, 381);
            btnTeslimAl.Name = "btnTeslimAl";
            btnTeslimAl.Size = new Size(96, 36);
            btnTeslimAl.TabIndex = 7;
            btnTeslimAl.Text = "teslim al";
            btnTeslimAl.UseVisualStyleBackColor = true;
            btnTeslimAl.Click += btnTeslimAl_Click;
            // 
            // dtpVerilisTarihi
            // 
            dtpVerilisTarihi.Location = new Point(290, 105);
            dtpVerilisTarihi.Name = "dtpVerilisTarihi";
            dtpVerilisTarihi.Size = new Size(269, 27);
            dtpVerilisTarihi.TabIndex = 8;
            // 
            // islemlerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpVerilisTarihi);
            Controls.Add(btnTeslimAl);
            Controls.Add(label2);
            Controls.Add(dgvIslemler);
            Controls.Add(btnOduncVer);
            Controls.Add(label1);
            Controls.Add(lblUyeAd);
            Controls.Add(cmbKitap);
            Controls.Add(txtUyeTc);
            Name = "islemlerForm";
            Text = "v";
            Load += islemlerForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvIslemler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUyeTc;
        private ComboBox cmbKitap;
        private Label lblUyeAd;
        private Label label1;
        private Button btnOduncVer;
        private DataGridView dgvIslemler;
        private Label label2;
        private Button btnTeslimAl;
        private DateTimePicker dtpVerilisTarihi;
    }
}