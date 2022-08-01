using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alisveris
{
    public partial class frm_ParaYukle : Form
    {
        public frm_ParaYukle()
        {
            InitializeComponent();
        }

        private void btn_yukle_Click(object sender, EventArgs e)
        {
            /*frm_AnaMenu.bakiye += Convert.ToInt32(txt_yukle.Text);
            txt_bakiye.Text = frm_AnaMenu.bakiye.ToString();*/
        }

        private void frm_ParaYukle_Load(object sender, EventArgs e)
        {
            /*txt_kAdi.Text = frm_AnaMenu.kAdi;
            txt_bakiye.Text = frm_AnaMenu.bakiye.ToString();*/
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_AnaMenu anaMenu = new frm_AnaMenu();
            anaMenu.ShowDialog();

        }
    }
}
