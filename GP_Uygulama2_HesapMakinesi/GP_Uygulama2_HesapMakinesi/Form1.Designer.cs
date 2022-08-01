namespace GP_Uygulama2_HesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_islem = new System.Windows.Forms.TextBox();
            this.lbl_islem = new System.Windows.Forms.Label();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_toplama = new System.Windows.Forms.Button();
            this.btn_cikarma = new System.Windows.Forms.Button();
            this.btn_bolme = new System.Windows.Forms.Button();
            this.btn_carpma = new System.Windows.Forms.Button();
            this.btn_karakterSil = new System.Windows.Forms.Button();
            this.btn_textTemizle = new System.Windows.Forms.Button();
            this.btn_fullTemizle = new System.Windows.Forms.Button();
            this.btn_esittir = new System.Windows.Forms.Button();
            this.btn_ondalik = new System.Windows.Forms.Button();
            this.btn_karesi = new System.Windows.Forms.Button();
            this.btn_kuvvet = new System.Windows.Forms.Button();
            this.btn_karekok = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_faktoriyel = new System.Windows.Forms.Button();
            this.btn_islemDegis = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_islem
            // 
            this.txt_islem.Location = new System.Drawing.Point(9, 21);
            this.txt_islem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_islem.Multiline = true;
            this.txt_islem.Name = "txt_islem";
            this.txt_islem.Size = new System.Drawing.Size(185, 46);
            this.txt_islem.TabIndex = 0;
            this.txt_islem.TextChanged += new System.EventHandler(this.txt_islem_TextChanged);
            this.txt_islem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_islem_KeyPress);
            // 
            // lbl_islem
            // 
            this.lbl_islem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_islem.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_islem.Location = new System.Drawing.Point(124, 47);
            this.lbl_islem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_islem.Name = "lbl_islem";
            this.lbl_islem.Size = new System.Drawing.Size(62, 15);
            this.lbl_islem.TabIndex = 1;
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.Gray;
            this.btn_7.Location = new System.Drawing.Point(8, 178);
            this.btn_7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(28, 28);
            this.btn_7.TabIndex = 2;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.ekle);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.Gray;
            this.btn_8.Location = new System.Drawing.Point(41, 178);
            this.btn_8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(28, 28);
            this.btn_8.TabIndex = 3;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.ekle);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.Gray;
            this.btn_9.Location = new System.Drawing.Point(74, 178);
            this.btn_9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(28, 28);
            this.btn_9.TabIndex = 4;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.ekle);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.Gray;
            this.btn_4.Location = new System.Drawing.Point(8, 211);
            this.btn_4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(28, 28);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.ekle);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Gray;
            this.btn_5.Location = new System.Drawing.Point(41, 211);
            this.btn_5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(28, 28);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.ekle);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Gray;
            this.btn_6.Location = new System.Drawing.Point(74, 211);
            this.btn_6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(28, 28);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.ekle);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Gray;
            this.btn_1.Location = new System.Drawing.Point(8, 245);
            this.btn_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(28, 28);
            this.btn_1.TabIndex = 8;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.ekle);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Gray;
            this.btn_2.Location = new System.Drawing.Point(41, 245);
            this.btn_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(28, 28);
            this.btn_2.TabIndex = 9;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.ekle);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Gray;
            this.btn_3.Location = new System.Drawing.Point(74, 245);
            this.btn_3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(28, 28);
            this.btn_3.TabIndex = 10;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.ekle);
            // 
            // btn_toplama
            // 
            this.btn_toplama.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_toplama.Location = new System.Drawing.Point(130, 128);
            this.btn_toplama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_toplama.Name = "btn_toplama";
            this.btn_toplama.Size = new System.Drawing.Size(28, 28);
            this.btn_toplama.TabIndex = 11;
            this.btn_toplama.Text = "+";
            this.btn_toplama.UseVisualStyleBackColor = false;
            this.btn_toplama.Click += new System.EventHandler(this.btn_toplama_Click);
            // 
            // btn_cikarma
            // 
            this.btn_cikarma.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_cikarma.Location = new System.Drawing.Point(164, 128);
            this.btn_cikarma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cikarma.Name = "btn_cikarma";
            this.btn_cikarma.Size = new System.Drawing.Size(28, 28);
            this.btn_cikarma.TabIndex = 12;
            this.btn_cikarma.Text = "-";
            this.btn_cikarma.UseVisualStyleBackColor = false;
            this.btn_cikarma.Click += new System.EventHandler(this.btn_cikarma_Click);
            // 
            // btn_bolme
            // 
            this.btn_bolme.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_bolme.Location = new System.Drawing.Point(164, 95);
            this.btn_bolme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bolme.Name = "btn_bolme";
            this.btn_bolme.Size = new System.Drawing.Size(28, 28);
            this.btn_bolme.TabIndex = 13;
            this.btn_bolme.Text = "/";
            this.btn_bolme.UseVisualStyleBackColor = false;
            this.btn_bolme.Click += new System.EventHandler(this.btn_bolme_Click);
            // 
            // btn_carpma
            // 
            this.btn_carpma.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_carpma.Location = new System.Drawing.Point(130, 95);
            this.btn_carpma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_carpma.Name = "btn_carpma";
            this.btn_carpma.Size = new System.Drawing.Size(28, 28);
            this.btn_carpma.TabIndex = 14;
            this.btn_carpma.Text = "*";
            this.btn_carpma.UseVisualStyleBackColor = false;
            this.btn_carpma.Click += new System.EventHandler(this.btn_carpma_Click);
            // 
            // btn_karakterSil
            // 
            this.btn_karakterSil.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_karakterSil.Location = new System.Drawing.Point(160, 178);
            this.btn_karakterSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_karakterSil.Name = "btn_karakterSil";
            this.btn_karakterSil.Size = new System.Drawing.Size(32, 28);
            this.btn_karakterSil.TabIndex = 15;
            this.btn_karakterSil.Text = "<--";
            this.btn_karakterSil.UseVisualStyleBackColor = false;
            this.btn_karakterSil.Click += new System.EventHandler(this.btn_karakterSil_Click);
            // 
            // btn_textTemizle
            // 
            this.btn_textTemizle.Location = new System.Drawing.Point(160, 211);
            this.btn_textTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_textTemizle.Name = "btn_textTemizle";
            this.btn_textTemizle.Size = new System.Drawing.Size(32, 28);
            this.btn_textTemizle.TabIndex = 16;
            this.btn_textTemizle.Text = "CE";
            this.btn_textTemizle.UseVisualStyleBackColor = true;
            this.btn_textTemizle.Click += new System.EventHandler(this.btn_textTemizle_Click);
            // 
            // btn_fullTemizle
            // 
            this.btn_fullTemizle.Location = new System.Drawing.Point(160, 245);
            this.btn_fullTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_fullTemizle.Name = "btn_fullTemizle";
            this.btn_fullTemizle.Size = new System.Drawing.Size(32, 28);
            this.btn_fullTemizle.TabIndex = 17;
            this.btn_fullTemizle.Text = "C";
            this.btn_fullTemizle.UseVisualStyleBackColor = true;
            this.btn_fullTemizle.Click += new System.EventHandler(this.btn_fullTemizle_Click);
            // 
            // btn_esittir
            // 
            this.btn_esittir.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_esittir.Location = new System.Drawing.Point(130, 278);
            this.btn_esittir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_esittir.Name = "btn_esittir";
            this.btn_esittir.Size = new System.Drawing.Size(62, 28);
            this.btn_esittir.TabIndex = 18;
            this.btn_esittir.Text = "=";
            this.btn_esittir.UseVisualStyleBackColor = false;
            this.btn_esittir.Click += new System.EventHandler(this.btn_esittir_Click);
            // 
            // btn_ondalik
            // 
            this.btn_ondalik.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_ondalik.Location = new System.Drawing.Point(9, 278);
            this.btn_ondalik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ondalik.Name = "btn_ondalik";
            this.btn_ondalik.Size = new System.Drawing.Size(28, 28);
            this.btn_ondalik.TabIndex = 19;
            this.btn_ondalik.Text = ",";
            this.btn_ondalik.UseVisualStyleBackColor = false;
            this.btn_ondalik.Click += new System.EventHandler(this.btn_ondalik_Click);
            // 
            // btn_karesi
            // 
            this.btn_karesi.Location = new System.Drawing.Point(8, 95);
            this.btn_karesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_karesi.Name = "btn_karesi";
            this.btn_karesi.Size = new System.Drawing.Size(28, 28);
            this.btn_karesi.TabIndex = 20;
            this.btn_karesi.Text = "x²";
            this.btn_karesi.UseVisualStyleBackColor = true;
            this.btn_karesi.Click += new System.EventHandler(this.btn_karesi_Click);
            // 
            // btn_kuvvet
            // 
            this.btn_kuvvet.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_kuvvet.Location = new System.Drawing.Point(74, 95);
            this.btn_kuvvet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_kuvvet.Name = "btn_kuvvet";
            this.btn_kuvvet.Size = new System.Drawing.Size(28, 28);
            this.btn_kuvvet.TabIndex = 21;
            this.btn_kuvvet.Text = "x^";
            this.btn_kuvvet.UseVisualStyleBackColor = false;
            this.btn_kuvvet.Click += new System.EventHandler(this.btn_kuvvet_Click);
            // 
            // btn_karekok
            // 
            this.btn_karekok.Location = new System.Drawing.Point(74, 128);
            this.btn_karekok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_karekok.Name = "btn_karekok";
            this.btn_karekok.Size = new System.Drawing.Size(28, 28);
            this.btn_karekok.TabIndex = 22;
            this.btn_karekok.Text = "√";
            this.btn_karekok.UseVisualStyleBackColor = true;
            this.btn_karekok.Click += new System.EventHandler(this.btn_karekok_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_mod.Location = new System.Drawing.Point(41, 95);
            this.btn_mod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(28, 28);
            this.btn_mod.TabIndex = 23;
            this.btn_mod.Text = "%";
            this.btn_mod.UseVisualStyleBackColor = false;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_faktoriyel
            // 
            this.btn_faktoriyel.Location = new System.Drawing.Point(8, 128);
            this.btn_faktoriyel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_faktoriyel.Name = "btn_faktoriyel";
            this.btn_faktoriyel.Size = new System.Drawing.Size(28, 28);
            this.btn_faktoriyel.TabIndex = 24;
            this.btn_faktoriyel.Text = "x!";
            this.btn_faktoriyel.UseVisualStyleBackColor = true;
            this.btn_faktoriyel.Click += new System.EventHandler(this.btn_faktoriyel_Click);
            // 
            // btn_islemDegis
            // 
            this.btn_islemDegis.Location = new System.Drawing.Point(41, 128);
            this.btn_islemDegis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_islemDegis.Name = "btn_islemDegis";
            this.btn_islemDegis.Size = new System.Drawing.Size(28, 28);
            this.btn_islemDegis.TabIndex = 25;
            this.btn_islemDegis.Text = "±";
            this.btn_islemDegis.UseVisualStyleBackColor = true;
            this.btn_islemDegis.Click += new System.EventHandler(this.btn_islemDegis_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.Gray;
            this.btn_0.Location = new System.Drawing.Point(42, 278);
            this.btn_0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(62, 28);
            this.btn_0.TabIndex = 26;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.ekle);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Özel Fonksiyonlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(204, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_islemDegis);
            this.Controls.Add(this.btn_faktoriyel);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_karekok);
            this.Controls.Add(this.btn_kuvvet);
            this.Controls.Add(this.btn_karesi);
            this.Controls.Add(this.btn_ondalik);
            this.Controls.Add(this.btn_esittir);
            this.Controls.Add(this.btn_fullTemizle);
            this.Controls.Add(this.btn_textTemizle);
            this.Controls.Add(this.btn_karakterSil);
            this.Controls.Add(this.btn_carpma);
            this.Controls.Add(this.btn_bolme);
            this.Controls.Add(this.btn_cikarma);
            this.Controls.Add(this.btn_toplama);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.lbl_islem);
            this.Controls.Add(this.txt_islem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_islem;
        private System.Windows.Forms.Label lbl_islem;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_toplama;
        private System.Windows.Forms.Button btn_cikarma;
        private System.Windows.Forms.Button btn_bolme;
        private System.Windows.Forms.Button btn_carpma;
        private System.Windows.Forms.Button btn_karakterSil;
        private System.Windows.Forms.Button btn_textTemizle;
        private System.Windows.Forms.Button btn_fullTemizle;
        private System.Windows.Forms.Button btn_esittir;
        private System.Windows.Forms.Button btn_ondalik;
        private System.Windows.Forms.Button btn_karesi;
        private System.Windows.Forms.Button btn_kuvvet;
        private System.Windows.Forms.Button btn_karekok;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_faktoriyel;
        private System.Windows.Forms.Button btn_islemDegis;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Label label2;
    }
}

