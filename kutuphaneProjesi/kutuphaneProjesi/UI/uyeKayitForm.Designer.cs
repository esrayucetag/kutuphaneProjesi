namespace kutuphaneProjesi.UI
{
    partial class uyeKayitForm
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
            lblTc = new Label();
            lblAdSoyad = new Label();
            lblSifre = new Label();
            txtTc = new TextBox();
            txtAdSoyad = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            lblSifreTekrar = new Label();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTc.ForeColor = Color.MidnightBlue;
            lblTc.Location = new Point(314, 64);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(28, 25);
            lblTc.TabIndex = 0;
            lblTc.Text = "tc";
            lblTc.Click += lblTc_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblAdSoyad.ForeColor = Color.MidnightBlue;
            lblAdSoyad.Location = new Point(254, 119);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(88, 25);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "ad soyad";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblSifre.ForeColor = Color.MidnightBlue;
            lblSifre.Location = new Point(293, 181);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(49, 25);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "şifre";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(361, 65);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(125, 27);
            txtTc.TabIndex = 3;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(361, 120);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(361, 182);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 5;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(361, 245);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(125, 27);
            txtSifreTekrar.TabIndex = 6;
            // 
            // lblSifreTekrar
            // 
            lblSifreTekrar.AutoSize = true;
            lblSifreTekrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblSifreTekrar.ForeColor = Color.MidnightBlue;
            lblSifreTekrar.Location = new Point(223, 244);
            lblSifreTekrar.Name = "lblSifreTekrar";
            lblSifreTekrar.Size = new Size(119, 25);
            lblSifreTekrar.TabIndex = 7;
            lblSifreTekrar.Text = "şifre (tekrar)";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ButtonFace;
            btnKaydet.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = SystemColors.HotTrack;
            btnKaydet.Location = new Point(314, 317);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(98, 36);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "ÜYE OL";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // uyeKayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 189, 203);
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(lblSifreTekrar);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTc);
            Controls.Add(lblSifre);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblTc);
            Name = "uyeKayitForm";
            Text = "uyeKayitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTc;
        private Label lblAdSoyad;
        private Label lblSifre;
        private TextBox txtTc;
        private TextBox txtAdSoyad;
        private TextBox txtSifre;
        private TextBox txtSifreTekrar;
        private Label lblSifreTekrar;
        private Button btnKaydet;
    }
}