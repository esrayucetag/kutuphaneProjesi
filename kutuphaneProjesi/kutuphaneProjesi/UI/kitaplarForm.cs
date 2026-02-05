using System;
using System.Drawing;
using System.Windows.Forms;
using kutuphaneProjesi.BLL;

namespace kutuphaneProjesi.UI
{
    public partial class kitaplarForm : Form
    {
        private readonly kitaplarBLL bll = new kitaplarBLL();

        public kitaplarForm()
        {
            InitializeComponent();
        }



        private void Listele()
        {
            dgvKitaplar.DataSource = bll.KitaplariGetir();
        }

     
        private void picAra_Click(object sender, EventArgs e)
        {
            string q = txtAra.Text.Trim();
            dgvKitaplar.DataSource = bll.KitapAra(q);
        }

        private void txtAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                picAra_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void picTemizle_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            Listele();
        }

        private void btnYeniKitapEkle_Click(object sender, EventArgs e)
        {
            kitapEkleForm frm = new kitapEkleForm();
            frm.ShowDialog();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen satır seçin.");
                return;
            }

            string giris = Microsoft.VisualBasic.Interaction.InputBox(
                "Kaç adet silinsin?\nTamamen silmek için F veya FULL yazın.",
                "Silme İşlemi",
                "1");

            if (string.IsNullOrWhiteSpace(giris))
                return;

            foreach (DataGridViewRow row in dgvKitaplar.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                int adet = Convert.ToInt32(row.Cells["adet"].Value);

                // FULL silme
                if (giris.ToUpper() == "F" || giris.ToUpper() == "FULL")
                {
                    bll.KitapTamamenSil(id);
                }
                else
                {
                    if (int.TryParse(giris, out int dusulecek))
                    {
                        bll.KitapAdetDusur(id, adet, dusulecek);
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz giriş!");
                        return;
                    }
                }
            }

            MessageBox.Show("İşlem tamamlandı.");
            Listele();
        }

        private void StilGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.Gainsboro;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 38;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 219, 254);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv.RowTemplate.Height = 32;
        }

        private void kitaplarForm_Load(object sender, EventArgs e)
        {

            StilGrid(dgvKitaplar);
            Listele();
        }
    }
}
