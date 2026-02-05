using Org.BouncyCastle.Asn1.Crmf;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace kutuphaneProjesi.UI
{
    partial class UyelerForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvUyeler = new DataGridView();
            txtTc = new TextBox();
            txtAdSoyad = new TextBox();
            txtSifre = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAraTC = new TextBox();
            picAra = new PictureBox();
            picTemizle = new PictureBox();
            btnKaraListe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTemizle).BeginInit();
            SuspendLayout();
            // 
            // dgvUyeler
            // 
            dgvUyeler.BackgroundColor = Color.AliceBlue;
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.Location = new Point(23, 52);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.Size = new Size(827, 279);
            dgvUyeler.TabIndex = 0;
            dgvUyeler.CellClick += dgvUyeler_CellClick;
            // 
            // txtTc
            // 
            txtTc.BackColor = SystemColors.ButtonFace;
            txtTc.Location = new Point(163, 345);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(200, 27);
            txtTc.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = SystemColors.ButtonFace;
            txtAdSoyad.Location = new Point(163, 389);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(200, 27);
            txtAdSoyad.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.ButtonFace;
            txtSifre.Location = new Point(163, 429);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(200, 27);
            txtSifre.TabIndex = 6;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ButtonFace;
            btnEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.ForeColor = Color.Green;
            btnEkle.Location = new Point(387, 349);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 29);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ButtonFace;
            btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.FromArgb(192, 0, 0);
            btnSil.Location = new Point(387, 389);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 29);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ButtonFace;
            btnGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.ForeColor = Color.Teal;
            btnGuncelle.Location = new Point(387, 429);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 29);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(57, 349);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = "TC:";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(57, 389);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(57, 429);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "Şifre:";
            // 
            // txtAraTC
            // 
            txtAraTC.BorderStyle = BorderStyle.None;
            txtAraTC.Font = new System.Drawing.Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAraTC.Location = new Point(83, 14);
            txtAraTC.Multiline = true;
            txtAraTC.Name = "txtAraTC";
            txtAraTC.Size = new Size(696, 30);
            txtAraTC.TabIndex = 9;
            txtAraTC.KeyDown += txtAraTC_KeyDown;
            // 
            // picAra
            // 
            picAra.Cursor = Cursors.Hand;
            picAra.Image = Properties.Resources.magnifier;
            picAra.Location = new Point(23, 12);
            picAra.Name = "picAra";
            picAra.Size = new Size(54, 34);
            picAra.SizeMode = PictureBoxSizeMode.Zoom;
            picAra.TabIndex = 12;
            picAra.TabStop = false;
            picAra.Click += picAra_Click;
            // 
            // picTemizle
            // 
            picTemizle.Cursor = Cursors.Hand;
            picTemizle.Image = Properties.Resources.recycle_bin;
            picTemizle.Location = new Point(801, 12);
            picTemizle.Name = "picTemizle";
            picTemizle.Size = new Size(49, 34);
            picTemizle.SizeMode = PictureBoxSizeMode.Zoom;
            picTemizle.TabIndex = 13;
            picTemizle.TabStop = false;
            picTemizle.Click += picTemizle_Click;
            // 
            // btnKaraListe
            // 
            btnKaraListe.BackColor = Color.Black;
            btnKaraListe.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaraListe.ForeColor = SystemColors.ButtonHighlight;
            btnKaraListe.Location = new Point(777, 337);
            btnKaraListe.Name = "btnKaraListe";
            btnKaraListe.Size = new Size(73, 54);
            btnKaraListe.TabIndex = 14;
            btnKaraListe.Text = "kara liste";
            btnKaraListe.UseVisualStyleBackColor = false;
            btnKaraListe.Click += btnKaraListe_Click;
            // 
            // UyelerForm
            // 
            BackColor = Color.FromArgb(188, 189, 203);
            ClientSize = new Size(876, 520);
            Controls.Add(btnKaraListe);
            Controls.Add(picTemizle);
            Controls.Add(picAra);
            Controls.Add(txtAraTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtSifre);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTc);
            Controls.Add(dgvUyeler);
            Name = "UyelerForm";
            Text = "Üyeler";
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAra).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTemizle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUyeler;
        private TextBox txtTc;
        private TextBox txtAdSoyad;
        private TextBox txtSifre;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAraTC;
        private PictureBox picAra;
        private PictureBox picTemizle;
        private Button btnKaraListe;
    }
}
