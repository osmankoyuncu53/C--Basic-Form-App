using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_Uygulama2_HesapMakinesi
{
    public partial class Form1 : Form
    {
        string islem;
        double sayi1, sayi2;
        double sonuc = 1;
        string cumleBirleştirici;

        public Form1()
        {
            InitializeComponent();
        }

        private void txt_islem_TextChanged(object sender, EventArgs e)
        {
            txt_islem.Focus();
        }

        private void ekle(object sender, EventArgs e)
        {
            Button rakam = sender as Button;
            txt_islem.Text += rakam.Text;
        }

        private void txt_islem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_islem.Text.IndexOf(',') == -1)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

            //Klavyeden Girilebilecek Olan Karakterler
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Space)
            {
                if (String.IsNullOrEmpty(txt_islem.Text) ||
                String.IsNullOrWhiteSpace(txt_islem.Text))
                {
                    MessageBox.Show("Karakter Girişi Olmadan İşlem Yapılamaz.!");
                }
                else
                {
                    if (islem == "+")
                    {

                        convert2();
                        lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                        txt_islem.Text = Convert.ToString(sayi1 + sayi2);
                    }

                    else if (islem == "-")
                    {
                        convert2();
                        lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                        txt_islem.Text = (sayi1 - sayi2).ToString();
                    }

                    else if (islem == "*")
                    {
                        convert2();
                        lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                        txt_islem.Text = (sayi1 * sayi2).ToString();
                    }

                    else if (islem == "/")
                    {
                        convert2();
                        if (sayi2 == 0)
                        {
                            MessageBox.Show("Girilen Sayı 0 Sayısına Bölünemez");
                        }
                        else
                        {
                            lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                            txt_islem.Text = (sayi1 / sayi2).ToString();
                        }
                    }

                    else if (islem == "%")
                    {
                        convert2();
                        lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                        double kalan = (sayi1 % sayi2);
                        txt_islem.Text = kalan.ToString();
                    }

                    else if (islem == "^")
                    {
                        convert2();
                        lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                        txt_islem.Text = Math.Pow(sayi1, sayi2).ToString();
                    }

                }
            }

            // doğrudan klavye
            else if (e.KeyChar == '+')
            {
                if (txt_islem.Text != "")
                {
                    convert1();
                }
                topla();
            }

            else if (e.KeyChar == '-')
            {
                if (txt_islem.Text != "")
                {
                    convert1();
                }
                cikar();
            }

            else if (e.KeyChar == '*')
            {
                if (txt_islem.Text != "")
                {
                    convert1();
                }
                carp();
            }

            else if (e.KeyChar == '/')
            {
                if (txt_islem.Text != "")
                {
                    convert1();
                }
                bol();
            }


            else if (e.KeyChar == '%')
            {
                if (txt_islem.Text != "")
                {
                    convert1();
                }
                modAlma();
            }

            else if (e.KeyChar == '^')
            {
                if (txt_islem.Text != "")
                {
                    convert1();
                }
                kuvvetAlma();
            }
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_islem.Text) ||
                String.IsNullOrWhiteSpace(txt_islem.Text))
            {
                MessageBox.Show("Karakter Girişi Olmadan İşlem Yapılamaz.!");
            }
            else {
                if (islem == "+")
                {

                    convert2();
                    lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                    txt_islem.Text = Convert.ToString(sayi1 + sayi2);
                }

                else if (islem == "-")
                {
                    convert2();
                    lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                    txt_islem.Text = (sayi1 - sayi2).ToString();
                }

                else if (islem == "*")
                {
                    convert2();
                    lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                    txt_islem.Text = (sayi1 * sayi2).ToString();
                }

                else if (islem == "/")
                {
                    convert2();
                    if (sayi2 == 0)
                    {
                        MessageBox.Show("Girilen Sayı 0 Sayısına Bölünemez");
                    }
                    else
                    {
                        lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                        txt_islem.Text = (sayi1 / sayi2).ToString();
                    }
                }

                else if (islem == "%")
                {
                    convert2();
                    lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                    double kalan = (sayi1 % sayi2);
                    txt_islem.Text = kalan.ToString();
                }

                else if (islem == "^")
                {
                    convert2();
                    lbl_islem.Text = cumleBirleştirici + sayi2.ToString() + "=";
                    txt_islem.Text = Math.Pow(sayi1, sayi2).ToString();
                }
            }
        }

        // Butonların Click Olayları
        private void btn_cikarma_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            cikar();
        }
        private void btn_toplama_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            topla();
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            carp();
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            bol();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            modAlma();
        }

        private void btn_kuvvet_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            kuvvetAlma();
        }

        private void btn_karesi_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            kareAlma();
        }

        private void btn_faktoriyel_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            faktoriyel();
        }

        private void btn_islemDegis_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            islemDegis();
        }

        private void btn_karekok_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            karekok();
        }

        private void btn_ondalik_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            ondalik();
        }

        private void btn_karakterSil_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            karakterSil();
        }

        private void btn_textTemizle_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            clearEnter();
        }

        private void btn_fullTemizle_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text != "")
            {
                convert1();
            }
            fullTemizle();
        }   



        // FONKSİYON ALANI
        void convert1()
        {
            sayi1 = Convert.ToDouble(txt_islem.Text); //sayi1 için convert olayı
            
        }

        void convert2()
        {
            sayi2 = Convert.ToDouble(txt_islem.Text);
        }

        void topla()
        {
            islem = "+";
            cumleBirleştirici = lbl_islem.Text = sayi1 + islem;
            txt_islem.Clear();
        }

        void cikar()
        {
            islem = "-";
            cumleBirleştirici = lbl_islem.Text = sayi1 + islem;
            txt_islem.Clear();
        }

        void carp()
        {
            islem = "*";
            cumleBirleştirici = lbl_islem.Text = sayi1 + islem;
            txt_islem.Clear();
        }

        void bol()
        {
            islem = "/";
            cumleBirleştirici = lbl_islem.Text = sayi1 + islem;
            txt_islem.Clear();
        }


        void modAlma()
        {
            islem = "%";
            cumleBirleştirici = lbl_islem.Text = sayi1 + islem;
            txt_islem.Clear();
        }


        void kuvvetAlma()
        {
            islem = "^";
            cumleBirleştirici = lbl_islem.Text = sayi1 + islem;
            txt_islem.Clear();
        }

        void kareAlma()
        {
            islem = "^";
            lbl_islem.Text = sayi1 + islem + sayi1 + "=";
            txt_islem.Text = (sayi1 * sayi1).ToString();
        }

        void faktoriyel()
        {
            islem = "!";
            for (int i = 1; i <= sayi1; i++)
            {
                sonuc *= i;
            }
            lbl_islem.Text = sayi1 + islem + "=";
            txt_islem.Text = sonuc.ToString();
        }

        void islemDegis()
        {
            islem = "±";
            txt_islem.Text = (sayi1 *= -1).ToString();
        }

        void karekok()
        {
            islem = "√";
            lbl_islem.Text = "Sqrt" + "(" + sayi1 + ")" + "=";
            txt_islem.Text = (Math.Sqrt(sayi1)).ToString();
        }

        void ondalik()
        {
            if (txt_islem.Text.IndexOf(',') == -1)
            {
                islem = ",";
                txt_islem.Text =sayi1+ islem;
            }
            else
            {
                MessageBox.Show("mission not complete");
            }
            
        }
    
        // Silme İşlemleri
        void karakterSil()
        {
            if (Convert.ToDouble(txt_islem.Text) > 0)
            {
                txt_islem.Text = txt_islem.Text.Remove(txt_islem.Text.Length - 1, 1);

                if (txt_islem.Text.Length == 0)
                {
                    txt_islem.Text = "0"; //kullanmayınca hata veriyor..
                }
            }
        }

        void clearEnter()
        {
            txt_islem.Clear(); //txt_islem.Text="";
        }
        void fullTemizle()
        {
            txt_islem.Clear();    //txt_islem.ResetText();
            lbl_islem.Text = "";  //lbl_islem.ResetText();
        }
    }
}
