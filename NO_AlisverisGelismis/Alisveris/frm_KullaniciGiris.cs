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

namespace Alisveris
{
    public partial class frm_KullaniciGiris : Form
    {
        public frm_KullaniciGiris()
        {
            InitializeComponent();
        }
        Veritabani veri = new Veritabani();
        public static string kAdi;
        public static int id;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = veri.BaglantiAc();

            SqlCommand komut = new SqlCommand("SELECT * FROM kullanicilar WHERE k_adi=@k_adi AND sifre=@sifre",baglanti);
            komut.Parameters.AddWithValue("@k_adi",textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);

            SqlDataReader okuyucu = komut.ExecuteReader();

            if (okuyucu.Read())
            {
                kAdi = okuyucu["k_adi"].ToString();
                id = Convert.ToInt32(okuyucu["id"]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            
        }

        private void frm_KullaniciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
