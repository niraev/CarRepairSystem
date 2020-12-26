using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace OtoTamir
{
    public partial class frmTamir : Form
    {
        public frmTamir()
        {
            InitializeComponent();
        }

        private void bttnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            TamirGirisEkrani ss = new TamirGirisEkrani();
            ss.Show();


        }

        private void frmTamir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otoTamirDataSet4.Stok' table. You can move, or remove it, as needed.
            this.stokTableAdapter.Fill(this.otoTamirDataSet4.Stok);
            lblCalisanAd.Text = global.name + " " + global.surname;
            lblUsername.Text = global.username;

        }

        private void bttnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnTamiriBitir_Click(object sender, EventArgs e)
        {

        }

        private void bttnIslemiKaydet_Click(object sender, EventArgs e)
        {
            string plate = PlakaKutu.Text;
            string changedPieceName = DegisenParcaComboBox.Text;
            string changedPieceUnit = DegisenParcaBirimiComboKutu.Text;
            string changedPieceNumber = DegisenParcaninAdetiKutu.Text;
            string process = YapilanIslemRichKutu.Text;

            string CikisTarihiString = (IslemCikisTarihiPicker.Value).ToString();

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03N98IC\NIRAEVSQL;Initial Catalog=OtoTamir;Persist Security Info=True;User ID=sa;Password=nbrmtmt1234"))
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("getStok_sp", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@kullanilanStokAdi", SqlDbType.NVarChar).Value = changedPieceName;

                using (SqlDataReader rdr1 = cmd.ExecuteReader())
                {
                    while (rdr1.Read())
                    {
                        global.kullanilanStokSatisFiyati = rdr1["SatisFiyati"].ToString();
                        global.kullanilanStokAlisFiyati = rdr1["AlisFiyati"].ToString();

                        //cmd1.ExecuteNonQuery();

                        //fiyatlari decimal yapmayi dene. 

                    }

                }

                cmd.ExecuteNonQuery();
            }




            if (PlakaKutu.Text != "" && CikisTarihiString != "1.01.2020 00:00:00" && DegisenParcaComboBox.Text != " " && DegisenParcaBirimiComboKutu.Text != " " && DegisenParcaninAdetiKutu.Text != " " && IslemCikisTarihiPicker.Text != " " && YapilanIslemRichKutu.Text != " ")
            {
                plate = PlakaKutu.Text;


                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03N98IC\NIRAEVSQL;Initial Catalog=OtoTamir;Persist Security Info=True;User ID=sa;Password=nbrmtmt1234"))
                {
                    conn.Open();

                    //SqlCommand cmd = new SqlCommand("getIslemCikis_sp", conn); // getAracKabulTeslim_sp sini getAracKabul_sp ile degistirdim
                    //cmd.CommandType = CommandType.StoredProcedure;           // Teslim tarihini sp de ve burda commente aldim bunlar sayesinde teslim tarihi giriste null girildi
                    //                                                         // Teslim tarihi kutusu 1.01.2020 00:00:00 ise bunu database e atma ve alttaki kodu kullanma, tarih bundan farkli ise alttaki kodu kullan ve teslim tarihini database e al 
                    //                                                         // cmd.Parameters.Add("@TeslimTarihi", SqlDbType.DateTime).Value = customerDeliveryDate;
                    //                                                         // sp yazip bu plakaya ait aracin teslim tarihine ekle 

                    //cmd.Parameters.Add("@Plaka", SqlDbType.NVarChar).Value = plate;
                    //cmd.Parameters.Add("@islemCikisTarihi", SqlDbType.DateTime).Value = IslemCikisTarihiPicker.Value;

                    //cmd.ExecuteNonQuery();



                    SqlCommand cmd1 = new SqlCommand("getTamirGuncel_sp", conn);
                    cmd1.CommandType = CommandType.StoredProcedure;


                    SqlCommand cmd2 = new SqlCommand("getServisFormu_sp", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.Add("@Plaka", SqlDbType.NVarChar).Value = plate;

                    cmd2.ExecuteNonQuery();

                    using (SqlDataReader rdr = cmd2.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            global.CikisTarihi = rdr["CikisTarihi"].ToString();
                            global.YapilanIslem = rdr["YapilanIslem"].ToString();
                            global.Tutar = rdr["Tutar"].ToString();
                            global.id = rdr["Id"].ToString();
                        }

                    }

                        if (global.CikisTarihi == "" && global.YapilanIslem == "" && global.Tutar == "")
                        {


                            cmd1.Parameters.Add("@Id", SqlDbType.NVarChar).Value = global.id;
                            cmd1.Parameters.Add("@Plaka", SqlDbType.NVarChar).Value = plate; //ServisFormu
                            cmd1.Parameters.Add("@kullanilanStokAdi", SqlDbType.NVarChar).Value = changedPieceName; //ServisFormuMalzemeler
                            cmd1.Parameters.Add("@kullanilanStokBirimi", SqlDbType.NVarChar).Value = changedPieceUnit; //ServisFormuMalzemeler
                            cmd1.Parameters.Add("@kullanilanStokMiktari", SqlDbType.NVarChar).Value = changedPieceNumber; //ServisFormuMalzemeler

                            cmd1.Parameters.Add("@CikisTarihi", SqlDbType.DateTime).Value = IslemCikisTarihiPicker.Value; //ServisFromu
                            cmd1.Parameters.Add("@YapilanIslem", SqlDbType.NVarChar).Value = process; //Servis Formu 

                            cmd1.Parameters.Add("@kullanilanStokAlisFiyati", SqlDbType.Float).Value = global.kullanilanStokAlisFiyati;
                            cmd1.Parameters.Add("@kullanilanStokSatisFiyati", SqlDbType.Float).Value = global.kullanilanStokSatisFiyati;
                            cmd1.Parameters.Add("@kullanilanStokToplamFiyat", SqlDbType.Float).Value = ((Convert.ToDecimal(changedPieceNumber)) * (Convert.ToDecimal(global.kullanilanStokSatisFiyati)));


                            

                            decimal tutar = ((Convert.ToDecimal(changedPieceNumber)) * (Convert.ToDecimal(global.kullanilanStokSatisFiyati)));

                            global.edt = IslemCikisTarihiPicker.Value;

                            TimeSpan ts = global.edt - global.std;


                            global.days = ts.Days;
                            global.hours = ts.Hours;

                            if (Global.yetkiTipi == 3) // kaporta ustasi
                            {
                                cmd1.Parameters.Add("@Tutar", SqlDbType.Float).Value = ((9 * global.hours) + (100 * global.days) + tutar);

                            }
                            else if (Global.yetkiTipi == 4) //boya ustasi
                            {
                                cmd1.Parameters.Add("@Tutar", SqlDbType.Float).Value = ((8 * global.hours) + (90 * global.days) + tutar);

                            }
                            else if (Global.yetkiTipi == 5) // motor ustasi 
                            {
                                cmd1.Parameters.Add("@Tutar", SqlDbType.Float).Value = ((10 * global.hours) + (150 * global.days) + tutar);


                            }
                            else if (Global.yetkiTipi == 0) // admin 
                            {
                                MessageBox.Show("Admin Tarafindan Yapilan Islemlerde Iscilik Hesaplanmaz");
                                cmd1.Parameters.Add("@Tutar", SqlDbType.Float).Value = tutar;

                            }

                            

                            bttnIslemiKaydet.Enabled = false;

                            MessageBox.Show("Arac Basariyla Kaydedildi");


                            //cmd1.BeginExecuteNonQuery();
                        

                    }
                    cmd1.ExecuteNonQuery();

                }
            }
            else if (PlakaKutu.Text == "" && CikisTarihiString != "1.01.2020 00:00:00" && DegisenParcaComboBox.Text != " " && DegisenParcaBirimiComboKutu.Text != " " && DegisenParcaninAdetiKutu.Text != " " && IslemCikisTarihiPicker.Text != " " && YapilanIslemRichKutu.Text != " ")

            {
                MessageBox.Show("Lutfen Palakayi Giriniz");
            }
            else if (PlakaKutu.Text != "" && CikisTarihiString != "1.01.2020 00:00:00" && DegisenParcaComboBox.Text != " " && DegisenParcaBirimiComboKutu.Text != " " && DegisenParcaninAdetiKutu.Text != " " && IslemCikisTarihiPicker.Text != " " && YapilanIslemRichKutu.Text != " ")

            {
                MessageBox.Show("Cikis Tarihini Giriniz");
            }
            else if (PlakaKutu.Text != "" && CikisTarihiString != "1.01.2020 00:00:00" && DegisenParcaComboBox.Text == " " && DegisenParcaBirimiComboKutu.Text != " " && DegisenParcaninAdetiKutu.Text != " " && IslemCikisTarihiPicker.Text != " " && YapilanIslemRichKutu.Text != " ")

            {
                MessageBox.Show("Degisen Parcayi Seciniz");
            }
            else if (PlakaKutu.Text != "" && CikisTarihiString != "1.01.2020 00:00:00" && DegisenParcaComboBox.Text != " " && DegisenParcaBirimiComboKutu.Text == " " && DegisenParcaninAdetiKutu.Text != " " && IslemCikisTarihiPicker.Text != " " && YapilanIslemRichKutu.Text != " ")

            {
                MessageBox.Show("Lutfen Parca Birimini giriniz");
            }
            else if (PlakaKutu.Text != "" && CikisTarihiString != "1.01.2020 00:00:00" && DegisenParcaComboBox.Text != " " && DegisenParcaBirimiComboKutu.Text != " " && DegisenParcaninAdetiKutu.Text == " " && IslemCikisTarihiPicker.Text != " " && YapilanIslemRichKutu.Text != " ")

            {
                MessageBox.Show("Lutfen Degisen Parca Adetini Giriniz");
            }
          
        }

        private void IslemGirisTarihiPicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void IslemCikisTarihiPicker_ValueChanged(object sender, EventArgs e)
        {
            IslemCikisTarihiPicker.CustomFormat = "dd/MM/yyyy hh:ss";
        }
    }
}
