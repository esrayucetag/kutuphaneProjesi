namespace kutuphaneProjesi.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hosgeldinLabel = new Label();
            kullaniciAdTextBox = new TextBox();
            sifreTextBox = new TextBox();
            kullaniciAdLbl = new Label();
            sifreLbl = new Label();
            yoneticiGirisButton = new Button();
            uyeGirisButton = new Button();
            buttonKayit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // hosgeldinLabel
            // 
            hosgeldinLabel.AutoSize = true;
            hosgeldinLabel.ForeColor = SystemColors.WindowText;
            hosgeldinLabel.Location = new Point(302, 81);
            hosgeldinLabel.Name = "hosgeldinLabel";
            hosgeldinLabel.Size = new Size(235, 40);
            hosgeldinLabel.TabIndex = 0;
            hosgeldinLabel.Text = "Kütüphane Sistemine Hoşgeldiniz!\r\nLütfen giriş yapın.";
            // 
            // kullaniciAdTextBox
            // 
            kullaniciAdTextBox.ForeColor = SystemColors.WindowText;
            kullaniciAdTextBox.Location = new Point(412, 160);
            kullaniciAdTextBox.Name = "kullaniciAdTextBox";
            kullaniciAdTextBox.Size = new Size(125, 27);
            kullaniciAdTextBox.TabIndex = 1;
            // 
            // sifreTextBox
            // 
            sifreTextBox.ForeColor = SystemColors.WindowText;
            sifreTextBox.Location = new Point(412, 212);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.Size = new Size(125, 27);
            sifreTextBox.TabIndex = 2;
            sifreTextBox.UseSystemPasswordChar = true;
            // 
            // kullaniciAdLbl
            // 
            kullaniciAdLbl.AutoSize = true;
            kullaniciAdLbl.ForeColor = SystemColors.WindowText;
            kullaniciAdLbl.Location = new Point(297, 163);
            kullaniciAdLbl.Name = "kullaniciAdLbl";
            kullaniciAdLbl.Size = new Size(109, 20);
            kullaniciAdLbl.TabIndex = 3;
            kullaniciAdLbl.Text = "KULLANICI ADI";
            // 
            // sifreLbl
            // 
            sifreLbl.AutoSize = true;
            sifreLbl.ForeColor = SystemColors.WindowText;
            sifreLbl.Location = new Point(361, 215);
            sifreLbl.Name = "sifreLbl";
            sifreLbl.Size = new Size(45, 20);
            sifreLbl.TabIndex = 4;
            sifreLbl.Text = "ŞİFRE";
            // 
            // yoneticiGirisButton
            // 
            yoneticiGirisButton.BackColor = Color.SandyBrown;
            yoneticiGirisButton.ForeColor = SystemColors.WindowText;
            yoneticiGirisButton.Location = new Point(447, 312);
            yoneticiGirisButton.Name = "yoneticiGirisButton";
            yoneticiGirisButton.Size = new Size(90, 54);
            yoneticiGirisButton.TabIndex = 5;
            yoneticiGirisButton.Text = "YÖNETİCİ \r\n   GİRİŞ";
            yoneticiGirisButton.UseVisualStyleBackColor = false;
            yoneticiGirisButton.Click += yoneticiGirisButton_Click;
            // 
            // uyeGirisButton
            // 
            uyeGirisButton.BackColor = SystemColors.ActiveCaption;
            uyeGirisButton.ForeColor = SystemColors.WindowText;
            uyeGirisButton.Location = new Point(332, 312);
            uyeGirisButton.Name = "uyeGirisButton";
            uyeGirisButton.Size = new Size(90, 54);
            uyeGirisButton.TabIndex = 6;
            uyeGirisButton.Text = "ÜYE GİRİŞ";
            uyeGirisButton.UseVisualStyleBackColor = false;
            uyeGirisButton.Click += uyeGirisButton_Click;
            // 
            // buttonKayit
            // 
            buttonKayit.BackColor = Color.White;
            buttonKayit.ForeColor = Color.Red;
            buttonKayit.Location = new Point(391, 440);
            buttonKayit.Name = "buttonKayit";
            buttonKayit.Size = new Size(94, 29);
            buttonKayit.TabIndex = 7;
            buttonKayit.Text = "KAYIT OL";
            buttonKayit.UseVisualStyleBackColor = false;
            buttonKayit.Click += buttonKayit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(327, 407);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 8;
            label1.Text = "sisteme kayıtlı üyeliğiniz yoksa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(868, 596);
            Controls.Add(label1);
            Controls.Add(buttonKayit);
            Controls.Add(uyeGirisButton);
            Controls.Add(yoneticiGirisButton);
            Controls.Add(sifreLbl);
            Controls.Add(kullaniciAdLbl);
            Controls.Add(sifreTextBox);
            Controls.Add(kullaniciAdTextBox);
            Controls.Add(hosgeldinLabel);
            Name = "Form1";
            Text = "Form1girisEkran";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hosgeldinLabel;
        private TextBox kullaniciAdTextBox;
        private TextBox sifreTextBox;
        private Label kullaniciAdLbl;
        private Label sifreLbl;
        private Button yoneticiGirisButton;
        private Button uyeGirisButton;
        private Button buttonKayit;
        private Label label1;
    }
}
