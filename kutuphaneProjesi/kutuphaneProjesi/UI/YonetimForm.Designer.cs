namespace kutuphaneProjesi.UI
{
    partial class YonetimForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelIcerik = new Panel();
            panelContent = new Panel();
            panelMenu = new Panel();
            button1 = new Button();
            btnUyeler = new Button();
            btnKitaplar = new Button();
            btnIslemler = new Button();
            btnIstatistik = new Button();
            panelIcerik.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelIcerik
            // 
            panelIcerik.Controls.Add(panelContent);
            panelIcerik.Controls.Add(panelMenu);
            panelIcerik.Dock = DockStyle.Fill;
            panelIcerik.Location = new Point(0, 0);
            panelIcerik.Name = "panelIcerik";
            panelIcerik.Size = new Size(1382, 653);
            panelIcerik.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(188, 189, 203);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(150, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1232, 653);
            panelContent.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(88, 98, 135);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnUyeler);
            panelMenu.Controls.Add(btnKitaplar);
            panelMenu.Controls.Add(btnIslemler);
            panelMenu.Controls.Add(btnIstatistik);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(150, 653);
            panelMenu.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(20, 241);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 1;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUyeler
            // 
            btnUyeler.BackColor = SystemColors.ControlLight;
            btnUyeler.Location = new Point(20, 50);
            btnUyeler.Name = "btnUyeler";
            btnUyeler.Size = new Size(110, 35);
            btnUyeler.TabIndex = 0;
            btnUyeler.Text = "Üyeler";
            btnUyeler.UseVisualStyleBackColor = false;
            btnUyeler.Click += btnUyeler_Click;
            // 
            // btnKitaplar
            // 
            btnKitaplar.BackColor = SystemColors.ControlLight;
            btnKitaplar.Location = new Point(20, 100);
            btnKitaplar.Name = "btnKitaplar";
            btnKitaplar.Size = new Size(110, 35);
            btnKitaplar.TabIndex = 1;
            btnKitaplar.Text = "Kitaplar";
            btnKitaplar.UseVisualStyleBackColor = false;
            btnKitaplar.Click += btnKitaplar_Click;
            // 
            // btnIslemler
            // 
            btnIslemler.BackColor = SystemColors.ControlLight;
            btnIslemler.Location = new Point(20, 150);
            btnIslemler.Name = "btnIslemler";
            btnIslemler.Size = new Size(110, 35);
            btnIslemler.TabIndex = 2;
            btnIslemler.Text = "İşlemler";
            btnIslemler.UseVisualStyleBackColor = false;
            btnIslemler.Click += btnIslemler_Click;
            // 
            // btnIstatistik
            // 
            btnIstatistik.BackColor = SystemColors.ControlLight;
            btnIstatistik.Location = new Point(20, 200);
            btnIstatistik.Name = "btnIstatistik";
            btnIstatistik.Size = new Size(110, 35);
            btnIstatistik.TabIndex = 3;
            btnIstatistik.Text = "İstatistik";
            btnIstatistik.UseVisualStyleBackColor = false;
            btnIstatistik.Click += btnIstatistik_Click;
            // 
            // YonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 653);
            Controls.Add(panelIcerik);
            Name = "YonetimForm";
            Text = "Yönetim Paneli";
            panelIcerik.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIcerik;
        private Panel panelMenu;
        private Panel panelContent;
        private Button btnUyeler;
        private Button btnKitaplar;
        private Button btnIslemler;
        private Button btnIstatistik;
        private Button button1;
    }
}
