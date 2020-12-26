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
    public partial class frmAracTeslim : Form
    {
        public frmAracTeslim()
        {
            InitializeComponent();
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            string TeslimTarihiString = (TeslimTarihiPicker.Value).ToString();

            if (PlakaKutu.Text != "" && TeslimTarihiString != "1.01.2020 00:00:00")
            {
                string plate = PlakaKutu.Text;
                DateTime customerDeliveryDate = TeslimTarihiPicker.Value;

                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03N98IC\NIRAEVSQL;Initial Catalog=OtoTamir;Persist Security Info=True;User ID=sa;Password=nbrmtmt1234"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("getAracTeslim_sp", conn); // getAracKabulTeslim_sp sini getAracKabul_sp ile degistirdim
                    cmd.CommandType = CommandType.StoredProcedure;           // Teslim tarihini sp de ve burda commente aldim bunlar sayesinde teslim tarihi giriste null girildi
                                                                             // Teslim tarihi kutusu 1.01.2020 00:00:00 ise bunu database e atma ve alttaki kodu kullanma, tarih bundan farkli ise alttaki kodu kullan ve teslim tarihini database e al 
                                                                             // cmd.Parameters.Add("@TeslimTarihi", SqlDbType.DateTime).Value = customerDeliveryDate;
                                                                             // sp yazip bu plakaya ait aracin teslim tarihine ekle 

                    cmd.Parameters.Add("@Plaka", SqlDbType.NVarChar).Value = plate;
                    cmd.Parameters.Add("@TeslimTarihi", SqlDbType.DateTime).Value = customerDeliveryDate;

                    cmd.ExecuteNonQuery();

                    bttnKaydet.Enabled = false;

               
                    MessageBox.Show("Teslim Tarihi Basariyla Kaydedildi");
                }
            }
            else if (PlakaKutu.Text == "" && TeslimTarihiString != "1.01.2020 00:00:00")
            {
                MessageBox.Show("Lutfen Plakayi giriniz");
            }
            else if (PlakaKutu.Text != "" && TeslimTarihiString == "1.01.2020 00:00:00")
            {
                MessageBox.Show("Lutfen Teslim Tarihini giriniz");
            }
            else
            {
                MessageBox.Show("Tum Alanlarin Doldurulmasi Zorunludur");
            }

        }

        private void bttnYeniTeslim_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAracTeslim ss = new frmAracTeslim();
            ss.Show();
        }

        private void bttnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAracKabulTeslim ss = new frmAracKabulTeslim();
            ss.Show();
        }

        private void bttnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeslimTarihiPicker_ValueChanged(object sender, EventArgs e)
        {
            TeslimTarihiPicker.CustomFormat = "dd/MM/yyyy";
        }

        private void frmAracTeslim_Load(object sender, EventArgs e)
        {

        }
    }
}
