using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBP_Ziplama_NO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool artis=true;
        int sinir=1,ilkX,ilkY;
        int sayac = 0;
        int puan = 0;
        int zorluk = 1;
        int zorlukSayac = 0;
        List<PictureBox> engel = new List<PictureBox>();
        private PictureBox engelEkle(Color renk,int genislik, int yukseklik)
        {
            PictureBox nesne = new PictureBox();
            nesne.Tag = "engel";
            nesne.BackColor = renk;
            nesne.Size = new Size(genislik, yukseklik);
            engel.Add(nesne);
            engel[sayac].Location = new Point(panel1.Width - engel[sayac].Width, pictureBox5.Location.Y - engel[sayac].Height);
            panel1.Controls.Add(engel[sayac]);
            return nesne;
        }

      
        private PictureBox uret()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(3);
            switch (sayi)
            {
                case 0:
                    return engelEkle(Color.Crimson,20,20);
                    break;
                case 1:
                    return engelEkle(Color.MediumTurquoise, 15, 30);
                    break;
                case 2:
                    return engelEkle(Color.SkyBlue, 50, 10);
                    break;
                default:
                    return null;

            }
            
        }
        private void ziplama_Tick(object sender, EventArgs e)
        {
            if (sinir==5)
            {
                artis = false;
                pb_oyuncu.Top -= pb_oyuncu.Height / 2;
            }

            if (artis)
            {
                pb_oyuncu.Top -= pb_oyuncu.Height / 2;
                sinir++;
            }
            else
            {
                pb_oyuncu.Top += pb_oyuncu.Height / 2;
                sinir--;
            }

            if (sinir == 0)
            {
                ziplama.Stop();
            }
        }

       

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode==Keys.W || e.KeyCode==Keys.Space || e.KeyCode==Keys.Up) && ziplama.Enabled==false)
            {
                artis = true;
                sinir = 1;
                ziplama.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ilkX = pb_oyuncu.Left;
            ilkY = pb_oyuncu.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void uretim_Tick(object sender, EventArgs e)
        {
            if (sayac < zorluk)
            {
                uret();
                sayac++;
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pb_oyuncu.Location = new Point(ilkX, ilkY);
            pb_oyuncu.Focus();

            sayac = 0;
            zorlukSayac = 0;
            puan = 0;
            zorluk = 1;
            lbl_puan.Text = String.Format("Puan : {0}",puan);
            lbl_zorluk.Text = String.Format("Zorluk : {0}", zorluk);
            foreach (PictureBox pictureBox in panel1.Controls)
            {
                if (pictureBox.Tag.ToString() == "engel")
                {
                    panel1.Controls.Remove(pictureBox);
                    engel.Clear();
                }
            }
            uret();
            ilerleme.Start();
            button1.Enabled = false;
        }


        private void ilerleme_Tick(object sender, EventArgs e)
        {

            if (engel[0].Tag.ToString() == "engel")
            {
                if (engel[0].Bounds.IntersectsWith(pb_oyuncu.Bounds))
                {
                    ilerleme.Stop();
                    ziplama.Stop();

                    MessageBox.Show("Oyunu kaybettin :(");
                    button1.Enabled = true;
                }
            }
            if (sayac == 0)
            {

                uret();
                sayac++;
            }
            else
            {
                if (engel[0].Right < 0)
                {
                    panel1.Controls.Remove(engel[0]);
                    engel.RemoveAt(0);
                    sayac--;
                    puan++;
                    zorlukSayac++;
                    lbl_puan.Text = String.Format("Puan : {0}", puan);

                    if (zorlukSayac == 2)
                    {
                        zorlukSayac = 0;
                        zorluk++;
                        lbl_zorluk.Text = String.Format("Zorluk : {0}", zorluk);
                        uretim.Start();
                    }

                }
                else
                {
                    for (int i = 0; i < engel.Count(); i++)
                    {
                        engel[i].Left -= (5 + zorluk);
                    }
                    
                }

            }

        }
    }
}
