using System;
using System.Windows.Forms;
using kutuphaneProjesi.DAL;

namespace kutuphaneProjesi.UI
{
    public partial class istatistikForm : Form
    {
        public istatistikForm()
        {
            InitializeComponent();
        }

        private void istatistikForm_Load(object sender, EventArgs e)
        {
            VerileriGuncelle();
        }

        public void VerileriGuncelle()
        {
            try
            {
                istatistikDAL dal = new istatistikDAL();

                int[] rakamlar = dal.GenelSayilar();
                txtToplamKitap.Text = rakamlar[0].ToString();
                txtToplamUye.Text = rakamlar[1].ToString();
                txtOduncKitap.Text = rakamlar[2].ToString();

                dgvEnCokOkuyanlar.DataSource = dal.EnCokOkuyanlar();

                dgvEnCokOkuyanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstatistikler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnRaporGeciken_Click(object sender, EventArgs e)
        {

            BLL.islemlerBLL bll = new BLL.islemlerBLL();
            dgvIstatistik.DataSource = bll.RaporGecikenler();
            dgvIstatistik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRaporPopuler_Click(object sender, EventArgs e)
        {
            BLL.islemlerBLL bll = new BLL.islemlerBLL();
            dgvIstatistik.DataSource = bll.RaporPopulerKitaplar();
            dgvIstatistik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void panelAltGrafik_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}