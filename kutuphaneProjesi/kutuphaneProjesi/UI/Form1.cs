using System;
using System.Windows.Forms;
using kutuphaneProjesi.BLL;

namespace kutuphaneProjesi.UI
{
    public partial class Form1 : Form
    {
        private readonly UyePanelBLL uyeBll = new UyePanelBLL(); // ✅ eklendi

        public Form1()
        {
            InitializeComponent();
        }

        private void uyeGirisButton_Click(object sender, EventArgs e)
        {
            var tc = kullaniciAdTextBox.Text.Trim();   // senin ekranda kullanıcı adı = TC
            var sifre = sifreTextBox.Text.Trim();

            var sonuc = uyeBll.UyeGiris(tc, sifre);

            if (!sonuc.ok)
            {
                MessageBox.Show(sonuc.mesaj);
                return;
            }

            // ✅ UyePanel aç
            UyePanelForm panel = new UyePanelForm(sonuc.uyeId, sonuc.adSoyad);
            panel.Show();

            this.Hide();
            panel.FormClosed += (s, args) =>
            {
                this.Show();
                sifreTextBox.Text = "";
            };
        }

        private void yoneticiGirisButton_Click(object sender, EventArgs e)
        {
            string kullanici = kullaniciAdTextBox.Text.Trim();
            string sifre = sifreTextBox.Text.Trim();

            if (kullanici == "admin" && sifre == "admin123")
            {
                YonetimForm panel = new YonetimForm();
                panel.Show();
                this.Hide();

                panel.FormClosed += (s, args) => this.Show();
            }
            else
            {
                MessageBox.Show("Yönetici bilgileri hatalı!");
            }
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            uyeKayitForm frm = new uyeKayitForm();
            frm.ShowDialog();
        }

    }
}
