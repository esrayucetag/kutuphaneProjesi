using System;
using System.Windows.Forms;

namespace kutuphaneProjesi.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yoneticiGirisButton_Click(object sender, EventArgs e)
        {
            if (kullaniciAdTextBox.Text == "admin" && sifreTextBox.Text == "admin123")
            {
                MessageBox.Show("Yönetici giriþi baþarýlý");

                YonetimForm yf = new YonetimForm();
                yf.Show();
                
            }
            else
            {
                MessageBox.Show("Hatalý kullanýcý adý veya þifre");
            }
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            uyeKayitForm frm = new uyeKayitForm();
            frm.ShowDialog(); 
        }

        private void uyeGirisButton_Click(object sender, EventArgs e)
        {
            int girisYapanUyeId = 14;
            UyePanelForm upf = new UyePanelForm(girisYapanUyeId);
            upf.ShowDialog();
        }
    }
}