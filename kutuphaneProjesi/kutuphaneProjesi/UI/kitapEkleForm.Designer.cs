namespace kutuphaneProjesi.UI
{
    partial class kitapEkleForm
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
            label2 = new Label();
            btnGeri = new Button();
            dgvTopluEkle = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colYazar = new DataGridViewTextBoxColumn();
            colAdet = new DataGridViewTextBoxColumn();
            colTur = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnTopluKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTopluEkle).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 188);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Red;
            btnGeri.FlatStyle = FlatStyle.Popup;
            btnGeri.Location = new Point(12, 12);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(49, 31);
            btnGeri.TabIndex = 9;
            btnGeri.Text = "geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // dgvTopluEkle
            // 
            dgvTopluEkle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopluEkle.Columns.AddRange(new DataGridViewColumn[] { colAd, colYazar, colAdet, colTur });
            dgvTopluEkle.Location = new Point(0, 39);
            dgvTopluEkle.Name = "dgvTopluEkle";
            dgvTopluEkle.RowHeadersWidth = 51;
            dgvTopluEkle.Size = new Size(818, 280);
            dgvTopluEkle.TabIndex = 12;
            dgvTopluEkle.KeyDown += dgvTopluEkle_KeyDown;
            // 
            // colAd
            // 
            colAd.HeaderText = "Kitap Adı";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            colAd.Width = 125;
            // 
            // colYazar
            // 
            colYazar.HeaderText = "Yazar";
            colYazar.MinimumWidth = 6;
            colYazar.Name = "colYazar";
            colYazar.Width = 125;
            // 
            // colAdet
            // 
            colAdet.HeaderText = "Adet";
            colAdet.MinimumWidth = 6;
            colAdet.Name = "colAdet";
            colAdet.Width = 125;
            // 
            // colTur
            // 
            colTur.HeaderText = "Kitap Türü";
            colTur.MinimumWidth = 6;
            colTur.Name = "colTur";
            colTur.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvTopluEkle);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(895, 281);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "çoklu kitap eklemek için aşağıdakı kutuya yapıstırınız.";
            // 
            // btnTopluKaydet
            // 
            btnTopluKaydet.Location = new Point(679, 354);
            btnTopluKaydet.Name = "btnTopluKaydet";
            btnTopluKaydet.Size = new Size(168, 67);
            btnTopluKaydet.TabIndex = 13;
            btnTopluKaydet.Text = "LİSTEYİ SİSTEME AKTAR";
            btnTopluKaydet.UseVisualStyleBackColor = true;
            btnTopluKaydet.Click += btnTopluKaydet_Click;
            // 
            // kitapEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(930, 558);
            Controls.Add(btnTopluKaydet);
            Controls.Add(groupBox1);
            Controls.Add(btnGeri);
            Name = "kitapEkleForm";
            Text = "kitapEkleForm";
            Load += kitapEkleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTopluEkle).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button btnGeri;
        private DataGridView dgvTopluEkle;
        private GroupBox groupBox1;
        private Button btnTopluKaydet;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colYazar;
        private DataGridViewTextBoxColumn colAdet;
        private DataGridViewTextBoxColumn colTur;
    }
}