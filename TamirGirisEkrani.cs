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
    public partial class TamirGirisEkrani : Form
    {
        public TamirGirisEkrani()
        {
            InitializeComponent();
        }

        private void bttnGirisYap_Click(object sender, EventArgs e)
        {
            string GirisTarihiString = (IslemGirisTarihiPicker.Value).ToString();
            string plate = PlakaKutu.Text;
                                                                      // database e kaydetmek icin string al hesap yapicagin zaman decimala cevir
                                                                      // decimal changedPieceNumber = Convert.ToDecimal(DegisenParcaninAdetiKutu.Text);
                                                                       //DateTime FinishDate = IslemCikisTarihiPicker.Value

            global.std = IslemGirisTarihiPicker.Value;


            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03N98IC\NIRAEVSQL;Initial Catalog=OtoTamir;Persist Security Info=True;User ID=sa;Password=nbrmtmt1234"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("getTamir_sp", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (PlakaKutu.Text != " " && GirisTarihiString != "1.01.2020 00:00:00")
                {

                    cmd.Parameters.Add("@Plaka", SqlDbType.NVarChar).Value = plate; //ServisFormu
                    cmd.Parameters.Add("@GirisTarihi", SqlDbType.DateTime).Value = IslemGirisTarihiPicker.Value; //ServisFormu

                    //using (SqlDataReader rdr = cmd.ExecuteReader())
                    //{
                    //    while (rdr.Read())
                    //    {
                    //        string id = rdr["Id"].ToString();
                    //        cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = id;
                    //    }
                    //}

                }
                else if (PlakaKutu.Text == " " && GirisTarihiString == "1.01.2020 00:00:00")
                {
                    MessageBox.Show("Lutfen tum alanlari doldurun");
                }


                cmd.ExecuteNonQuery();
                //cmd.BeginExecuteNonQuery();
                bttnGirisYap.Enabled = false;

            }
        }

        private void bttnIkinciAdim_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTamir ss = new frmTamir();
            ss.Show();
        }

        private void TamirGirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void IslemGirisTarihiPicker_ValueChanged(object sender, EventArgs e)
        {
            IslemGirisTarihiPicker.CustomFormat = "dd/MM/yyyy hh:ss";
        }

        private void bttnGeri_Click(object sender, EventArgs e)
        {
            if (Global.yetkiTipi == 3)
            {
                this.Hide();
                frmUstaGecis ss = new frmUstaGecis();
                ss.Show();
            }
            else if (Global.yetkiTipi == 0)
            {
                this.Hide();
                frmAdminGecis ss = new frmAdminGecis();
                ss.Show();
            }
            else if (Global.yetkiTipi == 4)
            {
                this.Hide();
                frmUstaGecis ss = new frmUstaGecis();
                ss.Show();
            }
            else if (Global.yetkiTipi == 5)
            {
                this.Hide();
                frmUstaGecis ss = new frmUstaGecis();
                ss.Show();
            }
        }
    }
}
