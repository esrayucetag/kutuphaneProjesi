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
            // Çıkış butonu sabit kırmızı
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            // Hover efektleri (menü butonları)
            ButonHover(btnUyeler);
            ButonHover(btnKitaplar);
            ButonHover(btnIslemler);
            ButonHover(btnIstatistik);

            // Çıkış hover (kırmızının tonu biraz değişsin)
            button1.MouseEnter += (s, e) => button1.BackColor = Color.DarkRed;
            button1.MouseLeave += (s, e) => button1.BackColor = Color.Red;

        }
        private void AktifButon(Button aktif)
        {
            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    // Çıkış butonuna dokunma
                    if (btn == button1) continue;

                    btn.BackColor = Color.Gainsboro;
                    btn.ForeColor = Color.Black;
                    btn.Font = new Font(btn.Font, FontStyle.Regular);
                }
            }

            // Aktif buton çıkış değilse vurgula
            if (aktif != button1)
            {
                aktif.BackColor = Color.LightSteelBlue;
                aktif.ForeColor = Color.Black;
                aktif.Font = new Font(aktif.Font, FontStyle.Bold);
            }
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
        private void ButonHover(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.MouseEnter += (s, e) =>
            {
                // aktif butonsa bozulmasın
                if (btn.BackColor != Color.LightSteelBlue)
                    btn.BackColor = Color.LightGray;
            };

            btn.MouseLeave += (s, e) =>
            {
                if (btn.BackColor != Color.LightSteelBlue)
                    btn.BackColor = Color.Gainsboro;
            };
        }

    }
}
