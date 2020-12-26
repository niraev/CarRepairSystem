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
    public partial class frmStokKarti : Form
    {
        public frmStokKarti()
        {
            InitializeComponent();
        }

        private void bttnGeri_Click(object sender, EventArgs e)
        {
            if (Global.yetkiTipi == 0)
            {
                this.Hide();
                frmAdminGecis ss = new frmAdminGecis();
                ss.Show();
            }
            else if (Global.yetkiTipi == 2)
            {
                this.Hide();
                frmLogin ss = new frmLogin();
                ss.Show();
            }
        }

        private void bttnYeniStokKaydi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStokKarti ss = new frmStokKarti();
            ss.Show(); 
        }

        private void bttnEkle_Click(object sender, EventArgs e)
        {

            if (StokKoduKutu.Text != "" && StokAdiKutu.Text != "" && StokMiktariKutu.Text != "" && StokBirimiComboKutu.Text != "" && AlisFiyatiKutu.Text != "" && SatisFiyatiKutu.Text != "")
            {

                string stokCode = StokKoduKutu.Text;
                string stokName = StokAdiKutu.Text;
                string stokPrice = StokMiktariKutu.Text;
                string stokUnit = StokBirimiComboKutu.Text; //kg m2 adet 
                string stokBuyingAmount = AlisFiyatiKutu.Text;
                string stokSellingAmount = SatisFiyatiKutu.Text;
                //decimal stokBuyingAmount = Convert.ToDecimal(AlisFiyatiKutu.Text);

                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03N98IC\NIRAEVSQL;Initial Catalog=OtoTamir;Persist Security Info=True;User ID=sa;Password=nbrmtmt1234"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("getStokEkle_sp", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@StokKodu", SqlDbType.NVarChar).Value = stokCode;
                    cmd.Parameters.Add("@StokAdi", SqlDbType.NVarChar).Value = stokName;
                    cmd.Parameters.Add("@StokAdeti", SqlDbType.NVarChar).Value = stokPrice;
                    cmd.Parameters.Add("@StokBirimi", SqlDbType.NVarChar).Value = stokUnit;
                    cmd.Parameters.Add("@AlisFiyati", SqlDbType.NVarChar).Value = stokBuyingAmount;
                    cmd.Parameters.Add("@SatisFiyati", SqlDbType.NVarChar).Value = stokSellingAmount;


                    cmd.ExecuteNonQuery();

                    bttnEkle.Enabled = false;

                    MessageBox.Show("Stok Basariyla Kaydedildi");
                }
            }
            else if (StokKoduKutu.Text == "" || StokAdiKutu.Text == "" || StokMiktariKutu.Text == "" || StokBirimiComboKutu.Text == "" || AlisFiyatiKutu.Text == "" || SatisFiyatiKutu.Text == "")
            {
                if (StokKoduKutu.Text == "" && StokAdiKutu.Text != "" && StokMiktariKutu.Text != "" && StokBirimiComboKutu.Text != "" && AlisFiyatiKutu.Text != "" && SatisFiyatiKutu.Text != "")
                {
                    MessageBox.Show("Lutfen Stok Kodunu giriniz");
                }
                else if (StokKoduKutu.Text != "" && StokAdiKutu.Text == "" && StokMiktariKutu.Text != "" && StokBirimiComboKutu.Text != "" && AlisFiyatiKutu.Text != "" && SatisFiyatiKutu.Text != "")
                {
                    MessageBox.Show("Lutfen Stok Adini giriniz");
                }
                else if (StokKoduKutu.Text != "" && StokAdiKutu.Text != "" && StokMiktariKutu.Text == "" && StokBirimiComboKutu.Text != "" && AlisFiyatiKutu.Text != "" && SatisFiyatiKutu.Text != "")
                {
                    MessageBox.Show("Lutfen Stok Miktari giriniz");
                }
                else if (StokKoduKutu.Text != "" && StokAdiKutu.Text != "" && StokMiktariKutu.Text != "" && StokBirimiComboKutu.Text == "" && AlisFiyatiKutu.Text != "" && SatisFiyatiKutu.Text != "")
                {
                    MessageBox.Show("Lutfen Stok Birimini seciniz");
                }
                else if (StokKoduKutu.Text != "" && StokAdiKutu.Text != "" && StokMiktariKutu.Text != "" && StokBirimiComboKutu.Text != "" && AlisFiyatiKutu.Text == "" && SatisFiyatiKutu.Text != "")
                {
                    MessageBox.Show("Lutfen Alis Fiyatini giriniz");
                }
                else if (StokKoduKutu.Text != "" && StokAdiKutu.Text != "" && StokMiktariKutu.Text != "" && StokBirimiComboKutu.Text != "" && AlisFiyatiKutu.Text != "" && SatisFiyatiKutu.Text == "")
                {
                    MessageBox.Show("Lutfen Satis Fiyatini giriniz");
                }
                else
                {
                    MessageBox.Show("Tum Alanlarin Doldurulmasi Zorunludur");
                }

            }

        }

        private void StokBirimiComboKutu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StokMiktariKutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void AlisFiyatiKutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void SatisFiyatiKutu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmStokKarti_Load(object sender, EventArgs e)
        {
            lblCalisanAd.Text = global.name + " " + global.surname;
            lblUsername.Text = global.username;
        }
    }
}
