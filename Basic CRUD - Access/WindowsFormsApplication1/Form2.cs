using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\market.accdb");
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        public void kategori_listele()
        {
            try
            {
                con.Open();
                string sql_oku = "select * from kategoriler";
                OleDbDataAdapter da = new OleDbDataAdapter(sql_oku, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message); 
               
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            kategori_listele();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql_ekle = "insert into kategoriler (kategori_adi) values('" + txt_kategori_adi.Text + "')";
                OleDbCommand cmd_ekle = new OleDbCommand(sql_ekle, con);
                cmd_ekle.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            kategori_listele();
        }
    }
}
