namespace OtoTamir
{
    partial class frmLogin
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
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.bttnGiris = new System.Windows.Forms.Button();
            this.KullaniciAdiKutu = new System.Windows.Forms.TextBox();
            this.SifreKutu = new System.Windows.Forms.TextBox();
            this.bttnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(771, 419);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(88, 17);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanici Adi ";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(771, 456);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(37, 17);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Sifre";
            // 
            // bttnGiris
            // 
            this.bttnGiris.Location = new System.Drawing.Point(1191, 615);
            this.bttnGiris.Name = "bttnGiris";
            this.bttnGiris.Size = new System.Drawing.Size(75, 23);
            this.bttnGiris.TabIndex = 2;
            this.bttnGiris.Text = "Giris ";
            this.bttnGiris.UseVisualStyleBackColor = true;
            this.bttnGiris.Click += new System.EventHandler(this.bttnGiris_Click);
            // 
            // KullaniciAdiKutu
            // 
            this.KullaniciAdiKutu.Location = new System.Drawing.Point(896, 419);
            this.KullaniciAdiKutu.Name = "KullaniciAdiKutu";
            this.KullaniciAdiKutu.Size = new System.Drawing.Size(100, 22);
            this.KullaniciAdiKutu.TabIndex = 3;
            // 
            // SifreKutu
            // 
            this.SifreKutu.Location = new System.Drawing.Point(896, 456);
            this.SifreKutu.Name = "SifreKutu";
            this.SifreKutu.PasswordChar = '*';
            this.SifreKutu.Size = new System.Drawing.Size(100, 22);
            this.SifreKutu.TabIndex = 4;
            // 
            // bttnKapat
            // 
            this.bttnKapat.Location = new System.Drawing.Point(1094, 615);
            this.bttnKapat.Name = "bttnKapat";
            this.bttnKapat.Size = new System.Drawing.Size(75, 23);
            this.bttnKapat.TabIndex = 5;
            this.bttnKapat.Text = "Kapat";
            this.bttnKapat.UseVisualStyleBackColor = true;
            this.bttnKapat.Click += new System.EventHandler(this.bttnKapat_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 751);
            this.Controls.Add(this.bttnKapat);
            this.Controls.Add(this.SifreKutu);
            this.Controls.Add(this.KullaniciAdiKutu);
            this.Controls.Add(this.bttnGiris);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button bttnGiris;
        private System.Windows.Forms.TextBox KullaniciAdiKutu;
        private System.Windows.Forms.TextBox SifreKutu;
        private System.Windows.Forms.Button bttnKapat;
    }
}

