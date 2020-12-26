namespace OtoTamir
{
    partial class frmStokKarti
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
            this.StokKoduKutu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StokAdiKutu = new System.Windows.Forms.TextBox();
            this.StokMiktariKutu = new System.Windows.Forms.TextBox();
            this.AlisFiyatiKutu = new System.Windows.Forms.TextBox();
            this.SatisFiyatiKutu = new System.Windows.Forms.TextBox();
            this.bttnGeri = new System.Windows.Forms.Button();
            this.bttnYeniStokKaydi = new System.Windows.Forms.Button();
            this.bttnEkle = new System.Windows.Forms.Button();
            this.StokBirimiComboKutu = new System.Windows.Forms.ComboBox();
            this.bttnKapat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCalisanAd = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kodu:";
            // 
            // StokKoduKutu
            // 
            this.StokKoduKutu.Location = new System.Drawing.Point(160, 65);
            this.StokKoduKutu.Name = "StokKoduKutu";
            this.StokKoduKutu.Size = new System.Drawing.Size(100, 22);
            this.StokKoduKutu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Adi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stok Miktari:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stok Birimi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Alis Fiyati:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Satis Fiyati:";
            // 
            // StokAdiKutu
            // 
            this.StokAdiKutu.Location = new System.Drawing.Point(160, 116);
            this.StokAdiKutu.Name = "StokAdiKutu";
            this.StokAdiKutu.Size = new System.Drawing.Size(100, 22);
            this.StokAdiKutu.TabIndex = 8;
            // 
            // StokMiktariKutu
            // 
            this.StokMiktariKutu.Location = new System.Drawing.Point(160, 170);
            this.StokMiktariKutu.Name = "StokMiktariKutu";
            this.StokMiktariKutu.Size = new System.Drawing.Size(100, 22);
            this.StokMiktariKutu.TabIndex = 10;
            this.StokMiktariKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StokMiktariKutu_KeyPress);
            // 
            // AlisFiyatiKutu
            // 
            this.AlisFiyatiKutu.Location = new System.Drawing.Point(510, 121);
            this.AlisFiyatiKutu.Name = "AlisFiyatiKutu";
            this.AlisFiyatiKutu.Size = new System.Drawing.Size(100, 22);
            this.AlisFiyatiKutu.TabIndex = 12;
            this.AlisFiyatiKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlisFiyatiKutu_KeyPress);
            // 
            // SatisFiyatiKutu
            // 
            this.SatisFiyatiKutu.Location = new System.Drawing.Point(510, 228);
            this.SatisFiyatiKutu.Name = "SatisFiyatiKutu";
            this.SatisFiyatiKutu.Size = new System.Drawing.Size(100, 22);
            this.SatisFiyatiKutu.TabIndex = 13;
            this.SatisFiyatiKutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SatisFiyatiKutu_KeyPress);
            // 
            // bttnGeri
            // 
            this.bttnGeri.Location = new System.Drawing.Point(13, 13);
            this.bttnGeri.Name = "bttnGeri";
            this.bttnGeri.Size = new System.Drawing.Size(75, 23);
            this.bttnGeri.TabIndex = 15;
            this.bttnGeri.Text = "Geri";
            this.bttnGeri.UseVisualStyleBackColor = true;
            this.bttnGeri.Click += new System.EventHandler(this.bttnGeri_Click);
            // 
            // bttnYeniStokKaydi
            // 
            this.bttnYeniStokKaydi.Location = new System.Drawing.Point(339, 316);
            this.bttnYeniStokKaydi.Name = "bttnYeniStokKaydi";
            this.bttnYeniStokKaydi.Size = new System.Drawing.Size(119, 62);
            this.bttnYeniStokKaydi.TabIndex = 16;
            this.bttnYeniStokKaydi.Text = "Yeni Stok Kaydi";
            this.bttnYeniStokKaydi.UseVisualStyleBackColor = true;
            this.bttnYeniStokKaydi.Click += new System.EventHandler(this.bttnYeniStokKaydi_Click);
            // 
            // bttnEkle
            // 
            this.bttnEkle.Location = new System.Drawing.Point(160, 316);
            this.bttnEkle.Name = "bttnEkle";
            this.bttnEkle.Size = new System.Drawing.Size(119, 62);
            this.bttnEkle.TabIndex = 17;
            this.bttnEkle.Text = "Ekle";
            this.bttnEkle.UseVisualStyleBackColor = true;
            this.bttnEkle.Click += new System.EventHandler(this.bttnEkle_Click);
            // 
            // StokBirimiComboKutu
            // 
            this.StokBirimiComboKutu.FormattingEnabled = true;
            this.StokBirimiComboKutu.Items.AddRange(new object[] {
            "kg",
            "m^2",
            "Adet"});
            this.StokBirimiComboKutu.Location = new System.Drawing.Point(160, 228);
            this.StokBirimiComboKutu.Name = "StokBirimiComboKutu";
            this.StokBirimiComboKutu.Size = new System.Drawing.Size(121, 24);
            this.StokBirimiComboKutu.TabIndex = 18;
            this.StokBirimiComboKutu.SelectedIndexChanged += new System.EventHandler(this.StokBirimiComboKutu_SelectedIndexChanged);
            // 
            // bttnKapat
            // 
            this.bttnKapat.Location = new System.Drawing.Point(510, 316);
            this.bttnKapat.Name = "bttnKapat";
            this.bttnKapat.Size = new System.Drawing.Size(119, 62);
            this.bttnKapat.TabIndex = 19;
            this.bttnKapat.Text = "Kapat";
            this.bttnKapat.UseVisualStyleBackColor = true;
            this.bttnKapat.Click += new System.EventHandler(this.bttnKapat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Isim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Kullanici Adi";
            // 
            // lblCalisanAd
            // 
            this.lblCalisanAd.AutoSize = true;
            this.lblCalisanAd.Location = new System.Drawing.Point(611, 48);
            this.lblCalisanAd.Name = "lblCalisanAd";
            this.lblCalisanAd.Size = new System.Drawing.Size(46, 17);
            this.lblCalisanAd.TabIndex = 21;
            this.lblCalisanAd.Text = "label2";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(611, 19);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 17);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "label1";
            // 
            // frmStokKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCalisanAd);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.bttnKapat);
            this.Controls.Add(this.StokBirimiComboKutu);
            this.Controls.Add(this.bttnEkle);
            this.Controls.Add(this.bttnYeniStokKaydi);
            this.Controls.Add(this.bttnGeri);
            this.Controls.Add(this.SatisFiyatiKutu);
            this.Controls.Add(this.AlisFiyatiKutu);
            this.Controls.Add(this.StokMiktariKutu);
            this.Controls.Add(this.StokAdiKutu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StokKoduKutu);
            this.Controls.Add(this.label1);
            this.Name = "frmStokKarti";
            this.Text = "Stok Karti ";
            this.Load += new System.EventHandler(this.frmStokKarti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StokKoduKutu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StokAdiKutu;
        private System.Windows.Forms.TextBox StokMiktariKutu;
        private System.Windows.Forms.TextBox AlisFiyatiKutu;
        private System.Windows.Forms.TextBox SatisFiyatiKutu;
        private System.Windows.Forms.Button bttnGeri;
        private System.Windows.Forms.Button bttnYeniStokKaydi;
        private System.Windows.Forms.Button bttnEkle;
        private System.Windows.Forms.ComboBox StokBirimiComboKutu;
        private System.Windows.Forms.Button bttnKapat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCalisanAd;
        private System.Windows.Forms.Label lblUsername;
    }
}