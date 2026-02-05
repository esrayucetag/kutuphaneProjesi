#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;
using kutuphaneProjesi.BLL;

namespace kutuphaneProjesi.UI
{
    public partial class UyelerForm : Form
    {
        private readonly uyelerBLL bll = new uyelerBLL();
        private bool karaListeModu = false; // false: normal üyeler, true: kara liste

        public UyelerForm()
        {
            InitializeComponent();

            
            dgvUyeler.CellClick += dgvUyeler_CellClick;

       
            dgvUyeler.DataBindingComplete += dgvUyeler_DataBindingComplete;

            picAra.Click += picAra_Click;
            picTemizle.Click += picTemizle_Click;
            txtAraTC.KeyDown += txtAraTC_KeyDown;

            Listele();
        }

        private void Listele()
        {
            karaListeModu = false;
            dgvUyeler.DataSource = bll.UyeleriGetir();
            // GridDuzelt() çağırmana gerek yok, DataBindingComplete zaten çağıracak
        }

        private void KaraListeyiListele()
        {
            karaListeModu = true;
            dgvUyeler.DataSource = bll.KaraListeGetir();
            // GridDuzelt() çağırmana gerek yok, DataBindingComplete zaten çağıracak
        }

        // ✅ DataSource bağlanınca WinForms grid'i resetler -> biz burada tekrar stil basıyoruz
        private void dgvUyeler_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridDuzelt();
        }

        private void GridDuzelt()
        {
            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUyeler.ReadOnly = true;
            dgvUyeler.AllowUserToAddRows = false;
            dgvUyeler.AllowUserToDeleteRows = false;
            dgvUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUyeler.MultiSelect = false;
            dgvUyeler.RowHeadersVisible = false;

            // (İstersen kitaplar sayfasındaki gibi header rengi de ekleyebilirsin)
            dgvUyeler.EnableHeadersVisualStyles = false;
            dgvUyeler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(36, 47, 61);
            dgvUyeler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUyeler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvUyeler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dgvUyeler.DefaultCellStyle.SelectionForeColor = Color.Black;

            // İSTEMEDİĞİN checkbox kolonlarını sakla (DB’de kalsın ama ekranda görünmesin)
            if (dgvUyeler.Columns.Contains("karaListe"))
                dgvUyeler.Columns["karaListe"].Visible = false;

            if (dgvUyeler.Columns.Contains("banli"))
                dgvUyeler.Columns["banli"].Visible = false;

            // başlıklar (senin tasarıma uygun)
            if (dgvUyeler.Columns.Contains("userId")) dgvUyeler.Columns["userId"].HeaderText = "ID";
            if (dgvUyeler.Columns.Contains("userTc")) dgvUyeler.Columns["userTc"].HeaderText = "TC";
            if (dgvUyeler.Columns.Contains("userAdSoyad")) dgvUyeler.Columns["userAdSoyad"].HeaderText = "Ad Soyad";
            if (dgvUyeler.Columns.Contains("gecikmeSayisi")) dgvUyeler.Columns["gecikmeSayisi"].HeaderText = "Gecikme";
            if (dgvUyeler.Columns.Contains("password")) dgvUyeler.Columns["password"].HeaderText = "Şifre";
        }

        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUyeler.CurrentRow == null) return;

            txtTc.Text = dgvUyeler.CurrentRow.Cells["userTc"].Value?.ToString() ?? "";
            txtAdSoyad.Text = dgvUyeler.CurrentRow.Cells["userAdSoyad"].Value?.ToString() ?? "";
            txtSifre.Text = dgvUyeler.CurrentRow.Cells["password"].Value?.ToString() ?? "";
        }

        private void picAra_Click(object sender, EventArgs e)
        {
            string tc = txtAraTC.Text.Trim();
            if (string.IsNullOrWhiteSpace(tc))
            {
                MessageBox.Show("TC giriniz");
                return;
            }

            dgvUyeler.DataSource = bll.UyeAraTC(tc, karaListeModu);
            // GridDuzelt() gerek yok, DataBindingComplete çalışacak
        }

        private void txtAraTC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                picAra_Click(sender, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void picTemizle_Click(object sender, EventArgs e)
        {
            txtAraTC.Clear();
            Listele(); 
        }

        private void btnKaraListe_Click(object sender, EventArgs e)
        { 
            if (!karaListeModu)
            {
                KaraListeyiListele();
                return;
            }

            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bll.UyeEkle(txtTc.Text, txtAdSoyad.Text, txtSifre.Text);
            MessageBox.Show("Üye eklendi");
            if (karaListeModu) KaraListeyiListele(); else Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["userId"].Value);
            bll.UyeSil(id);
            MessageBox.Show("Üye silindi");
            if (karaListeModu) KaraListeyiListele(); else Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["userId"].Value);
            bll.UyeGuncelle(id, txtTc.Text, txtAdSoyad.Text, txtSifre.Text);
            MessageBox.Show("Üye güncellendi");
            if (karaListeModu) KaraListeyiListele(); else Listele();
        }

    }
}
