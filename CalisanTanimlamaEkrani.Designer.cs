namespace OtoTamir
{
    partial class frmCalisanTanimlama
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
            this.label1 = new System.Windows.Forms.Label();
            this.CalisanAdKutu = new System.Windows.Forms.TextBox();
            this.CalisanSoyadKutu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KullaniciAdiKutu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SifreKutu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttnCalisanEkle = new System.Windows.Forms.Button();
            this.bttnYeniCalisanEkle = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnKapat = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCalisanAd = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.CalisanTipiComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calisan Ad";
            // 
            // CalisanAdKutu
            // 
            this.CalisanAdKutu.Location = new System.Drawing.Point(195, 67);
            this.CalisanAdKutu.Name = "CalisanAdKutu";
            this.CalisanAdKutu.Size = new System.Drawing.Size(100, 22);
            this.CalisanAdKutu.TabIndex = 1;
            this.CalisanAdKutu.TextChanged += new System.EventHandler(this.CalisanAdKutu_TextChanged);
            // 
            // CalisanSoyadKutu
            // 
            this.CalisanSoyadKutu.Location = new System.Drawing.Point(195, 117);
            this.CalisanSoyadKutu.Name = "CalisanSoyadKutu";
            this.CalisanSoyadKutu.Size = new System.Drawing.Size(100, 22);
            this.CalisanSoyadKutu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calisan Soyad";
            // 
            // KullaniciAdiKutu
            // 
            this.KullaniciAdiKutu.Location = new System.Drawing.Point(195, 183);
            this.KullaniciAdiKutu.Name = "KullaniciAdiKutu";
            this.KullaniciAdiKutu.Size = new System.Drawing.Size(100, 22);
            this.KullaniciAdiKutu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kullanici Adi";
            // 
            // SifreKutu
            // 
            this.SifreKutu.Location = new System.Drawing.Point(195, 253);
            this.SifreKutu.Name = "SifreKutu";
            this.SifreKutu.Size = new System.Drawing.Size(100, 22);
            this.SifreKutu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Calisan Tipi";
            // 
            // bttnCalisanEkle
            // 
            this.bttnCalisanEkle.Location = new System.Drawing.Point(559, 82);
            this.bttnCalisanEkle.Name = "bttnCalisanEkle";
            this.bttnCalisanEkle.Size = new System.Drawing.Size(130, 52);
            this.bttnCalisanEkle.TabIndex = 10;
            this.bttnCalisanEkle.Text = "Ekle";
            this.bttnCalisanEkle.UseVisualStyleBackColor = true;
            this.bttnCalisanEkle.Click += new System.EventHandler(this.bttnCalisanEkle_Click);
            // 
            // bttnYeniCalisanEkle
            // 
            this.bttnYeniCalisanEkle.Location = new System.Drawing.Point(559, 183);
            this.bttnYeniCalisanEkle.Name = "bttnYeniCalisanEkle";
            this.bttnYeniCalisanEkle.Size = new System.Drawing.Size(130, 52);
            this.bttnYeniCalisanEkle.TabIndex = 17;
            this.bttnYeniCalisanEkle.Text = "Yeni Calisan Ekle";
            this.bttnYeniCalisanEkle.UseVisualStyleBackColor = true;
            this.bttnYeniCalisanEkle.Click += new System.EventHandler(this.bttnYeniCalisanEkle_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.Location = new System.Drawing.Point(12, 12);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(75, 23);
            this.bttnBack.TabIndex = 18;
            this.bttnBack.Text = "Geri";
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // bttnKapat
            // 
            this.bttnKapat.Location = new System.Drawing.Point(559, 275);
            this.bttnKapat.Name = "bttnKapat";
            this.bttnKapat.Size = new System.Drawing.Size(130, 52);
            this.bttnKapat.TabIndex = 19;
            this.bttnKapat.Text = "Kapat";
            this.bttnKapat.UseVisualStyleBackColor = true;
            this.bttnKapat.Click += new System.EventHandler(this.bttnKapat_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(635, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Isim";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(635, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Kullanici Adi";
            // 
            // lblCalisanAd
            // 
            this.lblCalisanAd.AutoSize = true;
            this.lblCalisanAd.Location = new System.Drawing.Point(739, 413);
            this.lblCalisanAd.Name = "lblCalisanAd";
            this.lblCalisanAd.Size = new System.Drawing.Size(46, 17);
            this.lblCalisanAd.TabIndex = 25;
            this.lblCalisanAd.Text = "label2";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(739, 384);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 17);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "label1";
            // 
            // CalisanTipiComboBox
            // 
            this.CalisanTipiComboBox.FormattingEnabled = true;
            this.CalisanTipiComboBox.Items.AddRange(new object[] {
            "Admin",
            "Servis Elemani",
            "Stok Elemani",
            "Kaporta Ustasi",
            "Boya Ustasi",
            "Motor Ustasi"});
            this.CalisanTipiComboBox.Location = new System.Drawing.Point(195, 326);
            this.CalisanTipiComboBox.Name = "CalisanTipiComboBox";
            this.CalisanTipiComboBox.Size = new System.Drawing.Size(121, 24);
            this.CalisanTipiComboBox.TabIndex = 28;
            // 
            // frmCalisanTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.CalisanTipiComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCalisanAd);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.bttnKapat);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.bttnYeniCalisanEkle);
            this.Controls.Add(this.bttnCalisanEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SifreKutu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KullaniciAdiKutu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalisanSoyadKutu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalisanAdKutu);
            this.Controls.Add(this.label1);
            this.Name = "frmCalisanTanimlama";
            this.Text = "Calisan Tanimlama";
            this.Load += new System.EventHandler(this.frmCalisanTanimlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CalisanAdKutu;
        private System.Windows.Forms.TextBox CalisanSoyadKutu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KullaniciAdiKutu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SifreKutu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttnCalisanEkle;
        private System.Windows.Forms.Button bttnYeniCalisanEkle;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnKapat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCalisanAd;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox CalisanTipiComboBox;
    }
}