namespace kutuphaneProjesi.UI
{
    partial class istatistikForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            lblKitap = new Label();
            txtToplamKitap = new TextBox();
            panel2 = new Panel();
            lblUye = new Label();
            txtToplamUye = new TextBox();
            panel3 = new Panel();
            lblOdunc = new Label();
            txtOduncKitap = new TextBox();
            panelAltGrafik = new Panel();
            lblEnCokOkuyanlar = new Label();
            dgvEnCokOkuyanlar = new DataGridView();
            pnlIstatistik = new Panel();
            lblRaporBaslik = new Label();
            dgvIstatistik = new DataGridView();
            chartRapor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnRaporGeciken = new Button();
            btnRaporPopuler = new Button();
            panelGrafikler = new Panel();
            panel4 = new Panel();
            panelUstGrafik = new Panel();
            chartPasta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelAltGrafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnCokOkuyanlar).BeginInit();
            pnlIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIstatistik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRapor).BeginInit();
            panelGrafikler.SuspendLayout();
            panel4.SuspendLayout();
            panelUstGrafik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPasta).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblKitap);
            panel1.Controls.Add(txtToplamKitap);
            panel1.Location = new Point(30, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 112);
            panel1.TabIndex = 0;
            // 
            // lblKitap
            // 
            lblKitap.BackColor = Color.AliceBlue;
            lblKitap.BorderStyle = BorderStyle.FixedSingle;
            lblKitap.Location = new Point(20, 20);
            lblKitap.Name = "lblKitap";
            lblKitap.Padding = new Padding(10, 5, 10, 5);
            lblKitap.Size = new Size(157, 34);
            lblKitap.TabIndex = 0;
            lblKitap.Text = "Toplam Kitap";
            // 
            // txtToplamKitap
            // 
            txtToplamKitap.Location = new Point(20, 57);
            txtToplamKitap.Multiline = true;
            txtToplamKitap.Name = "txtToplamKitap";
            txtToplamKitap.ReadOnly = true;
            txtToplamKitap.Size = new Size(157, 39);
            txtToplamKitap.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(188, 189, 203);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblUye);
            panel2.Controls.Add(txtToplamUye);
            panel2.Location = new Point(248, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 112);
            panel2.TabIndex = 1;
            // 
            // lblUye
            // 
            lblUye.BackColor = Color.AliceBlue;
            lblUye.BorderStyle = BorderStyle.FixedSingle;
            lblUye.Location = new Point(19, 20);
            lblUye.Name = "lblUye";
            lblUye.Padding = new Padding(10, 5, 10, 5);
            lblUye.Size = new Size(157, 34);
            lblUye.TabIndex = 0;
            lblUye.Text = "Toplam Üye";
            // 
            // txtToplamUye
            // 
            txtToplamUye.Location = new Point(19, 57);
            txtToplamUye.Multiline = true;
            txtToplamUye.Name = "txtToplamUye";
            txtToplamUye.ReadOnly = true;
            txtToplamUye.Size = new Size(157, 39);
            txtToplamUye.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblOdunc);
            panel3.Controls.Add(txtOduncKitap);
            panel3.Location = new Point(469, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 112);
            panel3.TabIndex = 2;
            // 
            // lblOdunc
            // 
            lblOdunc.BackColor = Color.AliceBlue;
            lblOdunc.BorderStyle = BorderStyle.FixedSingle;
            lblOdunc.Location = new Point(23, 20);
            lblOdunc.Name = "lblOdunc";
            lblOdunc.Padding = new Padding(10, 5, 10, 5);
            lblOdunc.Size = new Size(157, 34);
            lblOdunc.TabIndex = 0;
            lblOdunc.Text = "Ödünçteki Kitaplar";
            // 
            // txtOduncKitap
            // 
            txtOduncKitap.Location = new Point(23, 57);
            txtOduncKitap.Multiline = true;
            txtOduncKitap.Name = "txtOduncKitap";
            txtOduncKitap.ReadOnly = true;
            txtOduncKitap.Size = new Size(157, 39);
            txtOduncKitap.TabIndex = 1;
            // 
            // panelAltGrafik
            // 
            panelAltGrafik.BackColor = Color.AliceBlue;
            panelAltGrafik.BorderStyle = BorderStyle.FixedSingle;
            panelAltGrafik.Controls.Add(lblEnCokOkuyanlar);
            panelAltGrafik.Controls.Add(dgvEnCokOkuyanlar);
            panelAltGrafik.Location = new Point(30, 185);
            panelAltGrafik.Name = "panelAltGrafik";
            panelAltGrafik.Size = new Size(645, 226);
            panelAltGrafik.TabIndex = 3;
            // 
            // lblEnCokOkuyanlar
            // 
            lblEnCokOkuyanlar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEnCokOkuyanlar.Location = new Point(20, 15);
            lblEnCokOkuyanlar.Name = "lblEnCokOkuyanlar";
            lblEnCokOkuyanlar.Size = new Size(300, 32);
            lblEnCokOkuyanlar.TabIndex = 0;
            lblEnCokOkuyanlar.Text = "EN ÇOK KİTAP OKUYAN ÜYELER";
            // 
            // dgvEnCokOkuyanlar
            // 
            dgvEnCokOkuyanlar.BackgroundColor = SystemColors.Control;
            dgvEnCokOkuyanlar.ColumnHeadersHeight = 29;
            dgvEnCokOkuyanlar.Location = new Point(-1, 50);
            dgvEnCokOkuyanlar.Name = "dgvEnCokOkuyanlar";
            dgvEnCokOkuyanlar.RowHeadersWidth = 51;
            dgvEnCokOkuyanlar.Size = new Size(645, 175);
            dgvEnCokOkuyanlar.TabIndex = 1;
            // 
            // pnlIstatistik
            // 
            pnlIstatistik.BackColor = Color.AliceBlue;
            pnlIstatistik.Controls.Add(lblRaporBaslik);
            pnlIstatistik.Controls.Add(dgvIstatistik);
            pnlIstatistik.Location = new Point(30, 417);
            pnlIstatistik.Name = "pnlIstatistik";
            pnlIstatistik.Size = new Size(645, 252);
            pnlIstatistik.TabIndex = 4;
            // 
            // lblRaporBaslik
            // 
            lblRaporBaslik.AutoSize = true;
            lblRaporBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblRaporBaslik.Location = new Point(21, 16);
            lblRaporBaslik.Name = "lblRaporBaslik";
            lblRaporBaslik.Size = new Size(196, 28);
            lblRaporBaslik.TabIndex = 1;
            lblRaporBaslik.Text = "RAPOR SONUÇLARI";
            // 
            // dgvIstatistik
            // 
            dgvIstatistik.BackgroundColor = SystemColors.Control;
            dgvIstatistik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIstatistik.Location = new Point(0, 47);
            dgvIstatistik.Name = "dgvIstatistik";
            dgvIstatistik.RowHeadersWidth = 51;
            dgvIstatistik.Size = new Size(645, 205);
            dgvIstatistik.TabIndex = 0;
            // 
            // chartRapor
            // 
            chartArea1.Name = "ChartArea1";
            chartRapor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRapor.Legends.Add(legend1);
            chartRapor.Location = new Point(3, 3);
            chartRapor.Name = "chartRapor";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRapor.Series.Add(series1);
            chartRapor.Size = new Size(504, 247);
            chartRapor.TabIndex = 7;
            chartRapor.Text = "chart1";
            // 
            // btnRaporGeciken
            // 
            btnRaporGeciken.BackColor = SystemColors.HotTrack;
            btnRaporGeciken.Cursor = Cursors.Hand;
            btnRaporGeciken.FlatAppearance.BorderSize = 0;
            btnRaporGeciken.FlatStyle = FlatStyle.Flat;
            btnRaporGeciken.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnRaporGeciken.ForeColor = SystemColors.ControlLightLight;
            btnRaporGeciken.Location = new Point(30, 686);
            btnRaporGeciken.Name = "btnRaporGeciken";
            btnRaporGeciken.Size = new Size(157, 70);
            btnRaporGeciken.TabIndex = 5;
            btnRaporGeciken.Text = "geciken kitaplar görüntüle";
            btnRaporGeciken.UseVisualStyleBackColor = false;
            btnRaporGeciken.Click += btnRaporGeciken_Click;
            // 
            // btnRaporPopuler
            // 
            btnRaporPopuler.BackColor = SystemColors.HotTrack;
            btnRaporPopuler.Cursor = Cursors.Hand;
            btnRaporPopuler.FlatAppearance.BorderSize = 0;
            btnRaporPopuler.FlatStyle = FlatStyle.Flat;
            btnRaporPopuler.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnRaporPopuler.ForeColor = SystemColors.HighlightText;
            btnRaporPopuler.Location = new Point(549, 675);
            btnRaporPopuler.Name = "btnRaporPopuler";
            btnRaporPopuler.Size = new Size(157, 70);
            btnRaporPopuler.TabIndex = 6;
            btnRaporPopuler.Text = "en cok okunan kitaplar görüntüle";
            btnRaporPopuler.UseVisualStyleBackColor = false;
            btnRaporPopuler.Click += btnRaporPopuler_Click;
            // 
            // panelGrafikler
            // 
            panelGrafikler.Controls.Add(panel4);
            panelGrafikler.Controls.Add(panelUstGrafik);
            panelGrafikler.Location = new Point(681, 155);
            panelGrafikler.Name = "panelGrafikler";
            panelGrafikler.Size = new Size(547, 514);
            panelGrafikler.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Controls.Add(chartRapor);
            panel4.Location = new Point(3, 262);
            panel4.Name = "panel4";
            panel4.Size = new Size(513, 244);
            panel4.TabIndex = 10;
            // 
            // panelUstGrafik
            // 
            panelUstGrafik.Controls.Add(chartPasta);
            panelUstGrafik.Location = new Point(3, 15);
            panelUstGrafik.Name = "panelUstGrafik";
            panelUstGrafik.Size = new Size(510, 241);
            panelUstGrafik.TabIndex = 9;
            // 
            // chartPasta
            // 
            chartArea2.Name = "ChartArea1";
            chartPasta.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartPasta.Legends.Add(legend2);
            chartPasta.Location = new Point(3, 14);
            chartPasta.Name = "chartPasta";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartPasta.Series.Add(series2);
            chartPasta.Size = new Size(504, 217);
            chartPasta.TabIndex = 8;
            chartPasta.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(687, 139);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 9;
            label1.Text = "GRAFİKLER";
            // 
            // istatistikForm
            // 
            AutoScroll = true;
            BackColor = Color.FromArgb(188, 189, 203);
            ClientSize = new Size(1406, 1034);
            Controls.Add(label1);
            Controls.Add(panelGrafikler);
            Controls.Add(btnRaporPopuler);
            Controls.Add(btnRaporGeciken);
            Controls.Add(pnlIstatistik);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panelAltGrafik);
            Name = "istatistikForm";
            Text = "Kütüphane Analiz ve İstatistik";
            Load += istatistikForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelAltGrafik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnCokOkuyanlar).EndInit();
            pnlIstatistik.ResumeLayout(false);
            pnlIstatistik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIstatistik).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRapor).EndInit();
            panelGrafikler.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panelUstGrafik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartPasta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAltGrafik;
        private System.Windows.Forms.TextBox txtToplamKitap;
        private System.Windows.Forms.TextBox txtToplamUye;
        private System.Windows.Forms.TextBox txtOduncKitap;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.Label lblUye;
        private System.Windows.Forms.Label lblOdunc;
        private System.Windows.Forms.Label lblEnCokOkuyanlar;
        private System.Windows.Forms.DataGridView dgvEnCokOkuyanlar;
        private Panel pnlIstatistik;
        private DataGridView dgvIstatistik;
        private Button btnRaporGeciken;
        private Button btnRaporPopuler;
        private Label lblRaporBaslik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRapor;
        private Panel panelGrafikler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPasta;
        private Panel panel4;
        private Panel panelUstGrafik;
        private Label label1;
    }
}