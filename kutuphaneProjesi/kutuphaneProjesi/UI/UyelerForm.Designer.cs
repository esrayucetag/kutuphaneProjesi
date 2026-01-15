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
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            SuspendLayout();
            // 
            // dgvUyeler
            // 
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.Location = new Point(12, 12);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.Size = new Size(743, 200);
            dgvUyeler.TabIndex = 0;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(129, 335);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(200, 27);
            txtTc.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(129, 379);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(200, 27);
            txtAdSoyad.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(129, 419);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(200, 27);
            txtSifre.TabIndex = 6;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Location = new Point(353, 339);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 29);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Location = new Point(353, 379);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 29);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.GradientInactiveCaption;
            btnGuncelle.Location = new Point(353, 419);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 29);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click_1;
            // 
            // label1
            // 
            label1.Location = new Point(23, 339);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 2;
            label1.Text = "TC:";
            // 
            // label2
            // 
            label2.Location = new Point(23, 379);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            label3.Location = new Point(23, 419);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "Şifre:";
            // 
            // UyelerForm
            // 
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(876, 520);
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
    }
}
