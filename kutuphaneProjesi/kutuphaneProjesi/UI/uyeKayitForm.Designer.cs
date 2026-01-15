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
            lblTc.Location = new Point(258, 65);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(21, 20);
            lblTc.TabIndex = 0;
            lblTc.Text = "tc";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(258, 120);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(69, 20);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "ad soyad";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(258, 197);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(37, 20);
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
            txtSifre.Location = new Point(361, 190);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 5;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(361, 253);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(120, 27);
            txtSifreTekrar.TabIndex = 6;
            // 
            // lblSifreTekrar
            // 
            lblSifreTekrar.AutoSize = true;
            lblSifreTekrar.Location = new Point(258, 260);
            lblSifreTekrar.Name = "lblSifreTekrar";
            lblSifreTekrar.Size = new Size(89, 20);
            lblSifreTekrar.TabIndex = 7;
            lblSifreTekrar.Text = "şifre (tekrar)";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(128, 255, 128);
            btnKaydet.Location = new Point(305, 335);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "üye ol ";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // uyeKayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
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