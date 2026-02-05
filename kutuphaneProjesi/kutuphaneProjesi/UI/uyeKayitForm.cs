using kutuphaneProjesi.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneProjesi.UI
{
    public partial class uyeKayitForm : Form
    {
        public uyeKayitForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Temel kontroller
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler birbiriyle uyuşmuyor!");
                return;
            }

            if (txtTc.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 haneli olmalıdır!");
                return;
            }

            uyelerDAL uDal = new uyelerDAL();
            bool basarili = uDal.YeniUyeKaydet(txtTc.Text, txtAdSoyad.Text, txtSifre.Text);

            if (basarili)
            {
                MessageBox.Show("Kaydınız başarıyla oluşturuldu. Giriş yapabilirsiniz.");
                this.Close(); // Kayıt formunu kapatır
            }
        }

        private void lblTc_Click(object sender, EventArgs e)
        {

        }
    }
}
