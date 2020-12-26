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
using System.Web.Providers.Entities;

namespace OtoTamir
{
    public partial class frmLogin : Form
    {
        


        public frmLogin()
        {
            InitializeComponent();
        }


        private void bttnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnGiris_Click(object sender, EventArgs e)
        {
            string Username = KullaniciAdiKutu.Text;
            string Pwd = SifreKutu.Text;
            bool flag = true;


            // List<UserInformation> informationList = new List<UserInformation>();
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03N98IC\NIRAEVSQL;Initial Catalog=OtoTamir;Persist Security Info=True;User ID=sa;Password=nbrmtmt1234"))
            {
                conn.Open();

                
                SqlCommand cmd1 = new SqlCommand("getGirisYap_sp", conn);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.Add("@Username", SqlDbType.NVarChar).Value = Username;
                cmd1.Parameters.Add("@Sifre", SqlDbType.NVarChar).Value = Pwd;



                using (SqlDataReader rdr1 = cmd1.ExecuteReader())
                {
                    

                    while (rdr1.Read())
                    {
                        flag = false;

                        // LoginInformationList.Add(userLoginInfo);
                        //var a = rdr1["Sifre"].ToString();
                        //var b = rdr1["Username"].ToString();
                        Global.yetkiTipi = Convert.ToInt32(rdr1["refYetkiTipi"]);
                        global.username = rdr1["Username"].ToString();
                        global.name = rdr1["CalisanAd"].ToString();
                        global.surname = rdr1["CalisanSoyad"].ToString();


                        if (rdr1["Sifre"].ToString() == Pwd && rdr1["Username"].ToString() == Username)
                        {
                            if (Convert.ToInt32(rdr1["refYetkiTipi"]) == 0)
                            {
                                //admin ekrani -> admin ekranindan tum ekranlara 
                                this.Hide();
                                frmAdminGecis ss = new frmAdminGecis();
                                ss.Show();  

                            }
                            else if (Convert.ToInt32(rdr1["refYetkiTipi"]) == 1)
                            {
                                //Servis Elemani Gecis Ekrani
                                this.Hide();
                                frmServisElemaniGecis ss = new frmServisElemaniGecis();
                                ss.Show();
                            }
                            else if (Convert.ToInt32(rdr1["refYetkiTipi"]) == 2)
                            {
                                //Stok Karti Ekrani 
                                this.Hide();
                                frmStokKarti ss = new frmStokKarti();
                                ss.Show();
                            }
                            else if (Convert.ToInt32(rdr1["refYetkiTipi"]) == 3 || Convert.ToInt32(rdr1["refYetkiTipi"]) == 4 || Convert.ToInt32(rdr1["refYetkiTipi"]) == 5)
                            {
                                //Usta Gecis Ekrani
                                this.Hide();
                                frmUstaGecis ss = new frmUstaGecis();
                                ss.Show();
                            }

                            break;
                        }
                       

                        //        using (SqlDataReader rdr = cmd.ExecuteReader())
                        //{

                            //    while (rdr.Read())
                            //    {
                            //        UserInformation userInfo = new UserInformation();

                            //        if (!String.IsNullOrWhiteSpace(rdr["KayitZamani"].ToString()))
                            //        {
                            //            userInfo.KayitZamani = Convert.ToDateTime(rdr["KayitZamani"]);
                            //        }
                            //        userInfo.CalisanAd = rdr["CalisanAd"].ToString();
                            //        userInfo.CalisanSoyad = rdr["CalisanSoyad"].ToString();
                            //        userInfo.Sifre = rdr["Sifre"].ToString();
                            //        userInfo.Username = rdr["Username"].ToString();
                            //        userInfo.refYetkiTipi = Convert.ToInt32(rdr["refYetkiTipi"]);
                            //        if (!String.IsNullOrWhiteSpace(rdr["IslemGirisTarihi"].ToString()))
                            //        {
                            //            userInfo.IslemGirisTarihi = Convert.ToDateTime(rdr["IslemGirisTarihi"]);
                            //        }
                            //        if (!String.IsNullOrWhiteSpace(rdr["IslemGirisTarihi"].ToString()))
                            //        {
                            //            userInfo.IslemCikisTarihi = Convert.ToDateTime(rdr["IslemCikisTarihi"]);
                            //        }


                            //        informationList.Add(userInfo);

                            //        if (userInfo.refYetkiTipi == '1')
                            //        {
                            //            this.Hide();
                            //            frmAracKabulTeslim ss = new frmAracKabulTeslim();
                            //            ss.Show();
                            //        }
                            //        else
                            //        { //buralara diger yetki tipleri icin acilicak sayfalari gir if else ile 

                            //            alert("Dogru kullanici adi ve parola giriniz");

                            //        }

                    }
                    if(flag==true)
                    {
                        if (Username == "" && Pwd == "")
                        {
                            MessageBox.Show("Kullanici adi ve Sifre bos birakilamaz");
                        }
                        else if (Pwd == "")
                        {
                            MessageBox.Show("Sifre bos birakilamaz");
                        }
                        else if (Username == "")
                        {
                            MessageBox.Show("Kullanici adi bos birakilamaz");
                        }
                        else 
                        {
                            MessageBox.Show("Lutfen kullanici adiniz ve parolanizi kontrol etmeyi unutmayin");
                        }
                        
                    }
                    


                }
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }

    internal class Global
    {
        public static int yetkiTipi;
    }
}

       
    


