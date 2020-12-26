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
    public partial class frmServisElemaniGecis : Form
    {
        public frmServisElemaniGecis()
        {
            InitializeComponent();
        }

        private void frmServisElemaniGecis_Load(object sender, EventArgs e)
        {
            lblCalisanAd.Text = global.name + " " + global.surname;
            lblUsername.Text = global.username;

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

        private void bttnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin ss = new frmLogin();
            ss.Show();
        }

        private void lblCalisanAd_Click(object sender, EventArgs e)
        {
            

        }
    }
}
