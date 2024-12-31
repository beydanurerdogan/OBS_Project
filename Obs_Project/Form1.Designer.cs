namespace Obs_Project
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
            btnDersSecim = new Button();
            btnBul = new Button();
            btnKayit = new Button();
            btnGuncelle = new Button();
            groupBox1 = new GroupBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            cbxSınıfSeç = new ComboBox();
            lblSinifSecimi = new Label();
            lblNumara = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDersSecim
            // 
            btnDersSecim.Location = new Point(203, 485);
            btnDersSecim.Name = "btnDersSecim";
            btnDersSecim.Size = new Size(217, 44);
            btnDersSecim.TabIndex = 9;
            btnDersSecim.Text = "Ders Seçimi";
            btnDersSecim.UseVisualStyleBackColor = true;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(426, 424);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(116, 44);
            btnBul.TabIndex = 8;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(203, 424);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(217, 44);
            btnKayit.TabIndex = 7;
            btnKayit.Text = "Kayıt";
            btnKayit.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(70, 424);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(116, 44);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtNumara);
            groupBox1.Controls.Add(cbxSınıfSeç);
            groupBox1.Controls.Add(lblSinifSecimi);
            groupBox1.Controls.Add(lblNumara);
            groupBox1.Controls.Add(lblSoyad);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Location = new Point(78, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 343);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(207, 83);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(207, 133);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(207, 192);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(125, 27);
            txtNumara.TabIndex = 5;
            // 
            // cbxSınıfSeç
            // 
            cbxSınıfSeç.FormattingEnabled = true;
            cbxSınıfSeç.Location = new Point(207, 252);
            cbxSınıfSeç.Name = "cbxSınıfSeç";
            cbxSınıfSeç.Size = new Size(151, 28);
            cbxSınıfSeç.TabIndex = 4;
            // 
            // lblSinifSecimi
            // 
            lblSinifSecimi.AutoSize = true;
            lblSinifSecimi.Location = new Point(95, 260);
            lblSinifSecimi.Name = "lblSinifSecimi";
            lblSinifSecimi.Size = new Size(88, 20);
            lblSinifSecimi.TabIndex = 3;
            lblSinifSecimi.Text = "Sınıf Seçiniz";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(95, 199);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(62, 20);
            lblNumara.TabIndex = 2;
            lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(95, 140);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(95, 90);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 588);
            Controls.Add(btnDersSecim);
            Controls.Add(btnBul);
            Controls.Add(btnKayit);
            Controls.Add(btnGuncelle);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Bul";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDersSecim;
        private Button btnBul;
        private Button btnKayit;
        private Button btnGuncelle;
        private GroupBox groupBox1;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNumara;
        private ComboBox cbxSınıfSeç;
        private Label lblSinifSecimi;
        private Label lblNumara;
        private Label lblSoyad;
        private Label lblAd;
    }
}
