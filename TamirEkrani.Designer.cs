namespace OtoTamir
{
    partial class frmTamir
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DegisenParcaninAdetiKutu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bttnIslemiKaydet = new System.Windows.Forms.Button();
            this.bttnTamiriBitir = new System.Windows.Forms.Button();
            this.bttnGeri = new System.Windows.Forms.Button();
            this.DegisenParcaComboBox = new System.Windows.Forms.ComboBox();
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoTamirDataSet4 = new OtoTamir.OtoTamirDataSet4();
            this.otoTamirDataSet = new OtoTamir.OtoTamirDataSet();
            this.otoTamirDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTableAdapter = new OtoTamir.OtoTamirDataSet4TableAdapters.StokTableAdapter();
            this.bttnKapat = new System.Windows.Forms.Button();
            this.DegisenParcaBirimiComboKutu = new System.Windows.Forms.ComboBox();
            this.YapilanIslemRichKutu = new System.Windows.Forms.RichTextBox();
            this.IslemCikisTarihiPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCalisanAd = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.otoTamirDataSet1 = new OtoTamir.OtoTamirDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.PlakaKutu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoTamirDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoTamirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoTamirDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoTamirDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Degisen Parca ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yapilan Islem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Degisen Parcanin Birimi";
            // 
            // DegisenParcaninAdetiKutu
            // 
            this.DegisenParcaninAdetiKutu.Location = new System.Drawing.Point(825, 172);
            this.DegisenParcaninAdetiKutu.Name = "DegisenParcaninAdetiKutu";
            this.DegisenParcaninAdetiKutu.Size = new System.Drawing.Size(100, 22);
            this.DegisenParcaninAdetiKutu.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Degisen Parcanin Miktari / Adeti";
            // 
            // bttnIslemiKaydet
            // 
            this.bttnIslemiKaydet.Location = new System.Drawing.Point(98, 487);
            this.bttnIslemiKaydet.Name = "bttnIslemiKaydet";
            this.bttnIslemiKaydet.Size = new System.Drawing.Size(171, 58);
            this.bttnIslemiKaydet.TabIndex = 14;
            this.bttnIslemiKaydet.Text = "Islemi Kaydet";
            this.bttnIslemiKaydet.UseVisualStyleBackColor = true;
            this.bttnIslemiKaydet.Click += new System.EventHandler(this.bttnIslemiKaydet_Click);
            // 
            // bttnTamiriBitir
            // 
            this.bttnTamiriBitir.Location = new System.Drawing.Point(461, 487);
            this.bttnTamiriBitir.Name = "bttnTamiriBitir";
            this.bttnTamiriBitir.Size = new System.Drawing.Size(171, 58);
            this.bttnTamiriBitir.TabIndex = 15;
            this.bttnTamiriBitir.Text = "Tamiri Bitir";
            this.bttnTamiriBitir.UseVisualStyleBackColor = true;
            this.bttnTamiriBitir.Click += new System.EventHandler(this.bttnTamiriBitir_Click);
            // 
            // bttnGeri
            // 
            this.bttnGeri.Location = new System.Drawing.Point(13, 13);
            this.bttnGeri.Name = "bttnGeri";
            this.bttnGeri.Size = new System.Drawing.Size(75, 23);
            this.bttnGeri.TabIndex = 16;
            this.bttnGeri.Text = "Geri";
            this.bttnGeri.UseVisualStyleBackColor = true;
            this.bttnGeri.Click += new System.EventHandler(this.bttnGeri_Click);
            // 
            // DegisenParcaComboBox
            // 
            this.DegisenParcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stokBindingSource, "StokAdi", true));
            this.DegisenParcaComboBox.DataSource = this.stokBindingSource;
            this.DegisenParcaComboBox.DisplayMember = "StokAdi";
            this.DegisenParcaComboBox.FormattingEnabled = true;
            this.DegisenParcaComboBox.Location = new System.Drawing.Point(179, 166);
            this.DegisenParcaComboBox.Name = "DegisenParcaComboBox";
            this.DegisenParcaComboBox.Size = new System.Drawing.Size(121, 24);
            this.DegisenParcaComboBox.TabIndex = 19;
            this.DegisenParcaComboBox.ValueMember = "StokAdi";
            // 
            // stokBindingSource
            // 
            this.stokBindingSource.DataMember = "Stok";
            this.stokBindingSource.DataSource = this.otoTamirDataSet4;
            // 
            // otoTamirDataSet4
            // 
            this.otoTamirDataSet4.DataSetName = "OtoTamirDataSet4";
            this.otoTamirDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otoTamirDataSet
            // 
            this.otoTamirDataSet.DataSetName = "OtoTamirDataSet";
            this.otoTamirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otoTamirDataSetBindingSource
            // 
            this.otoTamirDataSetBindingSource.DataSource = this.otoTamirDataSet;
            this.otoTamirDataSetBindingSource.Position = 0;
            // 
            // stokTableAdapter
            // 
            this.stokTableAdapter.ClearBeforeFill = true;
            // 
            // bttnKapat
            // 
            this.bttnKapat.Location = new System.Drawing.Point(754, 487);
            this.bttnKapat.Name = "bttnKapat";
            this.bttnKapat.Size = new System.Drawing.Size(171, 58);
            this.bttnKapat.TabIndex = 20;
            this.bttnKapat.Text = "Kapat";
            this.bttnKapat.UseVisualStyleBackColor = true;
            this.bttnKapat.Click += new System.EventHandler(this.bttnKapat_Click);
            // 
            // DegisenParcaBirimiComboKutu
            // 
            this.DegisenParcaBirimiComboKutu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stokBindingSource, "StokAdi", true));
            this.DegisenParcaBirimiComboKutu.FormattingEnabled = true;
            this.DegisenParcaBirimiComboKutu.Items.AddRange(new object[] {
            "kg",
            "m^2",
            "Adet"});
            this.DegisenParcaBirimiComboKutu.Location = new System.Drawing.Point(470, 169);
            this.DegisenParcaBirimiComboKutu.Name = "DegisenParcaBirimiComboKutu";
            this.DegisenParcaBirimiComboKutu.Size = new System.Drawing.Size(121, 24);
            this.DegisenParcaBirimiComboKutu.TabIndex = 21;
            // 
            // YapilanIslemRichKutu
            // 
            this.YapilanIslemRichKutu.Location = new System.Drawing.Point(157, 238);
            this.YapilanIslemRichKutu.Name = "YapilanIslemRichKutu";
            this.YapilanIslemRichKutu.Size = new System.Drawing.Size(746, 96);
            this.YapilanIslemRichKutu.TabIndex = 22;
            this.YapilanIslemRichKutu.Text = "";
            // 
            // IslemCikisTarihiPicker
            // 
            this.IslemCikisTarihiPicker.CustomFormat = " ";
            this.IslemCikisTarihiPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IslemCikisTarihiPicker.Location = new System.Drawing.Point(461, 395);
            this.IslemCikisTarihiPicker.Name = "IslemCikisTarihiPicker";
            this.IslemCikisTarihiPicker.Size = new System.Drawing.Size(317, 22);
            this.IslemCikisTarihiPicker.TabIndex = 24;
            this.IslemCikisTarihiPicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.IslemCikisTarihiPicker.ValueChanged += new System.EventHandler(this.IslemCikisTarihiPicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Islem Cikis Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(775, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Isim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(775, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Kullanici Adi";
            // 
            // lblCalisanAd
            // 
            this.lblCalisanAd.AutoSize = true;
            this.lblCalisanAd.Location = new System.Drawing.Point(879, 59);
            this.lblCalisanAd.Name = "lblCalisanAd";
            this.lblCalisanAd.Size = new System.Drawing.Size(46, 17);
            this.lblCalisanAd.TabIndex = 26;
            this.lblCalisanAd.Text = "label2";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(879, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 17);
            this.lblUsername.TabIndex = 25;
            this.lblUsername.Text = "label1";
            // 
            // otoTamirDataSet1
            // 
            this.otoTamirDataSet1.DataSetName = "OtoTamirDataSet";
            this.otoTamirDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // PlakaKutu
            // 
            this.PlakaKutu.Location = new System.Drawing.Point(491, 90);
            this.PlakaKutu.Name = "PlakaKutu";
            this.PlakaKutu.Size = new System.Drawing.Size(100, 22);
            this.PlakaKutu.TabIndex = 1;
            // 
            // frmTamir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 576);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCalisanAd);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.IslemCikisTarihiPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YapilanIslemRichKutu);
            this.Controls.Add(this.DegisenParcaBirimiComboKutu);
            this.Controls.Add(this.bttnKapat);
            this.Controls.Add(this.DegisenParcaComboBox);
            this.Controls.Add(this.bttnGeri);
            this.Controls.Add(this.bttnTamiriBitir);
            this.Controls.Add(this.bttnIslemiKaydet);
            this.Controls.Add(this.DegisenParcaninAdetiKutu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlakaKutu);
            this.Controls.Add(this.label1);
            this.Name = "frmTamir";
            this.Text = "Tamir";
            this.Load += new System.EventHandler(this.frmTamir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoTamirDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoTamirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoTamirDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoTamirDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DegisenParcaninAdetiKutu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttnIslemiKaydet;
        private System.Windows.Forms.Button bttnTamiriBitir;
        private System.Windows.Forms.Button bttnGeri;
        private System.Windows.Forms.ComboBox DegisenParcaComboBox;
        private System.Windows.Forms.BindingSource otoTamirDataSetBindingSource;
        private OtoTamirDataSet otoTamirDataSet;
        private OtoTamirDataSet4 otoTamirDataSet4;
        private System.Windows.Forms.BindingSource stokBindingSource;
        private OtoTamirDataSet4TableAdapters.StokTableAdapter stokTableAdapter;
        private System.Windows.Forms.Button bttnKapat;
        private System.Windows.Forms.ComboBox DegisenParcaBirimiComboKutu;
        private System.Windows.Forms.RichTextBox YapilanIslemRichKutu;
        private System.Windows.Forms.DateTimePicker IslemCikisTarihiPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCalisanAd;
        private System.Windows.Forms.Label lblUsername;
        private OtoTamirDataSet otoTamirDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlakaKutu;
    }
}