using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using kutuphaneProjesi.BLL;

namespace kutuphaneProjesi.UI
{
    public partial class islemlerForm : Form
    {
        private readonly islemlerBLL bll = new islemlerBLL();

        public islemlerForm()
        {
            InitializeComponent();

            this.Load += islemlerForm_Load;

            txtUyeTc.TextChanged += txtUyeTC_TextChanged;
            btnOduncVer.Click += btnOduncVer_Click;
            btnTeslimAl.Click += btnTeslimAl_Click;
        }

        private void islemlerForm_Load(object? sender, EventArgs e)
        {
            KitaplariYukle();
            IslemleriListele();
            GridDuzelt();
        }

        private void KitaplariYukle()
        {
            DataTable dt = bll.KitaplariListele();

            if (!dt.Columns.Contains("Display"))
                dt.Columns.Add("Display", typeof(string), "kitapAd");

            cmbKitap.DataSource = dt;
            cmbKitap.DisplayMember = "Display";
            cmbKitap.ValueMember = "id";

            cmbKitap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbKitap.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbKitap.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;
        }

        private void IslemleriListele()
        {
            dgvIslemler.DataSource = bll.IslemleriListele();
        }

        private void GridDuzelt()
        {
            dgvIslemler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIslemler.ReadOnly = true;
            dgvIslemler.AllowUserToAddRows = false;
            dgvIslemler.AllowUserToDeleteRows = false;
            dgvIslemler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvIslemler.MultiSelect = true;
            dgvIslemler.RowHeadersVisible = false;

            dgvIslemler.EnableHeadersVisualStyles = false;
            dgvIslemler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(36, 47, 61);
            dgvIslemler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvIslemler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvIslemler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dgvIslemler.DefaultCellStyle.SelectionForeColor = Color.Black;

            if (dgvIslemler.Columns.Contains("id")) dgvIslemler.Columns["id"].HeaderText = "ID";
            if (dgvIslemler.Columns.Contains("userAdSoyad")) dgvIslemler.Columns["userAdSoyad"].HeaderText = "Üye";
            if (dgvIslemler.Columns.Contains("kitapAd")) dgvIslemler.Columns["kitapAd"].HeaderText = "Kitap";
            if (dgvIslemler.Columns.Contains("verilisTarihi")) dgvIslemler.Columns["verilisTarihi"].HeaderText = "Alış";
            if (dgvIslemler.Columns.Contains("teslimTarihi")) dgvIslemler.Columns["teslimTarihi"].HeaderText = "Son Teslim";

            if (dgvIslemler.Columns.Contains("kitapId"))
                dgvIslemler.Columns["kitapId"].Visible = false;
        }

        private void txtUyeTC_TextChanged(object? sender, EventArgs e)
        {
            string tc = txtUyeTc.Text.Trim();

            if (tc.Length != 11)
            {
                label1.Text = "";
                label2.Text = "0";
                return;
            }

            DataTable dt = bll.UyeBul(tc);

            if (dt.Rows.Count > 0)
            {
                label1.Text = dt.Rows[0]["userAdSoyad"].ToString();
                label2.Text = dt.Rows[0]["userId"].ToString();
            }
            else
            {
                label1.Text = "Üye Bulunamadı";
                label2.Text = "0";
            }
        }

        private void btnOduncVer_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(label2.Text, out int uId) || uId <= 0)
                {
                    MessageBox.Show("Geçerli bir üye TC giriniz.");
                    return;
                }

                if (!int.TryParse(cmbKitap.SelectedValue?.ToString(), out int kId) || kId <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir kitap seçiniz.");
                    return;
                }

                DateTime alindigiTarih = dtpVerilisTarihi.Value;

                int aktif = bll.AktifOduncSayisi(uId);
                if (aktif >= 3)
                {
                    MessageBox.Show("Bu üyede zaten 3 kitap var. Daha fazla ödünç verilemez.");
                    return;
                }

                var durum = bll.UyeDurumGetir(uId);
                if (durum.karaListe == 1)
                {
                    MessageBox.Show("Bu üye KARA LİSTEDE! Ödünç verilemez.");
                    return;
                }

                bool ok = bll.OduncVer(uId, kId, alindigiTarih);

                if (ok)
                {
                    MessageBox.Show(
                        "İşlem Başarılı!\n" +
                        "Kitap Alış: " + alindigiTarih.ToShortDateString() + "\n" +
                        "Son Teslim: " + alindigiTarih.AddDays(14).ToShortDateString()
                    );

                    IslemleriListele();
                    GridDuzelt();
                }
                else
                {
                    MessageBox.Show("Ödünç verme işlemi başarısız (stok yok / kara liste / hata).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnTeslimAl_Click(object? sender, EventArgs e)
        {
            if (dgvIslemler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen listeden en az 1 işlem seçin.");
                return;
            }

            if (MessageBox.Show(
                $"Seçili {dgvIslemler.SelectedRows.Count} işlem teslim alındı olarak işaretlenecek. Onaylıyor musunuz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in dgvIslemler.SelectedRows)
            {
                int islemId = Convert.ToInt32(row.Cells["id"].Value);
                int kitapId = Convert.ToInt32(row.Cells["kitapId"].Value);

                bll.TeslimAl(islemId, kitapId);
            }

            MessageBox.Show("Seçili işlemler teslim alındı.");
            IslemleriListele();
            GridDuzelt();
        }
    }
}
