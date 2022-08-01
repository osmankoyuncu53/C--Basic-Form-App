using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselProgramlamaOdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_yapilacakIslem.Items.Add("BÜYÜK HARFE DÖNÜŞTÜR");
            cmb_yapilacakIslem.Items.Add("küçük harfe dönüştür");
            cmb_yapilacakIslem.Items.Add("İlk karşılaşılan metnin yerini bul");
            cmb_yapilacakIslem.Items.Add("Son karşılaşılan metnin yerini bul");
            cmb_yapilacakIslem.Items.Add("Değer değiştir");
            cmb_yapilacakIslem.Items.Add("Metin sil");
            cmb_yapilacakIslem.Items.Add("Metnin parçasını al");
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            lbl_bilgilendirme.Text = "Burada Yapılacak İşlem İle İlgili \n Bilgilendirme Mesajı Bulunacaktır..";
        }

        private void btn_islemYap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_yazi.Text) ||
                String.IsNullOrWhiteSpace(txt_yazi.Text))                 
            {
                MessageBox.Show("İşlenecek Metin Boş Kalamaz..");
            }
            else if (cmb_yapilacakIslem.SelectedItem == null)
            {
                MessageBox.Show("Yapılacak İşlem Boş Kalamaz..");
            }
            else
            {
                if (cmb_yapilacakIslem.SelectedItem == "BÜYÜK HARFE DÖNÜŞTÜR")
                {
                    lbl_sonuc.Text = txt_yazi.Text + ":" + txt_yazi.Text.ToUpper();
                }

                else if (cmb_yapilacakIslem.SelectedItem == "küçük harfe dönüştür")
                {
                    lbl_sonuc.Text = txt_yazi.Text + ":" + txt_yazi.Text.ToLower();
                }

                else if (cmb_yapilacakIslem.SelectedItem == "İlk karşılaşılan metnin yerini bul")
                {
                    String yazi = txt_yazi.Text;
                    String aranacakP = txt_aranacakP.Text;
                    int sonuc;

                    sonuc = yazi.IndexOf(aranacakP);
                    sonuc += 1;
           
                    if (sonuc == -1)
                    {
                        MessageBox.Show("Aradığınız kelime yazmış olduğunuz yazının içerisinde bulunmamaktadır");
                    }
                    else
                    {
                        lbl_sonuc.Text = txt_yazi.Text + ":" + txt_aranacakP.Text + " ilk bulunan yeri=" + sonuc.ToString();
                    }

                }
               
                else if (cmb_yapilacakIslem.SelectedItem == "Son karşılaşılan metnin yerini bul")
                {
                    String yazi = txt_yazi.Text;
                    String aranacakP = txt_aranacakP.Text;
                    int sonuc;

                    sonuc = yazi.LastIndexOf(aranacakP);  //sonuc = yazi.IndexOf(aranacakP);
                    sonuc += 1;
                    if (sonuc == -1)
                    {
                        MessageBox.Show("Aradığınız kelime yazmış olduğunuz yazının içerisinde bulunmamaktadır");
                    }
                    else
                    {
                        lbl_sonuc.Text = txt_yazi.Text + ":" + txt_aranacakP.Text + " son bulunan yeri=" + sonuc.ToString();
                    }
                }

                else if (cmb_yapilacakIslem.SelectedItem == "Değer değiştir")
                {
                    String yazi = txt_yazi.Text;
                   
                    String sonuc=yazi.Replace(txt_eski.Text, txt_yeni.Text);
                    lbl_sonuc.Text = txt_yazi.Text+": yeni yazı= "+ sonuc;
                }

                else if (cmb_yapilacakIslem.SelectedItem == "Metin sil")
                {
                    String yazi = txt_yazi.Text;
                    
                    if (String.IsNullOrEmpty(txt_baslangic.Text))
                    {
                        MessageBox.Show("Silinecek Metnin Başlangıç Miktarı Boş Bırakılamaz..");
                    }

                    else if (String.IsNullOrEmpty(txt_adetS.Text))
                    {

                        int a = Convert.ToInt32(txt_baslangic.Text);
                        lbl_sonuc.Text = yazi + ": yeni yazı= " + yazi.Remove(a);
                    }

                    else
                    {
                        int a = Convert.ToInt32(txt_baslangic.Text);
                        int b = Convert.ToInt32(txt_adetS.Text);
                        lbl_sonuc.Text = yazi + ": yeni yazı= " + yazi.Remove(a, b);
                    }
                }

                else if (cmb_yapilacakIslem.SelectedItem == "Metnin parçasını al")
                {
                    String yazi = txt_yazi.Text;
                    if (String.IsNullOrEmpty(txt_baslangic.Text))
                    {
                        MessageBox.Show("Silinecek Başlangıç Değeri Boş Bırakılamaz..");
                    }
                    else if(String.IsNullOrEmpty(txt_adetS.Text))
                    {
                        int a = Convert.ToInt32(txt_baslangic.Text);
                        lbl_sonuc.Text =txt_yazi.Text+": yeni yazı= "+yazi.Substring(a);
                    }

                    else
                    {
                        int a = Convert.ToInt32(txt_baslangic.Text);
                        int b = Convert.ToInt32(txt_adetS.Text);

                        lbl_sonuc.Text = txt_yazi.Text + ": yeni yazı= " + yazi.Substring(a,b);
                    }
                }
            }
        }
        private void cmb_yapilacakIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_yapilacakIslem.SelectedItem == "İlk karşılaşılan metnin yerini bul")
            {
                lbl_bilgilendirme.Text = ("Büyük Küçük Harf Duyarlılığı Vardır...");

                groupBox1.Visible = true;

                groupBox2.Visible = false;
                groupBox3.Visible = false;

                txt_adet.Enabled = false;
            }

            else if (cmb_yapilacakIslem.SelectedItem == "Son karşılaşılan metnin yerini bul")
            {
                lbl_bilgilendirme.Text = ("Büyük Küçük Harf Duyarlılığı Vardır...");

                groupBox1.Visible = true;

                groupBox2.Visible = false;
                groupBox3.Visible = false;

                txt_adet.Enabled = false;
            }

            else if (cmb_yapilacakIslem.SelectedItem == "Değer değiştir")
            {
                lbl_bilgilendirme.Text = ("Büyük Küçük Harf Duyarlılığı Vardır...");

                groupBox2.Visible = true;

                groupBox1.Visible = false;
                
            }

            else if (cmb_yapilacakIslem.SelectedItem == "Metin sil")
            {
                lbl_bilgilendirme.Text = ("Karakter bölümü boş bırakılırsa işlem \n metnin sonuna kadar gerçekleşir...");

                groupBox1.Visible = false;
                groupBox2.Visible = false;

                groupBox3.Visible = true;

                
                
            }

            else if (cmb_yapilacakIslem.SelectedItem == "Metnin parçasını al")
            {
                lbl_bilgilendirme.Text = ("Karakter bölümü boş bırakılırsa işlem \n metnin sonuna kadar gerçekleşir...");

                groupBox1.Visible = false;
                groupBox2.Visible = false;

                groupBox3.Visible = true;
            }
            
        }

        private void btn_islemKaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lbl_sonuc.Text))
            {
                MessageBox.Show("Kaydedilecek İşlem Bulunamamıştır...");
            }
            else
            {
                lst_ciktilar.Items.Add(lbl_sonuc.Text);
            }
        }
    }
}
