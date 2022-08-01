using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace Alisveris
{
    public partial class frm_AnaMenu : Form
    {
        public frm_AnaMenu()
        {
            InitializeComponent();
        }
        //PROJE HENÜZ TAMAMLANMAMIŞTIR. EKSİKLER:
        //Alışveriş tamamlanınca veritabanındaki bakiye güncellenecek
        //Bakiye yükleme işlemi için yeni forma(frm_ParaYukle) geçilir. 
        //Bu formdaki bilgiler diğer formlardan alınacak ve anamenuye geri bilgi iletecek
        
        
        Veritabani veri = new Veritabani();
        SqlConnection baglanti;
        frm_ParaYukle yukleme = new frm_ParaYukle();

        SqlDataReader urunlerVeri;
        SqlDataReader bakiyeVeri;

        int toplam = 0;
        int bakiye;

        string[] urunler;
        int[] adetler;
        int[] fiyatlar;

        private void btn_yukle_Click(object sender, EventArgs e)
        {
   

        }

        private void btn_bitir_Click(object sender, EventArgs e)
        {
           if(toplam>bakiye)
            {
                MessageBox.Show("Bakiyeniz yetersiz");
            }
           else
            {
                MessageBox.Show("Alışverişiniz başarılı, yeni bakiyeniz:" + (bakiye-=toplam).ToString());
                list_adet.Items.Clear();
                list_tutar.Items.Clear();
                list_urun.Items.Clear();
            }
            lbl_bakiye.Text = bakiye.ToString();
            Console.WriteLine("selam");
        }

  

        private void button3_Click(object sender, EventArgs e)
        {
            list_adet.Items.Clear();
            list_tutar.Items.Clear();
            list_urun.Items.Clear();
            txt_toplam.Text = "0";

            
            for(int i=0;i<adetler.Length;i++)
            {
                adetler[i] = 1;
            }
        }

  

  

        private int UrunEkle(string urun, int adet, int fiyat)
        {
            int bolge = 0;
            toplam = 0;

            if (list_urun.Items.Contains(urun))
            {
                bolge = list_urun.Items.IndexOf(urun);
                list_adet.Items.RemoveAt(bolge);
                list_adet.Items.Insert(bolge, adet);
                list_tutar.Items.RemoveAt(bolge);
                list_tutar.Items.Insert(bolge, fiyat * adet);

            }
            else
            {
                list_urun.Items.Add(urun);
                list_adet.Items.Add(adet);
                list_tutar.Items.Add(fiyat);
            }

            foreach (int ekle in list_tutar.Items)
            {
                toplam += ekle;
            }
            txt_toplam.Text = toplam.ToString();
            return adet;
        }
        private void frm_AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bakiyeAl()
        {
            SqlCommand bakiyeKomut = new SqlCommand("SELECT bakiye FROM hesaplar WHERE id=@id", baglanti);
            bakiyeKomut.Parameters.AddWithValue("@id", frm_KullaniciGiris.id);

            SqlDataReader okuyucu = bakiyeKomut.ExecuteReader();
            okuyucu.Read();
            bakiye = Convert.ToInt32(okuyucu[0]);
            lbl_bakiye.Text = bakiye.ToString();
            okuyucu.Close();
        }

        private void saydir()
        {
            SqlCommand komutSaydir = new SqlCommand("SELECT COUNT(*) FROM Urunler",baglanti);

            SqlDataReader okuyucu = komutSaydir.ExecuteReader();
            okuyucu.Read();
            int elemanSayisi = (int)(okuyucu[0]);

            urunler = new string[elemanSayisi];
            adetler = new int[elemanSayisi];
            fiyatlar = new int[elemanSayisi];
            okuyucu.Close();
        }



        private void olustur()
        {
            int i = 0;
            SqlCommand komutOlustur = new SqlCommand("SELECT * FROM Urunler",baglanti);
            SqlDataReader urunlerVeri = komutOlustur.ExecuteReader();
            while(urunlerVeri.Read())
            {
                //Button
                Button dugme = new Button();
                dugme.Text = "Ü" + (i + 1);
                dugme.Size = new Size(75, 25);
                dugme.Tag = i;
                dugme.Click += dugme_Tikla;
                flowLayoutPanel1.Controls.Add(dugme);


                //TextBox - ÜrünAdı
                TextBox urunAdi = new TextBox();
                urunAdi.ReadOnly = true;
                urunAdi.Text = urunlerVeri["u_adi"].ToString();
                urunAdi.Size = new Size(75, 25);
                urunler[i] = urunAdi.Text;
                flowLayoutPanel1.Controls.Add(urunAdi);

                //TextBox - ÜrünFiyatı
                TextBox urunFiyat = new TextBox();
                urunFiyat.ReadOnly = true;
                urunFiyat.Text = urunlerVeri["fiyat"].ToString();
                urunFiyat.Size = new Size(75, 25);
                fiyatlar[i] = Convert.ToInt32(urunFiyat.Text);
                flowLayoutPanel1.Controls.Add(urunFiyat);

                adetler[i] = 1;
                i++;

            }
            urunlerVeri.Close();

        }

        private void dugme_Tikla(object sender, EventArgs e)
        {
            Button tiklanan = sender as Button;
            int eleman = Convert.ToInt32(tiklanan.Tag);
            UrunEkle(urunler[eleman],adetler[eleman],fiyatlar[eleman]);
            adetler[eleman]++;
        }
        private void frm_AnaMenu_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_KullaniciGiris giris = new frm_KullaniciGiris();
            giris.ShowDialog();
            this.Visible = true;
            
             baglanti = veri.BaglantiAc();
            saydir();

            olustur();

            bakiyeAl();
        }
    }
}
