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
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\market.accdb");
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        public void listele2()
        {
            try
            {
                con.Open();
                string sql_oku = "select * from urunler";
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

        public void goster()
        {
            try
            {
                con.Open();
                string sql_goster = "select * from kategoriler";
                OleDbCommand cmd_goster = new OleDbCommand(sql_goster, con);
                OleDbDataReader dr = cmd_goster.ExecuteReader();
                while (dr.Read())
                {
                    cmb_kategori.Items.Add(dr["kategori_adi"]);
                }
                con.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

            }
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listele2();
            goster();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int kategori_id = 0;
                con.Open();
                string kategori_adi = cmb_kategori.SelectedItem.ToString();
                string sql_cek = "select * from kategoriler where kategori_adi=@kategori_adi";
                OleDbCommand cmd_cek = new OleDbCommand(sql_cek, con);
                cmd_cek.Parameters.AddWithValue("@kategori_adi", kategori_adi);
                OleDbDataReader dr = cmd_cek.ExecuteReader();
                while (dr.Read())
                {
                    kategori_id = Convert.ToInt16(dr["kategori_id"]);
                }
                con.Close();
                con.Open();
                string sql_kaydet = "insert into urunler (urun_adi,fiyat,kategori_id,aciklama) values(@urun_adi,@fiyat,@kategori_id,@aciklama)";
                OleDbCommand cmd_kaydet = new OleDbCommand(sql_kaydet, con);
                cmd_kaydet.Parameters.AddWithValue("@urun_adi", txt_urun_adi.Text);
                cmd_kaydet.Parameters.AddWithValue("@fiyat", txt_fiyat.Text);
                cmd_kaydet.Parameters.AddWithValue("@kategori_id", kategori_id);
                cmd_kaydet.Parameters.AddWithValue("@aciklama", txt_aciklama.Text);
                cmd_kaydet.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

            }
            listele2();
        }

        private void cmb_sirala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filtre = cmb_sirala.SelectedItem.ToString();
                if (filtre=="Ada Göre Artan")
                {
                    con.Open();
                    string sql_filtrele = "select * from urunler order by urun_adi asc";
                    OleDbDataAdapter da = new OleDbDataAdapter(sql_filtrele, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();
                }

                else if (filtre == "Ada Göre Azalan")
                {
                    con.Open();
                    string sql_filtrele = "select * from urunler order by urun_adi desc";
                    OleDbDataAdapter da = new OleDbDataAdapter(sql_filtrele, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();
                }

                else if (filtre == "Fiyata Göre Artan")
                {
                    con.Open();
                    string sql_filtrele = "select * from urunler order by fiyat asc";
                    OleDbDataAdapter da = new OleDbDataAdapter(sql_filtrele, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();
                }

                else if (filtre == "Fiyata Göre Azalan")
                {
                    con.Open();
                    string sql_filtrele = "select * from urunler order by fiyat desc";
                    OleDbDataAdapter da = new OleDbDataAdapter(sql_filtrele, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    con.Close();
                }
                

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }


        }



        
    }
}
