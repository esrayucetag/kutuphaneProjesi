using kutuphaneProjesi.BLL;
using kutuphaneProjesi.DAL;
using System;
using System.Data;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace kutuphaneProjesi.UI
{
    public partial class islemlerForm : Form
    {
        islemlerBLL bll = new islemlerBLL();
        kitaplarBLL kBll = new kitaplarBLL();
        int secilenUyeId = 0;

        public islemlerForm()
        {
            InitializeComponent();
        }

        private void islemlerForm_Load(object sender, EventArgs e)
        {
            KitaplariYukle();
            IslemleriListele();
        }

        void KitaplariYukle()
        {
            DataTable dt = kBll.KitaplariGetir();
            dt.Columns.Add("Display", typeof(string), "id + ' - ' + kitapAd");
            cmbKitap.DataSource = dt;
            cmbKitap.DisplayMember = "Display";
            cmbKitap.ValueMember = "id";
        }

        void IslemleriListele()
        {
            dgvIslemler.DataSource = bll.IslemleriListele();
        }

        private void txtUyeTC_TextChanged(object sender, EventArgs e)
        {
 
            if (txtUyeTc.Text.Length == 11)
            {
                BLL.islemlerBLL bll = new BLL.islemlerBLL();
                DataTable dt = bll.UyeBul(txtUyeTc.Text);

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
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (dgvIslemler.SelectedRows.Count > 0)
            {
                int islemId = Convert.ToInt32(dgvIslemler.CurrentRow.Cells["id"].Value);
                int kitapId = Convert.ToInt32(dgvIslemler.CurrentRow.Cells["kitapId"].Value);
                bll.TeslimAl(islemId, kitapId);
                MessageBox.Show("Kitap geri alındı.");
                IslemleriListele();
            }
        }

        private void btnOduncVer_Click_1(object sender, EventArgs e)
        {
            try
            {
                int uId = Convert.ToInt32(label2.Text);
                int kId = Convert.ToInt32(cmbKitap.SelectedValue);

                DateTime alindigiTarih = dtpVerilisTarihi.Value; 

                BLL.islemlerBLL bll = new BLL.islemlerBLL();
                if (bll.OduncVer(uId, kId, alindigiTarih))
                {
                    MessageBox.Show("İşlem Başarılı! \nKitap Alış: " + alindigiTarih.ToShortDateString() +
                                    "\nSon Teslim: " + alindigiTarih.AddDays(15).ToShortDateString());
                }
            }
            catch
            {
                MessageBox.Show("Lütfen üye ve kitap seçimini kontrol edin.");
            }
        }
        private void islemlerForm_Load_1(object sender, EventArgs e)
        {
            BLL.islemlerBLL bll = new BLL.islemlerBLL();
            dgvIslemler.DataSource = bll.IslemleriListele();
            cmbKitap.DataSource = bll.KitaplariListele();
            cmbKitap.DisplayMember = "kitapAd";
            cmbKitap.ValueMember = "id";
        }

   
    }
}