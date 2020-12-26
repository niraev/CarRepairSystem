using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoTamir
{
    public partial class frmAdminGecis : Form
    {
        public frmAdminGecis()
        {
            InitializeComponent();
        }

        private void bttnCalisanTanimlamaGecis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCalisanTanimlama ss = new frmCalisanTanimlama();
            ss.Show();
        }

        private void bttnAracKabulTeslimGecis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAracKabulTeslim ss = new frmAracKabulTeslim();
            ss.Show();
        }

        private void bttnServisFormuGecis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServisFormu ss = new frmServisFormu();
            ss.Show();
        }

        private void bttnStokKartiGecis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStokKarti ss = new frmStokKarti();
            ss.Show();
        }

        private void bttnTamirGecis_Click(object sender, EventArgs e)
        {
            this.Hide();
            TamirGirisEkrani ss = new TamirGirisEkrani();
            ss.Show();
        }

        private void bttnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin ss = new frmLogin();
            ss.Show();
        }

        private void frmAdminGecis_Load(object sender, EventArgs e)
        {
            lblCalisanAd.Text = global.name +" "+ global.surname;
            lblUsername.Text = global.username;

        }
    }
}
