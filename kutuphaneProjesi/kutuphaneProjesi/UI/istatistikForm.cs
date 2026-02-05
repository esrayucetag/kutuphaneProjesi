using kutuphaneProjesi.DAL;
using Mysqlx.Crud;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace kutuphaneProjesi.UI
{
    public partial class istatistikForm : Form
    {
        private const int GUN_LIMIT = 14; // sabit 14 gün

        public istatistikForm()
        {
            InitializeComponent();
           
        }

        private void istatistikForm_Load(object sender, EventArgs e)
        {
            ChartlariSifirla();   // ✅ EN ÖNEMLİ SATIR

            StilUygula();
            VerileriGuncelle();

            GrafikDoldurAylik();
            PastaGecikmeGrafik();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstatistikler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        // ----------------- STİL -----------------
        private void StilUygula()
        {
            HazirKutu(txtToplamKitap);
            HazirKutu(txtToplamUye);
            HazirKutu(txtOduncKitap);

            StilGrid(dgvEnCokOkuyanlar);
            StilGrid(dgvIstatistik);

            if (chartRapor != null) chartRapor.BackColor = Color.White;
            if (chartPasta != null) chartPasta.BackColor = Color.White;
        }
        private void ChartlariSifirla()
        {
            // chartRapor
            chartRapor.Series.Clear();
            chartRapor.ChartAreas.Clear();
            chartRapor.Titles.Clear();
            chartRapor.Legends.Clear();

            // chartPasta
            chartPasta.Series.Clear();
            chartPasta.ChartAreas.Clear();
            chartPasta.Titles.Clear();
            chartPasta.Legends.Clear();

            // Force redraw
            chartRapor.Invalidate();
            chartPasta.Invalidate();
        }

        private void HazirKutu(TextBox txt)
        {
            txt.ReadOnly = true;
            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = Color.White;
            txt.TextAlign = HorizontalAlignment.Center;
            txt.Font = new Font("Segoe UI", 18, FontStyle.Bold);
        }

        private void StilGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;
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

        // ----------------- CHART 1: SON 6 AY SÜTUN -----------------
        private void GrafikDoldurAylik()
        {
            chartRapor.Series.Clear();
            chartRapor.ChartAreas.Clear();
            chartRapor.Legends.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Interval = 1;
            chartRapor.ChartAreas.Add(area);

            chartRapor.Legends.Add(new Legend("Legend1"));

            var dt = new istatistikDAL().AylikOduncIstatistik();

            Series s = new Series("Ödünç");
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;
            s.ChartArea = "MainArea";
            s.Legend = "Legend1";

            // ⭐⭐⭐ KRİTİK SATIR
            s.IsXValueIndexed = true;

            foreach (DataRow row in dt.Rows)
            {
                string ay = row["AyEtiket"].ToString();
                int sayi = Convert.ToInt32(row["OduncSayisi"]);

                s.Points.AddXY(ay, sayi);
            }

            chartRapor.Series.Add(s);
        }


        private void PastaGecikmeGrafik()
        {
            try
            {
                istatistikDAL dal = new istatistikDAL();
                int[] arr = dal.OduncGecikmeOrani();

                int oduncToplam = arr[0];
                int geciken = arr[1];
                int zamaninda = Math.Max(0, oduncToplam - geciken);

                chartPasta.Series.Clear();
                chartPasta.ChartAreas.Clear();
                chartPasta.Titles.Clear();
                chartPasta.Legends.Clear();

                chartPasta.ChartAreas.Add(new ChartArea("A"));
                chartPasta.Titles.Add($"Ödünçtekilerin Gecikme Oranı (>{GUN_LIMIT} gün)");

                Legend legend = new Legend("Legend1");
                legend.Docking = Docking.Right;
                legend.Alignment = StringAlignment.Center;
                chartPasta.Legends.Add(legend);

                Series s = new Series("Gecikme");
                s.ChartType = SeriesChartType.Pie;
                s.IsValueShownAsLabel = true;
                s.Label = "#PERCENT{P0}";
                s.LegendText = "#VALX (#VAL)";
                s.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                if (oduncToplam == 0)
                {
                    s.Points.AddXY("Ödünçte yok", 1);
                }
                else
                {
                    s.Points.AddXY("Geciken", geciken);
                    s.Points.AddXY("Zamanında", zamaninda);
                }

                chartPasta.Series.Add(s);
                chartPasta.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pasta grafik hatası: " + ex.Message);
            }
        }

        private void btnRaporGeciken_Click(object sender, EventArgs e)
        {
            if (lblRaporBaslik != null) lblRaporBaslik.Text = "GEÇİKEN KİTAPLAR";

            BLL.islemlerBLL bll = new BLL.islemlerBLL();
            dgvIstatistik.DataSource = bll.RaporGecikenler();
        }

        private void btnRaporPopuler_Click(object sender, EventArgs e)
        {
            if (lblRaporBaslik != null) lblRaporBaslik.Text = "EN ÇOK OKUNAN KİTAPLAR";

            BLL.islemlerBLL bll = new BLL.islemlerBLL();
            dgvIstatistik.DataSource = bll.RaporPopulerKitaplar();
        }
    }
}
