using kutuphaneProjesi.BLL; // BLL katmanına erişim sağlar
using System;
using System.Windows.Forms;
using kutuphaneProjesi.DAL;

namespace kutuphaneProjesi.UI
{
    public partial class kitapEkleForm : Form
    {
        // Hata listesindeki 'bll bulunamadı' sorununu çözen tanımlama
        kitaplarBLL bll = new kitaplarBLL();

        public kitapEkleForm()
        {
            InitializeComponent();
        }

      

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvTopluEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string kopyalananMetin = Clipboard.GetText().Replace("\r", ""); // Gizli karakterleri temizle
                string[] satirlar = kopyalananMetin.Split('\n');

                foreach (string satir in satirlar)
                {
                    if (string.IsNullOrWhiteSpace(satir)) continue;
                    string[] hucreler = satir.Split('\t'); // Excel formatı

                    // Sütunlar eklendiği için artık bu satır hata vermeyecek
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
                    // Sizin tablo yapınıza (kitapAd, yazar, adet, kitapTuru) göre gönderiyoruz
                    // ToString() metodundan sonra ?? "" ekleyerek "boşsa boş metin kabul et" diyoruz
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

        private void kitapEkleForm_Load(object sender, EventArgs e)
        {

        }
    }


}