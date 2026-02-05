using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using kutuphaneProjesi.BLL;

namespace kutuphaneProjesi.UI
{
    public partial class UyePanelForm : Form
    {
        private readonly UyePanelBLL bll = new UyePanelBLL();
        private readonly int aktifUyeId;
        private readonly string aktifAdSoyad;

        public UyePanelForm(int uyeId, string adSoyad)
        {
            InitializeComponent();
            aktifUyeId = uyeId;
            aktifAdSoyad = adSoyad;
        }

        private void UyePanelForm_Load(object sender, EventArgs e)
        {
            // hoşgeldin
            if (lblHosgeldin != null)
                lblHosgeldin.Text = $"Hoşgeldin, {aktifAdSoyad}";

            GridStil();
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            // Grid
            DataTable dt = bll.UyeninTumIslemleri(aktifUyeId);
            dgvIslemler.DataSource = dt;

            // Kartlar
            var kart = bll.KartBilgileri(aktifUyeId);

            lblUzerindekiDeger.Text = kart.uzerindeki.ToString();
            lblGecikenDeger.Text = kart.geciken.ToString();
            lblToplamOkunanDeger.Text = kart.toplamOkunan.ToString();

            if (kart.karaListe == 1)
            {
                lblDurumDeger.Text = "KARA LİSTE";
                lblDurumDeger.ForeColor = Color.DarkRed;
            }
            else
            {
                lblDurumDeger.Text = "TEMİZ";
                lblDurumDeger.ForeColor = Color.DarkGreen;
            }

            // Durum kolonu 1/0 görünsün istemiyorsan gizle:
            if (dgvIslemler.Columns.Contains("Durum"))
                dgvIslemler.Columns["Durum"].Visible = false;

            // başlıklar net olsun
            if (dgvIslemler.Columns.Contains("KitapAdi")) dgvIslemler.Columns["KitapAdi"].HeaderText = "Kitap Adı";
            if (dgvIslemler.Columns.Contains("AlisTarihi")) dgvIslemler.Columns["AlisTarihi"].HeaderText = "Alış Tarihi";
            if (dgvIslemler.Columns.Contains("SonTeslim")) dgvIslemler.Columns["SonTeslim"].HeaderText = "Son Teslim";
        }

        private void GridStil()
        {
            dgvIslemler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIslemler.ReadOnly = true;
            dgvIslemler.AllowUserToAddRows = false;
            dgvIslemler.AllowUserToDeleteRows = false;
            dgvIslemler.AllowUserToResizeRows = false;
            dgvIslemler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIslemler.MultiSelect = false;
            dgvIslemler.RowHeadersVisible = false;

            dgvIslemler.BackgroundColor = Color.White;
            dgvIslemler.BorderStyle = BorderStyle.None;
            dgvIslemler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvIslemler.GridColor = Color.Gainsboro;

            dgvIslemler.EnableHeadersVisualStyles = false;
            dgvIslemler.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvIslemler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvIslemler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvIslemler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvIslemler.ColumnHeadersHeight = 38;

            dgvIslemler.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvIslemler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dgvIslemler.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvIslemler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvIslemler.RowTemplate.Height = 32;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
