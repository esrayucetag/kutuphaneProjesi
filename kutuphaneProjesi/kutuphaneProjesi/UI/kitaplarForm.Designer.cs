namespace kutuphaneProjesi.UI
{
    partial class kitaplarForm
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
            btnYeniKitapEkle = new Button();
            dgvKitaplar = new DataGridView();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            SuspendLayout();
            // 
            // btnYeniKitapEkle
            // 
            btnYeniKitapEkle.BackColor = Color.FromArgb(128, 255, 128);
            btnYeniKitapEkle.Location = new Point(653, 361);
            btnYeniKitapEkle.Name = "btnYeniKitapEkle";
            btnYeniKitapEkle.Size = new Size(109, 52);
            btnYeniKitapEkle.TabIndex = 0;
            btnYeniKitapEkle.Text = "YeniKitapEkle";
            btnYeniKitapEkle.UseVisualStyleBackColor = false;
            btnYeniKitapEkle.Click += btnYeniKitapEkle_Click;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(31, 38);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.Size = new Size(731, 303);
            dgvKitaplar.TabIndex = 1;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Location = new Point(72, 371);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 2;
            btnSil.Text = "sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // kitaplarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSil);
            Controls.Add(dgvKitaplar);
            Controls.Add(btnYeniKitapEkle);
            Name = "kitaplarForm";
            Text = "kitaplarForm";
            Load += kitaplarForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnYeniKitapEkle;
        private DataGridView dgvKitaplar;
        private Button btnSil;
    }
}