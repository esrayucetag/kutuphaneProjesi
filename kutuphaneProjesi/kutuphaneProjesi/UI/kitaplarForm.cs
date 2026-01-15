using System;
using System.Windows.Forms;
using kutuphaneProjesi.BLL; // BLL katmanına erişim sağlar

namespace kutuphaneProjesi.UI
{
    public partial class kitaplarForm : Form
    {
        // Kontrol mekanizmamızı çağırıyoruz
        kitaplarBLL bll = new kitaplarBLL();

        public kitaplarForm()
        {
            InitializeComponent();
        }

        // Tabloyu (DataGridView) güncellemek için kullandığımız metod
        public void Listele()
        {
            // dgvKitaplar isminin tasarımda tanımlı olduğundan emin olun
            dgvKitaplar.DataSource = bll.KitaplariGetir();
        }

        private void kitaplarForm_Load(object sender, EventArgs e)
        {
            Listele(); // Sayfa ilk açıldığında verileri doldurur
        }

        private void btnYeniKitapEkle_Click(object sender, EventArgs e)
        {
            // Yeni kitap ekleme penceresini açar
            kitapEkleForm frm = new kitapEkleForm();
            frm.ShowDialog(); // Arkadaki sayfayı kilitler
            Listele(); // Ekleme bittikten sonra listeyi otomatik tazeler
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Tablodan bir satır seçili mi kontrol eder
            if (dgvKitaplar.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells["id"].Value);
                int mevcutAdet = Convert.ToInt32(dgvKitaplar.CurrentRow.Cells["adet"].Value);

                // Adet durumuna göre kullanıcıyı bilgilendirir
                string mesaj = mevcutAdet > 1
                    ? "Kitap adedi 1 azaltılacak. Onaylıyor musunuz?"
                    : "Bu son kitap, kayıt tamamen silinecek. Onaylıyor musunuz?";

                if (MessageBox.Show(mesaj, "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // BLL üzerinden adet düşürme veya silme işlemini tetikler
                    bll.KitapEksilt(id, mevcutAdet);
                    Listele(); // Listeyi günceller
                }
            }
            else
            {
                MessageBox.Show("Lütfen işlem yapmak için tablodan bir satır seçin.");
            }
        }

        private void kitaplarForm_Load_1(object sender, EventArgs e)
        {
            BLL.islemlerBLL bll = new BLL.islemlerBLL();
            dgvKitaplar.DataSource = bll.KitaplariListele(); // Sadece BLL çağrısı
        }
        
        public void KitaplariListele()
        {
            try
            {
                BLL.islemlerBLL bll = new BLL.islemlerBLL();
                dgvKitaplar.DataSource = bll.KitaplariListele();

                dgvKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar yüklenirken hata: " + ex.Message);
            }
        }

    }
}