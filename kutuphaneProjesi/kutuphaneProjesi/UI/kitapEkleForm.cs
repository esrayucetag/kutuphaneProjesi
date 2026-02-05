using kutuphaneProjesi.BLL; // BLL katmanına erişim sağlar
using System;
using System.Drawing;
using System.Windows.Forms;
using kutuphaneProjesi.DAL;

namespace kutuphaneProjesi.UI
{
    public partial class kitapEkleForm : Form
    {
        kitaplarBLL bll = new kitaplarBLL();

        // Tema
        private readonly Color temaRenk = Color.FromArgb(188, 189, 203);
        private readonly Color maviButon = Color.FromArgb(59, 130, 246);

        public kitapEkleForm()
        {
            InitializeComponent();
        }

        private void kitapEkleForm_Load(object sender, EventArgs e)
        {
            FormStilUygula();
            GridStilUygula();
        }

        // ====== GÖRSEL STİL ======
        private void FormStilUygula()
        {
            this.BackColor = temaRenk;

            // Geri butonu: bağırmasın ama hover olsun
            StilButon(btnGeri, temaRenk, Color.FromArgb(30, 41, 59), kenarlikVar: true);

            // Kaydet butonu: mavi, hover koyulaşsın
            StilButon(btnTopluKaydet, maviButon, Color.White, kenarlikVar: false);

            // İstersen label'ı da elle ayarlarsın:
            // (Designer'da label adını bilmediğim için buraya otomatik yazmadım)
            // label: AutoSize = false; Size geniş; Font Segoe UI 9/10; ForeColor koyu;
        }

        private void StilButon(Button btn, Color normalBack, Color fore, bool kenarlikVar)
        {
            btn.BackColor = normalBack;
            btn.ForeColor = fore;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = kenarlikVar ? 1 : 0;
            btn.FlatAppearance.BorderColor = Color.FromArgb(120, 120, 120);

            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Hover efekti (sadece renk değişsin)
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = ControlPaint.Dark(normalBack);
            };
            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = normalBack;
            };
        }

        private void GridStilUygula()
        {
            dgvTopluEkle.BackgroundColor = Color.White;
            dgvTopluEkle.BorderStyle = BorderStyle.FixedSingle;

            dgvTopluEkle.AllowUserToAddRows = true;
            dgvTopluEkle.AllowUserToDeleteRows = true;
            dgvTopluEkle.AllowUserToResizeRows = false;

            dgvTopluEkle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopluEkle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTopluEkle.MultiSelect = false;

            dgvTopluEkle.EnableHeadersVisualStyles = false;
            dgvTopluEkle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvTopluEkle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTopluEkle.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTopluEkle.ColumnHeadersHeight = 36;

            dgvTopluEkle.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvTopluEkle.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvTopluEkle.GridColor = Color.Gainsboro;
            dgvTopluEkle.RowTemplate.Height = 30;
        }

        // ====== MEVCUT İŞLEVLER (DOKUNMADIM) ======
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTopluEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string kopyalananMetin = Clipboard.GetText().Replace("\r", "");
                string[] satirlar = kopyalananMetin.Split('\n');

                foreach (string satir in satirlar)
                {
                    if (string.IsNullOrWhiteSpace(satir)) continue;
                    string[] hucreler = satir.Split('\t');

                    dgvTopluEkle.Rows.Add(hucreler);
                }
            }
        }

        private void btnTopluKaydet_Click(object sender, EventArgs e)
        {
            kitaplarDAL dal = new kitaplarDAL();
            foreach (DataGridViewRow row in dgvTopluEkle.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    dal.KitapEkle(
                        row.Cells[0].Value?.ToString() ?? "",
                        row.Cells[1].Value?.ToString() ?? "",
                        Convert.ToInt32(row.Cells[2].Value ?? 0),
                        row.Cells[3].Value?.ToString() ?? ""
                    );
                }
            }
            MessageBox.Show("Tüm liste başarıyla kaydedildi!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
