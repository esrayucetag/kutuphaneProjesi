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
            picTemizle = new PictureBox();
            picAra = new PictureBox();
            txtAraTC = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvIslemler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTemizle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAra).BeginInit();
            SuspendLayout();
            // 
            // txtUyeTc
            // 
            txtUyeTc.Location = new Point(76, 69);
            txtUyeTc.Name = "txtUyeTc";
            txtUyeTc.Size = new Size(151, 27);
            txtUyeTc.TabIndex = 0;
            txtUyeTc.TextChanged += txtUyeTC_TextChanged;
            // 
            // cmbKitap
            // 
            cmbKitap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbKitap.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbKitap.FormattingEnabled = true;
            cmbKitap.Location = new Point(489, 35);
            cmbKitap.Name = "cmbKitap";
            cmbKitap.Size = new Size(151, 28);
            cmbKitap.TabIndex = 1;
            // 
            // lblUyeAd
            // 
            lblUyeAd.AutoSize = true;
            lblUyeAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUyeAd.ForeColor = Color.MidnightBlue;
            lblUyeAd.Location = new Point(371, 37);
            lblUyeAd.Name = "lblUyeAd";
            lblUyeAd.Size = new Size(81, 23);
            lblUyeAd.TabIndex = 2;
            lblUyeAd.Text = "kitap seç";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(87, 37);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 3;
            label1.Text = "üye tc giriniz";
            // 
            // btnOduncVer
            // 
            btnOduncVer.BackColor = SystemColors.ButtonFace;
            btnOduncVer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOduncVer.ForeColor = Color.Green;
            btnOduncVer.Location = new Point(229, 426);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(105, 36);
            btnOduncVer.TabIndex = 4;
            btnOduncVer.Text = "ÖDÜNÇ VER";
            btnOduncVer.UseVisualStyleBackColor = false;
            // 
            // dgvIslemler
            // 
            dgvIslemler.BackgroundColor = Color.AliceBlue;
            dgvIslemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIslemler.Location = new Point(76, 182);
            dgvIslemler.Name = "dgvIslemler";
            dgvIslemler.RowHeadersWidth = 51;
            dgvIslemler.Size = new Size(654, 238);
            dgvIslemler.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(76, 124);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 6;
            label2.Text = "AKTİF İŞLEMLER";
            label2.Visible = false;
            // 
            // btnTeslimAl
            // 
            btnTeslimAl.BackColor = SystemColors.ButtonFace;
            btnTeslimAl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTeslimAl.ForeColor = SystemColors.HotTrack;
            btnTeslimAl.Location = new Point(408, 426);
            btnTeslimAl.Name = "btnTeslimAl";
            btnTeslimAl.Size = new Size(106, 36);
            btnTeslimAl.TabIndex = 7;
            btnTeslimAl.Text = "TESLİM AL";
            btnTeslimAl.UseVisualStyleBackColor = false;
            btnTeslimAl.Click += btnTeslimAl_Click;
            // 
            // dtpVerilisTarihi
            // 
            dtpVerilisTarihi.Location = new Point(371, 69);
            dtpVerilisTarihi.Name = "dtpVerilisTarihi";
            dtpVerilisTarihi.Size = new Size(269, 27);
            dtpVerilisTarihi.TabIndex = 8;
            // 
            // picTemizle
            // 
            picTemizle.Cursor = Cursors.Hand;
            picTemizle.Image = Properties.Resources.recycle_bin;
            picTemizle.Location = new Point(698, 154);
            picTemizle.Name = "picTemizle";
            picTemizle.Size = new Size(32, 26);
            picTemizle.SizeMode = PictureBoxSizeMode.Zoom;
            picTemizle.TabIndex = 16;
            picTemizle.TabStop = false;
            // 
            // picAra
            // 
            picAra.Cursor = Cursors.Hand;
            picAra.Image = Properties.Resources.magnifier;
            picAra.Location = new Point(76, 154);
            picAra.Name = "picAra";
            picAra.Size = new Size(32, 26);
            picAra.SizeMode = PictureBoxSizeMode.Zoom;
            picAra.TabIndex = 15;
            picAra.TabStop = false;
            // 
            // txtAraTC
            // 
            txtAraTC.BorderStyle = BorderStyle.None;
            txtAraTC.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAraTC.Location = new Point(114, 154);
            txtAraTC.Multiline = true;
            txtAraTC.Name = "txtAraTC";
            txtAraTC.Size = new Size(578, 26);
            txtAraTC.TabIndex = 14;
            // 
            // islemlerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 189, 203);
            ClientSize = new Size(925, 590);
            Controls.Add(picTemizle);
            Controls.Add(picAra);
            Controls.Add(txtAraTC);
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
            ((System.ComponentModel.ISupportInitialize)dgvIslemler).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTemizle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAra).EndInit();
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
        private PictureBox picTemizle;
        private PictureBox picAra;
        private TextBox txtAraTC;
    }
}