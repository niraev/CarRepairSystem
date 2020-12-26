namespace OtoTamir
{
    partial class frmAracTeslim
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
            this.TeslimTarihiPicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlakaKutu = new System.Windows.Forms.TextBox();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnYeniTeslim = new System.Windows.Forms.Button();
            this.bttnGeri = new System.Windows.Forms.Button();
            this.bttnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeslimTarihiPicker
            // 
            this.TeslimTarihiPicker.CustomFormat = " ";
            this.TeslimTarihiPicker.Location = new System.Drawing.Point(337, 196);
            this.TeslimTarihiPicker.Name = "TeslimTarihiPicker";
            this.TeslimTarihiPicker.Size = new System.Drawing.Size(213, 22);
            this.TeslimTarihiPicker.TabIndex = 21;
            this.TeslimTarihiPicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.TeslimTarihiPicker.ValueChanged += new System.EventHandler(this.TeslimTarihiPicker_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Teslim Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Plaka";
            // 
            // PlakaKutu
            // 
            this.PlakaKutu.Location = new System.Drawing.Point(389, 137);
            this.PlakaKutu.Name = "PlakaKutu";
            this.PlakaKutu.Size = new System.Drawing.Size(100, 22);
            this.PlakaKutu.TabIndex = 22;
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(254, 272);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(100, 57);
            this.bttnKaydet.TabIndex = 24;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            this.bttnKaydet.Click += new System.EventHandler(this.bttnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(386, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Arac Teslim";
            // 
            // bttnYeniTeslim
            // 
            this.bttnYeniTeslim.Location = new System.Drawing.Point(398, 272);
            this.bttnYeniTeslim.Name = "bttnYeniTeslim";
            this.bttnYeniTeslim.Size = new System.Drawing.Size(100, 57);
            this.bttnYeniTeslim.TabIndex = 26;
            this.bttnYeniTeslim.Text = "Yeni Teslim";
            this.bttnYeniTeslim.UseVisualStyleBackColor = true;
            this.bttnYeniTeslim.Click += new System.EventHandler(this.bttnYeniTeslim_Click);
            // 
            // bttnGeri
            // 
            this.bttnGeri.Location = new System.Drawing.Point(13, 13);
            this.bttnGeri.Name = "bttnGeri";
            this.bttnGeri.Size = new System.Drawing.Size(75, 23);
            this.bttnGeri.TabIndex = 27;
            this.bttnGeri.Text = "Geri";
            this.bttnGeri.UseVisualStyleBackColor = true;
            this.bttnGeri.Click += new System.EventHandler(this.bttnGeri_Click);
            // 
            // bttnKapat
            // 
            this.bttnKapat.Location = new System.Drawing.Point(541, 272);
            this.bttnKapat.Name = "bttnKapat";
            this.bttnKapat.Size = new System.Drawing.Size(100, 57);
            this.bttnKapat.TabIndex = 28;
            this.bttnKapat.Text = "Kapat";
            this.bttnKapat.UseVisualStyleBackColor = true;
            this.bttnKapat.Click += new System.EventHandler(this.bttnKapat_Click);
            // 
            // frmAracTeslim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnKapat);
            this.Controls.Add(this.bttnGeri);
            this.Controls.Add(this.bttnYeniTeslim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlakaKutu);
            this.Controls.Add(this.TeslimTarihiPicker);
            this.Controls.Add(this.label8);
            this.Name = "frmAracTeslim";
            this.Text = "Arac Teslim Ekrani";
            this.Load += new System.EventHandler(this.frmAracTeslim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TeslimTarihiPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlakaKutu;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnYeniTeslim;
        private System.Windows.Forms.Button bttnGeri;
        private System.Windows.Forms.Button bttnKapat;
    }
}