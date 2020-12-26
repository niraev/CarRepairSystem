namespace OtoTamir
{
    partial class frmUstaGecis
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
            this.bttnTamirGecis = new System.Windows.Forms.Button();
            this.bttnServisFormuGecis = new System.Windows.Forms.Button();
            this.bttnGeri = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCalisanAd = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnTamirGecis
            // 
            this.bttnTamirGecis.Location = new System.Drawing.Point(156, 173);
            this.bttnTamirGecis.Name = "bttnTamirGecis";
            this.bttnTamirGecis.Size = new System.Drawing.Size(264, 109);
            this.bttnTamirGecis.TabIndex = 0;
            this.bttnTamirGecis.Text = "Tamir Ekrani";
            this.bttnTamirGecis.UseVisualStyleBackColor = true;
            this.bttnTamirGecis.Click += new System.EventHandler(this.bttnTamirGecis_Click);
            // 
            // bttnServisFormuGecis
            // 
            this.bttnServisFormuGecis.Location = new System.Drawing.Point(578, 173);
            this.bttnServisFormuGecis.Name = "bttnServisFormuGecis";
            this.bttnServisFormuGecis.Size = new System.Drawing.Size(264, 109);
            this.bttnServisFormuGecis.TabIndex = 1;
            this.bttnServisFormuGecis.Text = "Servis Formu Ekrani";
            this.bttnServisFormuGecis.UseVisualStyleBackColor = true;
            this.bttnServisFormuGecis.Click += new System.EventHandler(this.bttnServisFormuGecis_Click);
            // 
            // bttnGeri
            // 
            this.bttnGeri.Location = new System.Drawing.Point(13, 13);
            this.bttnGeri.Name = "bttnGeri";
            this.bttnGeri.Size = new System.Drawing.Size(75, 23);
            this.bttnGeri.TabIndex = 2;
            this.bttnGeri.Text = "Geri";
            this.bttnGeri.UseVisualStyleBackColor = true;
            this.bttnGeri.Click += new System.EventHandler(this.bttnGeri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Isim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kullanici Adi";
            // 
            // lblCalisanAd
            // 
            this.lblCalisanAd.AutoSize = true;
            this.lblCalisanAd.Location = new System.Drawing.Point(509, 77);
            this.lblCalisanAd.Name = "lblCalisanAd";
            this.lblCalisanAd.Size = new System.Drawing.Size(46, 17);
            this.lblCalisanAd.TabIndex = 16;
            this.lblCalisanAd.Text = "label2";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(509, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 17);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(440, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hosgeldiniz ";
            // 
            // frmUstaGecis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCalisanAd);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnGeri);
            this.Controls.Add(this.bttnServisFormuGecis);
            this.Controls.Add(this.bttnTamirGecis);
            this.Name = "frmUstaGecis";
            this.Text = "Usta - Aktarma ";
            this.Load += new System.EventHandler(this.frmUstaGecis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnTamirGecis;
        private System.Windows.Forms.Button bttnServisFormuGecis;
        private System.Windows.Forms.Button bttnGeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCalisanAd;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
    }
}