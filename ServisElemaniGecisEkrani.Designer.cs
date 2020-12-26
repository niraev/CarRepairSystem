namespace OtoTamir
{
    partial class frmServisElemaniGecis
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
            this.bttnAracKabulTeslimGecis = new System.Windows.Forms.Button();
            this.bttnServisFormuGecis = new System.Windows.Forms.Button();
            this.bttnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCalisanAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnAracKabulTeslimGecis
            // 
            this.bttnAracKabulTeslimGecis.Location = new System.Drawing.Point(137, 158);
            this.bttnAracKabulTeslimGecis.Name = "bttnAracKabulTeslimGecis";
            this.bttnAracKabulTeslimGecis.Size = new System.Drawing.Size(214, 92);
            this.bttnAracKabulTeslimGecis.TabIndex = 0;
            this.bttnAracKabulTeslimGecis.Text = "Arac Kabul - Teslim";
            this.bttnAracKabulTeslimGecis.UseVisualStyleBackColor = true;
            this.bttnAracKabulTeslimGecis.Click += new System.EventHandler(this.bttnAracKabulTeslimGecis_Click);
            // 
            // bttnServisFormuGecis
            // 
            this.bttnServisFormuGecis.Location = new System.Drawing.Point(458, 158);
            this.bttnServisFormuGecis.Name = "bttnServisFormuGecis";
            this.bttnServisFormuGecis.Size = new System.Drawing.Size(214, 92);
            this.bttnServisFormuGecis.TabIndex = 1;
            this.bttnServisFormuGecis.Text = "Servis Formu";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(356, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hosgeldiniz ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(425, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 17);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "label1";
            // 
            // lblCalisanAd
            // 
            this.lblCalisanAd.AutoSize = true;
            this.lblCalisanAd.Location = new System.Drawing.Point(425, 90);
            this.lblCalisanAd.Name = "lblCalisanAd";
            this.lblCalisanAd.Size = new System.Drawing.Size(46, 17);
            this.lblCalisanAd.TabIndex = 6;
            this.lblCalisanAd.Text = "label2";
            this.lblCalisanAd.Click += new System.EventHandler(this.lblCalisanAd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanici Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Isim";
            // 
            // frmServisElemaniGecis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCalisanAd);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnGeri);
            this.Controls.Add(this.bttnServisFormuGecis);
            this.Controls.Add(this.bttnAracKabulTeslimGecis);
            this.Name = "frmServisElemaniGecis";
            this.Text = "Servis Elemani - Aktarma";
            this.Load += new System.EventHandler(this.frmServisElemaniGecis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAracKabulTeslimGecis;
        private System.Windows.Forms.Button bttnServisFormuGecis;
        private System.Windows.Forms.Button bttnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCalisanAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}