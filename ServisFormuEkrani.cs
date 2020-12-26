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
    public partial class frmServisFormu : Form
    {
        public frmServisFormu()
        {
            InitializeComponent();
        }


        //DataTable dbdataset;

        private void frmServisFormu_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'otoTamirDataSet10.ServisFormuMalzemeler' table. You can move, or remove it, as needed.
            //this.servisFormuMalzemelerTableAdapter2.Fill(this.otoTamirDataSet10.ServisFormuMalzemeler);
            //// TODO: This line of code loads data into the 'otoTamirDataSet9.ServisFormu' table. You can move, or remove it, as needed.
            //this.servisFormuTableAdapter4.Fill(this.otoTamirDataSet9.ServisFormu);
            //// TODO: This line of code loads data into the 'otoTamirDataSet6.ServisFormuMalzemeler' table. You can move, or remove it, as needed.
            //this.servisFormuMalzemelerTableAdapter1.Fill(this.otoTamirDataSet6.ServisFormuMalzemeler);
            //// TODO: This line of code loads data into the 'otoTamirDataSet5.ServisFormu' table. You can move, or remove it, as needed.
            //this.servisFormuTableAdapter3.Fill(this.otoTamirDataSet5.ServisFormu);
            lblCalisanAd.Text = global.name + " " + global.surname;
            lblUsername.Text = global.username;

            // TODO: This line of code loads data into the 'otoTamirDataSet3.ServisFormu' table. You can move, or remove it, as needed.
            //this.servisFormuTableAdapter2.Fill(this.otoTamirDataSet3.ServisFormu);
            // TODO: This line of code loads data into the 'otoTamirDataSet1.ServisFormu' table. You can move, or remove it, as needed.
            //this.servisFormuTableAdapter1.Fill(this.otoTamirDataSet1.ServisFormu);
            //// TODO: This line of code loads data into the 'otoTamirDataSet.ServisFormu' table. You can move, or remove it, as needed.
            //this.servisFormuTableAdapter.Fill(this.otoTamirDataSet.ServisFormu);

        }

        private void bttnGeri_Click(object sender, EventArgs e)
        {
            if (Global.yetkiTipi == 1)
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
            else if (Global.yetkiTipi == 3)
            {
                this.Hide();
                frmUstaGecis ss = new frmUstaGecis();
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


        private void PlakaKutu_TextChanged(object sender, EventArgs e)
        {

            //DataView DV = new DataView(dbdataset);
            //DV.RowFilter = string.Format("refArac LIKE '%{0}%'", PlakaKutu.Text);
            //ServisFormuEkEkran.DataSource = DV; 


         
        }

       

        private void bttnAra_Click(object sender, EventArgs e)
        {
            string plate = PlakaKutu.Text;

           // this.ServisFormuEkEkran.Rows.Add(SFE.sfKayitZamani, SFE.sfGirisTarihi, SFE.sfCikisTarihi, SFE.sfPlaka, SFE.sfYapilanIslem, SFE.sfTutar, SFE.sfmKayitZamani, SFE.sfmKullanilanStokAdi);

            ServisFormuEkEkran.ColumnCount = 8;

            ServisFormuEkEkran.Columns[0].Name = "Servis Formu Kayit Zamani";
            ServisFormuEkEkran.Columns[1].Name = "Islem Giris Tarihi";
            ServisFormuEkEkran.Columns[2].Name = "Islem Cikis Tarihi";
            ServisFormuEkEkran.Columns[3].Name = "Plaka";
            ServisFormuEkEkran.Columns[4].Name = "Yapilan Islem";
            ServisFormuEkEkran.Columns[5].Name = "Tutar";
            ServisFormuEkEkran.Columns[6].Name = "Servis Formu Malzeme Kayit Zamani'";
            ServisFormuEkEkran.Columns[7].Name = "Kullanilan Stok Adi";

            //foreach dongusu yaz suan sadece tampona yapilan islemi goruyor bir run et 

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03N98IC\NIRAEVSQL;Initial Catalog=OtoTamir;Persist Security Info=True;User ID=sa;Password=nbrmtmt1234"))
            {
                conn.Open();

                //SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT sf.KayitZamani AS ServisFormuKayitZamaní, sf.GirisTarihi AS ServisFormuGiris, sf.CikisTarihi AS ServisFormuCikis,sf.refArac AS Plaka, sf.YapilanIslem, sf.Tutar, sfm.KayitZamani AS MalzemeKullanmaKayitZamani, sfm.kullanilanStokAdi FROM ServisFormu sf INNER JOIN ServisFormuMalzemeler sfm ON sf.Id = sfm.refServisFormu WHERE sf.refArac LIKE '%' + @Plaka + '%'",conn);
                //DataTable dtbl = new DataTable();
                //sqlDa.Fill(dtbl);

                //ServisFormuEkEkran.DataSource = dtbl;

                SqlCommand cmd = new SqlCommand("getServisFormuMalzemeler_sp", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Plaka", SqlDbType.NVarChar).Value = plate;
                

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        SFE.sfKayitZamani = rdr["ServisFormuKayitZamani"].ToString();
                        SFE.sfGirisTarihi = rdr["ServisFormuGiris"].ToString();
                        SFE.sfCikisTarihi = rdr["ServisFormuCikis"].ToString();
                        SFE.sfPlaka = rdr["Plaka"].ToString();
                        SFE.sfYapilanIslem = rdr["YapilanIslem"].ToString();
                        SFE.sfTutar = rdr["Tutar"].ToString();
                        SFE.sfmKayitZamani = rdr["MalzemeKullanmaKayitZamani"].ToString();
                        SFE.sfmKullanilanStokAdi = rdr["kullanilanStokAdi"].ToString();



                        //this.ServisFormuEkEkran.Rows.Add(SFE.sfKayitZamani, SFE.sfGirisTarihi, SFE.sfCikisTarihi, SFE.sfPlaka, SFE.sfYapilanIslem, SFE.sfTutar, SFE.sfmKayitZamani, SFE.sfmKullanilanStokAdi);

                       


                    }

                    this.ServisFormuEkEkran.Rows.Add(SFE.sfKayitZamani, SFE.sfGirisTarihi, SFE.sfCikisTarihi, SFE.sfPlaka, SFE.sfYapilanIslem, SFE.sfTutar, SFE.sfmKayitZamani, SFE.sfmKullanilanStokAdi);


                    //ServisFormuEkEkran.Columns[0].Name = "KayitZamani";
                    //ServisFormuEkEkran.Columns[1].Name = "KullanilanStokAdi";
                    //ServisFormuEkEkran.Columns[2].Name = "KullanilanStokBirimi";
                    //ServisFormuEkEkran.Columns[3].Name = "KullanilanStokMiktari";
                    //ServisFormuEkEkran.Columns[4].Name = "KullanilanStokBirimAlisFiyati";
                    //ServisFormuEkEkran.Columns[5].Name = "KullanilanStokBirimSatisFiyati";
                    //ServisFormuEkEkran.Columns[6].Name = "KullanilanStokToplamFiyat";

                    //this.ServisFormuEkEkran.Rows.Add(SFE.sfmKayitZamani, SFE.sfmKullanilanStokAdi, SFE.sfmKullanilanStokBirimi, SFE.sfmKullanilanStokMiktari, SFE.sfmKullanilanStokBirimAlisFiyati, SFE.sfmKullanilanStokBirimSatisFiyati, SFE.sfmKullanilanStokToplamFiyat);



                }
                cmd.ExecuteNonQuery();


            }

        }

        private void bttnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
