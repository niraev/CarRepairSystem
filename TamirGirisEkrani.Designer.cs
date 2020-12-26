namespace OtoTamir
{
    partial class TamirGirisEkrani
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
            this.IslemGirisTarihiPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.PlakaKutu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnGirisYap = new System.Windows.Forms.Button();
            this.bttnIkinciAdim = new System.Windows.Forms.Button();
            this.bttnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IslemGirisTarihiPicker
            // 
            this.IslemGirisTarihiPicker.CustomFormat = " ";
            this.IslemGirisTarihiPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IslemGirisTarihiPicker.Location = new System.Drawing.Point(402, 103);
            this.IslemGirisTarihiPicker.Name = "IslemGirisTarihiPicker";
            this.IslemGirisTarihiPicker.Size = new System.Drawing.Size(314, 22);
            this.IslemGirisTarihiPicker.TabIndex = 21;
            this.IslemGirisTarihiPicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.IslemGirisTarihiPicker.ValueChanged += new System.EventHandler(this.IslemGirisTarihiPicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Islem Giris Tarihi";
            // 
            // PlakaKutu
            // 
            this.PlakaKutu.Location = new System.Drawing.Point(144, 108);
            this.PlakaKutu.Name = "PlakaKutu";
            this.PlakaKutu.Size = new System.Drawing.Size(100, 22);
            this.PlakaKutu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Plaka";
            // 
            // bttnGirisYap
            // 
            this.bttnGirisYap.Location = new System.Drawing.Point(316, 208);
            this.bttnGirisYap.Name = "bttnGirisYap";
            this.bttnGirisYap.Size = new System.Drawing.Size(171, 58);
            this.bttnGirisYap.TabIndex = 22;
            this.bttnGirisYap.Text = "Islem Girisi Olustur";
            this.bttnGirisYap.UseVisualStyleBackColor = true;
            this.bttnGirisYap.Click += new System.EventHandler(this.bttnGirisYap_Click);
            // 
            // bttnIkinciAdim
            // 
            this.bttnIkinciAdim.Location = new System.Drawing.Point(316, 319);
            this.bttnIkinciAdim.Name = "bttnIkinciAdim";
            this.bttnIkinciAdim.Size = new System.Drawing.Size(171, 58);
            this.bttnIkinciAdim.TabIndex = 23;
            this.bttnIkinciAdim.Text = "Yapilan Islemler ve Cikis EKLE";
            this.bttnIkinciAdim.UseVisualStyleBackColor = true;
            this.bttnIkinciAdim.Click += new System.EventHandler(this.bttnIkinciAdim_Click);
            // 
            // bttnGeri
            // 
            this.bttnGeri.Location = new System.Drawing.Point(13, 13);
            this.bttnGeri.Name = "bttnGeri";
            this.bttnGeri.Size = new System.Drawing.Size(75, 23);
            this.bttnGeri.TabIndex = 24;
            this.bttnGeri.Text = "Geri";
            this.bttnGeri.UseVisualStyleBackColor = true;
            this.bttnGeri.Click += new System.EventHandler(this.bttnGeri_Click);
            // 
            // TamirGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnGeri);
            this.Controls.Add(this.bttnIkinciAdim);
            this.Controls.Add(this.bttnGirisYap);
            this.Controls.Add(this.IslemGirisTarihiPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlakaKutu);
            this.Controls.Add(this.label1);
            this.Name = "TamirGirisEkrani";
            this.Text = "TamirGirisEkrani";
            this.Load += new System.EventHandler(this.TamirGirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker IslemGirisTarihiPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlakaKutu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnGirisYap;
        private System.Windows.Forms.Button bttnIkinciAdim;
        private System.Windows.Forms.Button bttnGeri;
    }
}