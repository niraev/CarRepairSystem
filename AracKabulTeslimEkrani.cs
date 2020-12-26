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
    public partial class frmAracKabulTeslim : Form
    {
        public frmAracKabulTeslim()
        {
            InitializeComponent();
        }

        private void bttnGeri_Click(object sender, EventArgs e)
        {
            if (Global.yetkiTipi==1)
            {
                this.Hide();
                frmServisElemaniGecis ss = new frmServisElemaniGecis();
                ss.Show();
            }
            else if (Global.yetkiTipi == 0)
            {
                this.Hide();
                frmAdminGecis ss = new frmAdminGecis();
                ss.Show();
            }
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            //Kabul yapildiktan sonra teslim icin guncelleme butonu koy ve ayni palakaya sahip araci guncelle. 
            //Teslim tarihi commentlerini ac
            // database i okudugumuz yerdeki commentlere bak 

            //teslim tarihi bos gecilebilir fakat diger degiskenler bos gecilemez
            //teslim tarihini 00.00.00 00:00 yapmayi dene 
            

            string GirisTarihiString = (GirisTarihiPicker.Value).ToString();
            

            if (PlakaKutu.Text != "" && MarkaKutu.Text != "" && ModelKutu.Text != "" && MusteriAdKutu.Text != "" && MusteriSoyadKutu.Text != "" && MusteriGSMKutu.Text != "" && GirisTarihiString != "1.01.2020 00:00:00")
            {
                
                string plate = PlakaKutu.Text;
                string brand = MarkaKutu.Text;
                string model = ModelKutu.Text;
                string customerName = MusteriAdKutu.Text;
                string customerSurname = MusteriSoyadKutu.Text;
                string customerGSM = MusteriGSMKutu.Text;     
                DateTime customerEntryDate = GirisTarihiPicker.Value;
               

                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03N98IC\NIRAEVSQL;Initial Catalog=OtoTamir;Persist Security Info=True;User ID=sa;Password=nbrmtmt1234"))
                {
                    conn.Open();

                    
                        SqlCommand cmd = new SqlCommand("getAracKabul_sp", conn); // getAracKabulTeslim_sp sini getAracKabul_sp ile degistirdim
                        cmd.CommandType = CommandType.StoredProcedure;           // Teslim tarihini sp de ve burda commente aldim bunlar sayesinde teslim tarihi giriste null girildi
                                                                                 // Teslim tarihi kutusu 1.01.2020 00:00:00 ise bunu database e atma ve alttaki kodu kullanma, tarih bundan farkli ise alttaki kodu kullan ve teslim tarihini database e al 
                                                                                 // cmd.Parameters.Add("@TeslimTarihi", SqlDbType.DateTime).Value = customerDeliveryDate;
                                                                                 // sp yazip bu plakaya ait aracin teslim tarihine ekle 

                        cmd.Parameters.Add("@Plaka", SqlDbType.NVarChar).Value = plate;
                        cmd.Parameters.Add("@Marka", SqlDbType.NVarChar).Value = brand;
                        cmd.Parameters.Add("@Model", SqlDbType.NVarChar).Value = model;
                        cmd.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = customerName;
                        cmd.Parameters.Add("@Soyad", SqlDbType.NVarChar).Value = customerSurname;
                        cmd.Parameters.Add("@GSM", SqlDbType.NVarChar).Value = customerGSM;
                        cmd.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = customerEntryDate;
                       
                        cmd.ExecuteNonQuery();

                        bttnKaydet.Enabled = false;

                        //MessageBox.Show("Teslim Tarihi Bos Kaydedildi");
                        MessageBox.Show("Arac Basariyla Kaydedildi");
                }

            }
            else if (PlakaKutu.Text == "" || MarkaKutu.Text == "" || ModelKutu.Text == "" || MusteriAdKutu.Text == "" || MusteriSoyadKutu.Text == "" || MusteriGSMKutu.Text == "" || GirisTarihiString == "1.01.2020 00:00:00")
            {
                if (PlakaKutu.Text == "" && MarkaKutu.Text != "" && ModelKutu.Text != "" && MusteriAdKutu.Text != "" && MusteriSoyadKutu.Text != "" && MusteriGSMKutu.Text != "" && GirisTarihiString != "1.01.2020 00:00:00")
                {
                    MessageBox.Show("Lutfen Plakayi giriniz");
                }
                else if (PlakaKutu.Text != "" && MarkaKutu.Text == "" && ModelKutu.Text != "" && MusteriAdKutu.Text != "" && MusteriSoyadKutu.Text != "" && MusteriGSMKutu.Text != "" && GirisTarihiString != "1.01.2020 00:00:00")
                {
                    MessageBox.Show("Lutfen Marka Adini giriniz");
                }
                else if (PlakaKutu.Text != "" && MarkaKutu.Text != "" && ModelKutu.Text == "" && MusteriAdKutu.Text != "" && MusteriSoyadKutu.Text != "" && MusteriGSMKutu.Text != "" && GirisTarihiString != "1.01.2020 00:00:00")
                {
                    MessageBox.Show("Lutfen Model giriniz");
                }
                else if (PlakaKutu.Text != "" && MarkaKutu.Text != "" && ModelKutu.Text != "" && MusteriAdKutu.Text == "" && MusteriSoyadKutu.Text != "" && MusteriGSMKutu.Text != "" && GirisTarihiString != "1.01.2020 00:00:00")
                {
                    MessageBox.Show("Lutfen Musteri Adi giriniz");
                }
                else if (PlakaKutu.Text != "" && MarkaKutu.Text != "" && ModelKutu.Text != "" && MusteriAdKutu.Text != "" && MusteriSoyadKutu.Text == "" && MusteriGSMKutu.Text != "" && GirisTarihiString != "1.01.2020 00:00:00")
                {
                    MessageBox.Show("Lutfen Musteri Soyadi giriniz");
                }
                else if (PlakaKutu.Text != "" && MarkaKutu.Text != "" && ModelKutu.Text != "" && MusteriAdKutu.Text != "" && MusteriSoyadKutu.Text != "" && MusteriGSMKutu.Text == "" && GirisTarihiString != "1.01.2020 00:00:00")
                {
                    MessageBox.Show("Lutfen Musteri GSM giriniz");
                }
                else if (PlakaKutu.Text != "" && MarkaKutu.Text != "" && ModelKutu.Text != "" && MusteriAdKutu.Text != "" && MusteriSoyadKutu.Text != "" && MusteriGSMKutu.Text != "" && GirisTarihiString == "1.01.2020 00:00:00")
                {
                    MessageBox.Show("Lutfen Giris Tarihi giriniz");
                }
                else
                {
                    MessageBox.Show("Arac Kabul Icin Teslim Tarihi Haric Tum Alanlarin Doldurulmasi Zorunludur");
                }
            }
        }
        
        private void GirisTarihiPicker_ValueChanged(object sender, EventArgs e)
        {
            GirisTarihiPicker.CustomFormat = "dd/MM/yyyy hh:ss";

        }

        //private void TeslimTarihiPicker_ValueChanged(object sender, EventArgs e)
        //{
        //    TeslimTarihiPicker.CustomFormat = "dd/MM/yyyy";
        //}

        private void GirisTarihiPicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                GirisTarihiPicker.CustomFormat = " ";
            }
        }

        //private void TeslimTarihiPicker_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
        //    {
        //        TeslimTarihiPicker.CustomFormat = " ";
        //    }
        //}

        private void bttnYeniKabulTeslim_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAracKabulTeslim ss = new frmAracKabulTeslim();
            ss.Show();
            
        }

        private void PlakaKutu_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriGSMKutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void bttnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAracKabulTeslim_Load(object sender, EventArgs e)
        {
            lblCalisanAd.Text = global.name + " " + global.surname;
            lblUsername.Text = global.username;
        }

        private void bttnAracTeslim_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAracTeslim ss = new frmAracTeslim();
            ss.Show();
        }
    }
}
