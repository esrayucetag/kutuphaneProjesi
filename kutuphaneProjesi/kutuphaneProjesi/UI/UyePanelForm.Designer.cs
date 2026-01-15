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
            dgvGecmis = new DataGridView();
            lblHosgeldin = new Label();
            panel1 = new Panel();
            lblToplamOkunan = new Label();
            btnGeri = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGecmis
            // 
            dgvGecmis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGecmis.Location = new Point(78, 67);
            dgvGecmis.Name = "dgvGecmis";
            dgvGecmis.RowHeadersWidth = 51;
            dgvGecmis.Size = new Size(517, 157);
            dgvGecmis.TabIndex = 0;
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.AutoSize = true;
            lblHosgeldin.Location = new Point(78, 44);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new Size(146, 20);
            lblHosgeldin.TabIndex = 1;
            lblHosgeldin.Text = "Üzerinizdeki Kitaplar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(lblToplamOkunan);
            panel1.Location = new Point(78, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 56);
            panel1.TabIndex = 2;
            // 
            // lblToplamOkunan
            // 
            lblToplamOkunan.AutoSize = true;
            lblToplamOkunan.Location = new Point(3, 11);
            lblToplamOkunan.Name = "lblToplamOkunan";
            lblToplamOkunan.Size = new Size(169, 20);
            lblToplamOkunan.TabIndex = 0;
            lblToplamOkunan.Text = "toplam okuduğum kitap";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.Red;
            btnGeri.Location = new Point(15, 14);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(50, 29);
            btnGeri.TabIndex = 3;
            btnGeri.Text = "geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 227);
            label1.Name = "label1";
            label1.Size = new Size(226, 20);
            label1.TabIndex = 1;
            label1.Text = "Toplam Okuduğunuz Kitap Sayısı";
            // 
            // UyePanelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(627, 317);
            Controls.Add(label1);
            Controls.Add(btnGeri);
            Controls.Add(panel1);
            Controls.Add(lblHosgeldin);
            Controls.Add(dgvGecmis);
            Name = "UyePanelForm";
            Text = "UyePanelForm";
            Load += UyePanelForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGecmis;
        private Label lblHosgeldin;
        private Panel panel1;
        private Label lblToplamOkunan;
        private Button btnGeri;
        private Label label1;
    }
}