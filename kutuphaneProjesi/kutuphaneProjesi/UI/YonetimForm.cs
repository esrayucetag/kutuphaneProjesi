using System;
using System.Drawing;
using System.Windows.Forms;

namespace kutuphaneProjesi.UI
{
    public partial class YonetimForm : Form
    {
        public YonetimForm()
        {
            InitializeComponent();
        }

        // Menüde aktif butonu vurgular
        private void AktifButon(Button aktif)
        {
            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.Gainsboro;
                    btn.Font = new Font(btn.Font, FontStyle.Regular);
                }
            }

            aktif.BackColor = Color.LightSteelBlue;
            aktif.Font = new Font(aktif.Font, FontStyle.Bold);
        }

        // Sağ tarafa form yükler
        private void FormGetir(Form frm)
        {
            panelContent.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void btnUyeler_Click(object sender, EventArgs e)
        {
            AktifButon(btnUyeler);
            FormGetir(new UyelerForm());
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            AktifButon(btnKitaplar);
            FormGetir(new kitaplarForm());
        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {
            AktifButon(btnIslemler);
            FormGetir(new islemlerForm());
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            AktifButon(btnIstatistik);
            FormGetir(new istatistikForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
