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
            picTemizle = new PictureBox();
            picAra = new PictureBox();
            txtAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTemizle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAra).BeginInit();
            SuspendLayout();
            // 
            // btnYeniKitapEkle
            // 
            btnYeniKitapEkle.BackColor = SystemColors.ButtonFace;
            btnYeniKitapEkle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYeniKitapEkle.ForeColor = Color.Teal;
            btnYeniKitapEkle.Location = new Point(683, 407);
            btnYeniKitapEkle.Name = "btnYeniKitapEkle";
            btnYeniKitapEkle.Size = new Size(109, 52);
            btnYeniKitapEkle.TabIndex = 0;
            btnYeniKitapEkle.Text = "EKLE";
            btnYeniKitapEkle.UseVisualStyleBackColor = false;
            btnYeniKitapEkle.Click += btnYeniKitapEkle_Click;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.BackgroundColor = Color.AliceBlue;
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(33, 58);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKitaplar.Size = new Size(788, 325);
            dgvKitaplar.TabIndex = 1;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ButtonFace;
            btnSil.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.FromArgb(192, 0, 0);
            btnSil.Location = new Point(43, 407);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(103, 54);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL ";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // picTemizle
            // 
            picTemizle.Cursor = Cursors.Hand;
            picTemizle.Image = Properties.Resources.recycle_bin;
            picTemizle.Location = new Point(780, 20);
            picTemizle.Name = "picTemizle";
            picTemizle.Size = new Size(41, 34);
            picTemizle.SizeMode = PictureBoxSizeMode.Zoom;
            picTemizle.TabIndex = 16;
            picTemizle.TabStop = false;
            picTemizle.Click += picTemizle_Click;
            // 
            // picAra
            // 
            picAra.Cursor = Cursors.Hand;
            picAra.Image = Properties.Resources.magnifier;
            picAra.Location = new Point(33, 22);
            picAra.Name = "picAra";
            picAra.Size = new Size(39, 32);
            picAra.SizeMode = PictureBoxSizeMode.Zoom;
            picAra.TabIndex = 15;
            picAra.TabStop = false;
            picAra.Click += picAra_Click;
            // 
            // txtAra
            // 
            txtAra.BorderStyle = BorderStyle.None;
            txtAra.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAra.Location = new Point(78, 22);
            txtAra.Multiline = true;
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(696, 30);
            txtAra.TabIndex = 14;
            txtAra.KeyDown += txtAra_KeyDown;
            // 
            // kitaplarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 189, 203);
            ClientSize = new Size(932, 546);
            Controls.Add(picTemizle);
            Controls.Add(picAra);
            Controls.Add(txtAra);
            Controls.Add(btnSil);
            Controls.Add(dgvKitaplar);
            Controls.Add(btnYeniKitapEkle);
            Name = "kitaplarForm";
            Text = "kitaplarForm";
            Load += kitaplarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTemizle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYeniKitapEkle;
        private DataGridView dgvKitaplar;
        private Button btnSil;
        private PictureBox picTemizle;
        private PictureBox picAra;
        private TextBox txtAra;
    }
}