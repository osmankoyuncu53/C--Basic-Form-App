using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alisveris
{
    public partial class Form1 : Form
    {
        //ÜRÜN ADI , TUTARI , ADETİ ni dizilerde tuttuk.
        public string[] UrunAd = new string[5];
        public int[] UrunTutar = new int[5];
        public int[] UrunAdet = new int[5];

        public Form1()
        {
            InitializeComponent();
            //Ürünlerin adlarını diziye atadık çünkü isimler sabit değiştirme olmayacak
            UrunAd[0] = lbl_urunDVD.Text;
            UrunAd[1] = lbl_urunCD.Text;
            UrunAd[2] = lbl_urunKAGIT.Text;
            UrunAd[3] = lbl_urunKASA.Text;
            UrunAd[4] = lbl_urunBILGISAYAR.Text;

            //başlangıçta ürün adetlerini 0 a eşitledik hiçbir ürün alınmayacak
            for (int i = 0; i < 5; i++)
            {
                UrunAdet[i] = 0;
            }
        }

        public int i=1;
        public static int tutar;
        public static int bakiye=1000;
        void Yazdir() {
            //listboxları temizliyoruz
            lst_urunAd.Items.Clear();
            lst_urunAdet.Items.Clear();
            lst_urunTutar.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                //ürün adeti 0 a eşit olmayan ürünleri listboxa yazdırma işlemini gerçekleştirdik.
                if (UrunAdet[i] != 0) {
                    lst_urunAd.Items.Add(UrunAd[i]);
                    lst_urunAdet.Items.Add(UrunAdet[i]);
                    lst_urunTutar.Items.Add(UrunTutar[i]);
                }
            }
            
            tutar = UrunTutar[0] + UrunTutar[1] + UrunTutar[2] + UrunTutar[3]+ UrunTutar[4];
            txt_toplamTutar.Text = tutar.ToString();
        }

        void temizle()
        {
            //temizleme işleminde ürünlerin adetlerini ve tutarını 0 yapmamız gerek 0 yaptık ve temizledik.
            lst_urunAd.Items.Clear();
            lst_urunAdet.Items.Clear();
            lst_urunTutar.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                UrunAdet[i] = 0;
                UrunTutar[i] = 0;
            }
            tutar = 0;
            txt_toplamTutar.Text = tutar.ToString();
        
        }
        private void btn_urunDVD_Click(object sender, EventArgs e)
        {
            //her ekleme yapıldığında ürün adetini 1 arttırıp tutarını güncelledik ve yazdırma işlemini yaptık
            UrunAdet[0]++;
            UrunTutar[0] = UrunAdet[0] * int.Parse(lbl_urunFiyatDVD.Text);
            Yazdir();
        }

        private void btn_urunCD_Click(object sender, EventArgs e)
        {
            //her ekleme yapıldığında ürün adetini 1 arttırıp tutarını güncelledik ve yazdırma işlemini yaptık
            UrunAdet[1]++;
            UrunTutar[1] = UrunAdet[1] * int.Parse(lbl_urunFiyatCD.Text);
            Yazdir();
        }

        private void btn_urunKAGIT_Click(object sender, EventArgs e)
        {
            //her ekleme yapıldığında ürün adetini 1 arttırıp tutarını güncelledik ve yazdırma işlemini yaptık
            UrunAdet[2]++;
            UrunTutar[2] = UrunAdet[2] * int.Parse(lbl_urunFiyatKAGIT.Text);
            Yazdir();
        }

        private void btn_urunKASA_Click(object sender, EventArgs e)
        {
            //her ekleme yapıldığında ürün adetini 1 arttırıp tutarını güncelledik ve yazdırma işlemini yaptık
            UrunAdet[3]++;
            UrunTutar[3] = UrunAdet[3] * int.Parse(lbl_urunFiyatKASA.Text);
            Yazdir();
        }

        private void btn_urunBILGISAYAR_Click(object sender, EventArgs e)
        {
            //her ekleme yapıldığında ürün adetini 1 arttırıp tutarını güncelledik ve yazdırma işlemini yaptık
            UrunAdet[4]++;
            UrunTutar[4] = UrunAdet[4] * int.Parse(lbl_urunFiyatPC.Text);
            Yazdir();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_alisverisiBitir_Click(object sender, EventArgs e)
        {
           
            if (bakiye < tutar)
                MessageBox.Show("Bakiyeniz Yetersiz, İşlem Başarısız...");
            else
            {
                bakiye -= tutar;
                temizle();
                MessageBox.Show("İşlem Başarılı, Hayırlı Günler Dileriz..."+"Kalan Bakiye: "+bakiye.ToString());
                lbl_bakiye.Text = bakiye.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_bakiye.Text = bakiye.ToString();
            grpBoxBakiye.Visible = false;
        }

      
        private void btn_paraYukle_Click(object sender, EventArgs e)
        {
            grpBoxBakiye.Visible = true;
            int bak = Convert.ToInt16(lbl_bakiye.Text);
            txt_guncelBakiye.Text = bak.ToString();
            
        }

        private void btn_yukle_Click(object sender, EventArgs e)
        {
            int yuklenecekTutar = Convert.ToInt16(txt_yuklenecekTutar.Text);
            int bak = Convert.ToInt16(lbl_bakiye.Text);
            bakiye = yuklenecekTutar + bak;
            
            lbl_bakiye.Text = bakiye.ToString();
            grpBoxBakiye.Visible = false;
        }
    }
}
