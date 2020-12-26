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
    public partial class frmCalisanTanimlama : Form
    {
        public frmCalisanTanimlama()
        {
            InitializeComponent();
        }

        private void CalisanAdKutu_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnCalisanEkle_Click(object sender, EventArgs e)
        {
            //CalisanTipiKutu.Text => CalisanTipiComboBox.Text  
        
            if (CalisanTipiComboBox.Text != "" && CalisanAdKutu.Text != "" && CalisanSoyadKutu.Text != "" && KullaniciAdiKutu.Text != "" && SifreKutu.Text != "")
            {
                int calisanTipi=7;

                if (CalisanTipiComboBox.Text == "Admin")
                {
                    calisanTipi = 0;
                }
                else if (CalisanTipiComboBox.Text == "Servis Elemani")
                {
                    calisanTipi = 1;
                }
                else if (CalisanTipiComboBox.Text == "Stok Elemani")
                {
                    calisanTipi = 2;
                }
                else if (CalisanTipiComboBox.Text == "Kaporta Ustasi")
                {
                    calisanTipi = 3;
                }
                else if (CalisanTipiComboBox.Text == "Boya Ustasi")
                {
                    calisanTipi = 4;
                }
                else if (CalisanTipiComboBox.Text == "Motor Ustasi")
                {
                    calisanTipi = 5;
                }

                string workerName = CalisanAdKutu.Text;
                string workerSurname = CalisanSoyadKutu.Text;
                string username = KullaniciAdiKutu.Text;
                string password = SifreKutu.Text;
              

                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03N98IC\NIRAEVSQL;Initial Catalog=OtoTamir;Persist Security Info=True;User ID=sa;Password=nbrmtmt1234"))
                {
                    if (calisanTipi == 7)
                    {
                        MessageBox.Show("Lutfen Calisan Tipini Seciniz");
                    }
                    else
                    {


                        conn.Open();

                        SqlCommand cmd2 = new SqlCommand("getCalisanTanimla_sp", conn);
                        cmd2.CommandType = CommandType.StoredProcedure;

                        cmd2.Parameters.Add("@CalisanAd", SqlDbType.NVarChar).Value = workerName;
                        cmd2.Parameters.Add("@CalisanSoyad", SqlDbType.NVarChar).Value = workerSurname;
                        cmd2.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = username;
                        cmd2.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = password;
                        cmd2.Parameters.Add("@CalisanTipi", SqlDbType.Int).Value = calisanTipi;


                        cmd2.ExecuteNonQuery();

                        bttnCalisanEkle.Enabled = false;

                        MessageBox.Show("Calisan Basariyla Kaydedildi");
                    }

                }

            }
            else if (CalisanTipiComboBox.Text == "" || CalisanAdKutu.Text == "" || CalisanSoyadKutu.Text == "" || KullaniciAdiKutu.Text == "" || SifreKutu.Text == "")
            {
                if (CalisanTipiComboBox.Text != "" && CalisanAdKutu.Text == "" && CalisanSoyadKutu.Text != "" && KullaniciAdiKutu.Text != "" && SifreKutu.Text != "")
                {
                    MessageBox.Show("Lutfen Calisan Adini giriniz");
                }
                else if (CalisanTipiComboBox.Text != "" && CalisanAdKutu.Text != "" && CalisanSoyadKutu.Text == "" && KullaniciAdiKutu.Text != "" && SifreKutu.Text != "")
                {
                    MessageBox.Show("Lutfen Soy Adini giriniz");
                }
                else if (CalisanTipiComboBox.Text != "" && CalisanAdKutu.Text != "" && CalisanSoyadKutu.Text != "" && KullaniciAdiKutu.Text == "" && SifreKutu.Text != "")
                {
                    MessageBox.Show("Lutfen Kullanici Adini giriniz");
                }
                else if (CalisanTipiComboBox.Text != "" && CalisanAdKutu.Text != "" && CalisanSoyadKutu.Text != "" && KullaniciAdiKutu.Text != "" && SifreKutu.Text == "")
                {
                    MessageBox.Show("Lutfen Sifrenizi giriniz");
                }
                else if (CalisanTipiComboBox.Text == "" && CalisanAdKutu.Text != "" && CalisanSoyadKutu.Text != "" && KullaniciAdiKutu.Text != "" && SifreKutu.Text != "")
                {
                    MessageBox.Show("Lutfen Calisan Tipini giriniz");
                }
                else
                {
                    MessageBox.Show("Lutfen tum alanlari eksiksiz doldurunuz");
                }



            }

        }

        private void bttnYeniCalisanEkle_Click(object sender, EventArgs e)
                    {
                        this.Hide();
                        frmCalisanTanimlama ss = new frmCalisanTanimlama();
                        ss.Show();
                    }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminGecis ss = new frmAdminGecis();
            ss.Show();
  
        }

        private void bttnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalisanTanimlama_Load(object sender, EventArgs e)
        {
            lblCalisanAd.Text = global.name + " " + global.surname;
            lblUsername.Text = global.username;
        }

        private void CalisanTipiKutu_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
        }
    


            

        
    