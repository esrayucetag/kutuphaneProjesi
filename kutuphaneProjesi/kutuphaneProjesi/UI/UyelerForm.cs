using System;
using System.Windows.Forms;
using kutuphaneProjesi.BLL;

namespace kutuphaneProjesi.UI
{
    public partial class UyelerForm : Form
    {
        uyelerBLL bll = new uyelerBLL();

        public UyelerForm()
        {
            InitializeComponent();
            Listele();
        }

        void Listele()
        {
            dgvUyeler.DataSource = bll.UyeleriGetir();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["userId"].Value);
            bll.UyeSil(id);
            MessageBox.Show("Üye silindi");
            Listele();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["userId"].Value);
            bll.UyeGuncelle(id, txtTc.Text, txtAdSoyad.Text, txtSifre.Text);
            MessageBox.Show("Üye güncellendi");
            Listele();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            bll.UyeEkle(txtTc.Text, txtAdSoyad.Text, txtSifre.Text);
            MessageBox.Show("Üye eklendi");
            Listele();
        }
    }
}
