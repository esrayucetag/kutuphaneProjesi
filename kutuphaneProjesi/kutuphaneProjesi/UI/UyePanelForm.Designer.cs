namespace kutuphaneProjesi.UI
{
    partial class UyePanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvIslemler = new DataGridView();
            lblHosgeldin = new Label();
            panelToplamOkunan = new Panel();
            lblToplamOkunanDeger = new Label();
            lblToplamOkunanBaslik = new Label();
            btnGeri = new Button();
            pnlKartAktif = new Panel();
            lblUzerindekiDeger = new Label();
            lblUzerindekiBaslik = new Label();
            pnlKartToplam = new Panel();
            lblGecikenDeger = new Label();
            lblGecikenBaslik = new Label();
            pnlKartGeciken = new Panel();
            lblDurumDeger = new Label();
            lblDurumBaslik = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIslemler).BeginInit();
            panelToplamOkunan.SuspendLayout();
            pnlKartAktif.SuspendLayout();
            pnlKartToplam.SuspendLayout();
            pnlKartGeciken.SuspendLayout();
            SuspendLayout();
            // 
            // dgvIslemler
            // 
            dgvIslemler.AllowUserToAddRows = false;
            dgvIslemler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIslemler.BackgroundColor = Color.AliceBlue;
            dgvIslemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIslemler.GridColor = SystemColors.HotTrack;
            dgvIslemler.Location = new Point(50, 216);
            dgvIslemler.Name = "dgvIslemler";
            dgvIslemler.ReadOnly = true;
            dgvIslemler.RowHeadersVisible = false;
            dgvIslemler.RowHeadersWidth = 51;
            dgvIslemler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIslemler.Size = new Size(910, 280);
            dgvIslemler.TabIndex = 0;
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.AutoSize = true;
            lblHosgeldin.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblHosgeldin.Location = new Point(106, 13);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new Size(22, 25);
            lblHosgeldin.TabIndex = 1;
            lblHosgeldin.Text = "0";
            // 
            // panelToplamOkunan
            // 
            panelToplamOkunan.BackColor = Color.FromArgb(192, 255, 192);
            panelToplamOkunan.Controls.Add(lblToplamOkunanDeger);
            panelToplamOkunan.Controls.Add(lblToplamOkunanBaslik);
            panelToplamOkunan.Location = new Point(761, 51);
            panelToplamOkunan.Name = "panelToplamOkunan";
            panelToplamOkunan.Size = new Size(199, 122);
            panelToplamOkunan.TabIndex = 2;
            // 
            // lblToplamOkunanDeger
            // 
            lblToplamOkunanDeger.AutoSize = true;
            lblToplamOkunanDeger.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamOkunanDeger.Location = new Point(42, 61);
            lblToplamOkunanDeger.Name = "lblToplamOkunanDeger";
            lblToplamOkunanDeger.Size = new Size(96, 38);
            lblToplamOkunanDeger.TabIndex = 1;
            lblToplamOkunanDeger.Text = "label1";
            // 
            // lblToplamOkunanBaslik
            // 
            lblToplamOkunanBaslik.AutoSize = true;
            lblToplamOkunanBaslik.Location = new Point(17, 13);
            lblToplamOkunanBaslik.Name = "lblToplamOkunanBaslik";
            lblToplamOkunanBaslik.Size = new Size(169, 20);
            lblToplamOkunanBaslik.TabIndex = 0;
            lblToplamOkunanBaslik.Text = "toplam okuduğum kitap";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = SystemColors.ButtonFace;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeri.ForeColor = Color.FromArgb(192, 0, 0);
            btnGeri.Location = new Point(1, 4);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(50, 29);
            btnGeri.TabIndex = 3;
            btnGeri.Text = "geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // pnlKartAktif
            // 
            pnlKartAktif.BackColor = Color.FromArgb(255, 192, 192);
            pnlKartAktif.Controls.Add(lblUzerindekiDeger);
            pnlKartAktif.Controls.Add(lblUzerindekiBaslik);
            pnlKartAktif.Location = new Point(50, 51);
            pnlKartAktif.Name = "pnlKartAktif";
            pnlKartAktif.Size = new Size(193, 124);
            pnlKartAktif.TabIndex = 4;
            // 
            // lblUzerindekiDeger
            // 
            lblUzerindekiDeger.AutoSize = true;
            lblUzerindekiDeger.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUzerindekiDeger.Location = new Point(38, 61);
            lblUzerindekiDeger.Name = "lblUzerindekiDeger";
            lblUzerindekiDeger.Size = new Size(104, 41);
            lblUzerindekiDeger.TabIndex = 7;
            lblUzerindekiDeger.Text = "label1";
            // 
            // lblUzerindekiBaslik
            // 
            lblUzerindekiBaslik.AutoSize = true;
            lblUzerindekiBaslik.Location = new Point(38, 13);
            lblUzerindekiBaslik.Name = "lblUzerindekiBaslik";
            lblUzerindekiBaslik.Size = new Size(118, 20);
            lblUzerindekiBaslik.TabIndex = 6;
            lblUzerindekiBaslik.Text = "Üzerindeki Kitap";
            // 
            // pnlKartToplam
            // 
            pnlKartToplam.BackColor = Color.FromArgb(255, 224, 192);
            pnlKartToplam.Controls.Add(lblGecikenDeger);
            pnlKartToplam.Controls.Add(lblGecikenBaslik);
            pnlKartToplam.Location = new Point(282, 49);
            pnlKartToplam.Name = "pnlKartToplam";
            pnlKartToplam.Size = new Size(193, 124);
            pnlKartToplam.TabIndex = 0;
            // 
            // lblGecikenDeger
            // 
            lblGecikenDeger.AutoSize = true;
            lblGecikenDeger.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGecikenDeger.Location = new Point(42, 63);
            lblGecikenDeger.Name = "lblGecikenDeger";
            lblGecikenDeger.Size = new Size(104, 41);
            lblGecikenDeger.TabIndex = 1;
            lblGecikenDeger.Text = "label1";
            // 
            // lblGecikenBaslik
            // 
            lblGecikenBaslik.AutoSize = true;
            lblGecikenBaslik.Location = new Point(49, 15);
            lblGecikenBaslik.Name = "lblGecikenBaslik";
            lblGecikenBaslik.Size = new Size(97, 20);
            lblGecikenBaslik.TabIndex = 0;
            lblGecikenBaslik.Text = "geciken kitap";
            // 
            // pnlKartGeciken
            // 
            pnlKartGeciken.BackColor = Color.FromArgb(255, 255, 192);
            pnlKartGeciken.Controls.Add(lblDurumDeger);
            pnlKartGeciken.Controls.Add(lblDurumBaslik);
            pnlKartGeciken.Location = new Point(516, 49);
            pnlKartGeciken.Name = "pnlKartGeciken";
            pnlKartGeciken.Size = new Size(193, 124);
            pnlKartGeciken.TabIndex = 5;
            // 
            // lblDurumDeger
            // 
            lblDurumDeger.AutoSize = true;
            lblDurumDeger.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurumDeger.Location = new Point(47, 63);
            lblDurumDeger.Name = "lblDurumDeger";
            lblDurumDeger.Size = new Size(104, 41);
            lblDurumDeger.TabIndex = 1;
            lblDurumDeger.Text = "label1";
            // 
            // lblDurumBaslik
            // 
            lblDurumBaslik.AutoSize = true;
            lblDurumBaslik.Location = new Point(61, 15);
            lblDurumBaslik.Name = "lblDurumBaslik";
            lblDurumBaslik.Size = new Size(52, 20);
            lblDurumBaslik.TabIndex = 0;
            lblDurumBaslik.Text = "durum";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(50, 190);
            label1.Name = "label1";
            label1.Size = new Size(307, 23);
            label1.TabIndex = 6;
            label1.Text = "OKUDUKLARIM - ÖDÜNÇ ALDIKLARIM";
            // 
            // UyePanelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 189, 203);
            ClientSize = new Size(1045, 625);
            Controls.Add(label1);
            Controls.Add(panelToplamOkunan);
            Controls.Add(pnlKartGeciken);
            Controls.Add(pnlKartToplam);
            Controls.Add(pnlKartAktif);
            Controls.Add(btnGeri);
            Controls.Add(lblHosgeldin);
            Controls.Add(dgvIslemler);
            Name = "UyePanelForm";
            Text = "UyePanelForm";
            Load += UyePanelForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIslemler).EndInit();
            panelToplamOkunan.ResumeLayout(false);
            panelToplamOkunan.PerformLayout();
            pnlKartAktif.ResumeLayout(false);
            pnlKartAktif.PerformLayout();
            pnlKartToplam.ResumeLayout(false);
            pnlKartToplam.PerformLayout();
            pnlKartGeciken.ResumeLayout(false);
            pnlKartGeciken.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvIslemler;
        private Label lblHosgeldin;
        private Label lblToplamOkunanBaslik;
        private Button btnGeri;
        private Panel pnlKartAktif;
        private Panel pnlKartToplam;
        private Panel pnlKartGeciken;
        private Label lblUzerindekiBaslik;
        private Label lblUzerindekiDeger;
        private Label lblGecikenDeger;
        private Label lblGecikenBaslik;
        private Label lblDurumDeger;
        private Label lblDurumBaslik;
        private Panel panelToplamOkunan;
        private Label lblToplamOkunanDeger;
        private Label label1;
    }
}