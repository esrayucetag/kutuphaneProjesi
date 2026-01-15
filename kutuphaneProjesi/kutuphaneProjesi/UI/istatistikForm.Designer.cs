namespace kutuphaneProjesi.UI
{
    partial class istatistikForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblKitap = new Label();
            txtToplamKitap = new TextBox();
            panel2 = new Panel();
            lblUye = new Label();
            txtToplamUye = new TextBox();
            panel3 = new Panel();
            lblOdunc = new Label();
            txtOduncKitap = new TextBox();
            panelAltGrafik = new Panel();
            lblEnCokOkuyanlar = new Label();
            dgvEnCokOkuyanlar = new DataGridView();
            pnlIstatistik = new Panel();
            dgvIstatistik = new DataGridView();
            btnRaporGeciken = new Button();
            btnRaporPopuler = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelAltGrafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnCokOkuyanlar).BeginInit();
            pnlIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIstatistik).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblKitap);
            panel1.Controls.Add(txtToplamKitap);
            panel1.Location = new Point(30, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 112);
            panel1.TabIndex = 0;
            // 
            // lblKitap
            // 
            lblKitap.Location = new Point(60, 20);
            lblKitap.Name = "lblKitap";
            lblKitap.Size = new Size(100, 23);
            lblKitap.TabIndex = 0;
            lblKitap.Text = "Toplam Kitap";
            // 
            // txtToplamKitap
            // 
            txtToplamKitap.Location = new Point(40, 70);
            txtToplamKitap.Name = "txtToplamKitap";
            txtToplamKitap.ReadOnly = true;
            txtToplamKitap.Size = new Size(140, 27);
            txtToplamKitap.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblUye);
            panel2.Controls.Add(txtToplamUye);
            panel2.Location = new Point(265, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 112);
            panel2.TabIndex = 1;
            // 
            // lblUye
            // 
            lblUye.Location = new Point(65, 20);
            lblUye.Name = "lblUye";
            lblUye.Size = new Size(100, 23);
            lblUye.TabIndex = 0;
            lblUye.Text = "Toplam Üye";
            // 
            // txtToplamUye
            // 
            txtToplamUye.Location = new Point(40, 70);
            txtToplamUye.Name = "txtToplamUye";
            txtToplamUye.ReadOnly = true;
            txtToplamUye.Size = new Size(140, 27);
            txtToplamUye.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblOdunc);
            panel3.Controls.Add(txtOduncKitap);
            panel3.Location = new Point(508, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 112);
            panel3.TabIndex = 2;
            // 
            // lblOdunc
            // 
            lblOdunc.Location = new Point(50, 20);
            lblOdunc.Name = "lblOdunc";
            lblOdunc.Size = new Size(100, 23);
            lblOdunc.TabIndex = 0;
            lblOdunc.Text = "Ödünçteki Kitaplar";
            // 
            // txtOduncKitap
            // 
            txtOduncKitap.Location = new Point(40, 70);
            txtOduncKitap.Name = "txtOduncKitap";
            txtOduncKitap.ReadOnly = true;
            txtOduncKitap.Size = new Size(140, 27);
            txtOduncKitap.TabIndex = 1;
            // 
            // panelAltGrafik
            // 
            panelAltGrafik.BackColor = Color.AliceBlue;
            panelAltGrafik.BorderStyle = BorderStyle.FixedSingle;
            panelAltGrafik.Controls.Add(lblEnCokOkuyanlar);
            panelAltGrafik.Controls.Add(dgvEnCokOkuyanlar);
            panelAltGrafik.Location = new Point(30, 185);
            panelAltGrafik.Name = "panelAltGrafik";
            panelAltGrafik.Size = new Size(676, 226);
            panelAltGrafik.TabIndex = 3;
            panelAltGrafik.Paint += panelAltGrafik_Paint;
            // 
            // lblEnCokOkuyanlar
            // 
            lblEnCokOkuyanlar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEnCokOkuyanlar.Location = new Point(20, 15);
            lblEnCokOkuyanlar.Name = "lblEnCokOkuyanlar";
            lblEnCokOkuyanlar.Size = new Size(300, 25);
            lblEnCokOkuyanlar.TabIndex = 0;
            lblEnCokOkuyanlar.Text = "EN ÇOK KİTAP OKUYAN ÜYELER";
            // 
            // dgvEnCokOkuyanlar
            // 
            dgvEnCokOkuyanlar.BackgroundColor = Color.White;
            dgvEnCokOkuyanlar.ColumnHeadersHeight = 29;
            dgvEnCokOkuyanlar.Location = new Point(20, 50);
            dgvEnCokOkuyanlar.Name = "dgvEnCokOkuyanlar";
            dgvEnCokOkuyanlar.RowHeadersWidth = 51;
            dgvEnCokOkuyanlar.Size = new Size(591, 149);
            dgvEnCokOkuyanlar.TabIndex = 1;
            // 
            // pnlIstatistik
            // 
            pnlIstatistik.Controls.Add(dgvIstatistik);
            pnlIstatistik.Location = new Point(30, 417);
            pnlIstatistik.Name = "pnlIstatistik";
            pnlIstatistik.Size = new Size(676, 217);
            pnlIstatistik.TabIndex = 4;
            // 
            // dgvIstatistik
            // 
            dgvIstatistik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIstatistik.Location = new Point(3, 3);
            dgvIstatistik.Name = "dgvIstatistik";
            dgvIstatistik.RowHeadersWidth = 51;
            dgvIstatistik.Size = new Size(670, 211);
            dgvIstatistik.TabIndex = 0;
            // 
            // btnRaporGeciken
            // 
            btnRaporGeciken.Location = new Point(33, 640);
            btnRaporGeciken.Name = "btnRaporGeciken";
            btnRaporGeciken.Size = new Size(141, 72);
            btnRaporGeciken.TabIndex = 5;
            btnRaporGeciken.Text = "geciken kitaplar görüntüle";
            btnRaporGeciken.UseVisualStyleBackColor = true;
            btnRaporGeciken.Click += btnRaporGeciken_Click;
            // 
            // btnRaporPopuler
            // 
            btnRaporPopuler.Location = new Point(572, 642);
            btnRaporPopuler.Name = "btnRaporPopuler";
            btnRaporPopuler.Size = new Size(134, 70);
            btnRaporPopuler.TabIndex = 6;
            btnRaporPopuler.Text = "en cok okunan kitaplar görüntüle";
            btnRaporPopuler.UseVisualStyleBackColor = true;
            btnRaporPopuler.Click += btnRaporPopuler_Click;
            // 
            // istatistikForm
            // 
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(923, 768);
            Controls.Add(btnRaporPopuler);
            Controls.Add(btnRaporGeciken);
            Controls.Add(pnlIstatistik);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panelAltGrafik);
            Name = "istatistikForm";
            Text = "Kütüphane Analiz ve İstatistik";
            Load += istatistikForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelAltGrafik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnCokOkuyanlar).EndInit();
            pnlIstatistik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIstatistik).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAltGrafik;
        private System.Windows.Forms.TextBox txtToplamKitap;
        private System.Windows.Forms.TextBox txtToplamUye;
        private System.Windows.Forms.TextBox txtOduncKitap;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.Label lblUye;
        private System.Windows.Forms.Label lblOdunc;
        private System.Windows.Forms.Label lblEnCokOkuyanlar;
        private System.Windows.Forms.DataGridView dgvEnCokOkuyanlar;
        private Panel pnlIstatistik;
        private DataGridView dgvIstatistik;
        private Button btnRaporGeciken;
        private Button btnRaporPopuler;
    }
}