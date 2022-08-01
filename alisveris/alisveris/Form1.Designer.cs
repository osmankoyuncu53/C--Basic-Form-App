namespace alisveris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_urunDVD = new System.Windows.Forms.Button();
            this.btn_urunCD = new System.Windows.Forms.Button();
            this.btn_urunKAGIT = new System.Windows.Forms.Button();
            this.btn_urunKASA = new System.Windows.Forms.Button();
            this.btn_urunBILGISAYAR = new System.Windows.Forms.Button();
            this.lbl_urunFiyatPC = new System.Windows.Forms.Label();
            this.lbl_urunFiyatKASA = new System.Windows.Forms.Label();
            this.lbl_urunFiyatKAGIT = new System.Windows.Forms.Label();
            this.lbl_urunFiyatCD = new System.Windows.Forms.Label();
            this.lbl_urunFiyatDVD = new System.Windows.Forms.Label();
            this.lbl_urunDVD = new System.Windows.Forms.Label();
            this.lbl_urunCD = new System.Windows.Forms.Label();
            this.lbl_urunKAGIT = new System.Windows.Forms.Label();
            this.lbl_urunKASA = new System.Windows.Forms.Label();
            this.lbl_urunBILGISAYAR = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btn_alisverisiBitir = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_toplamTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lst_urunTutar = new System.Windows.Forms.ListBox();
            this.lst_urunAdet = new System.Windows.Forms.ListBox();
            this.lst_urunAd = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.btn_paraYukle = new System.Windows.Forms.Button();
            this.grpBoxBakiye = new System.Windows.Forms.GroupBox();
            this.btn_yukle = new System.Windows.Forms.Button();
            this.txt_yuklenecekTutar = new System.Windows.Forms.TextBox();
            this.txt_guncelBakiye = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpBoxBakiye.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_urunDVD
            // 
            this.btn_urunDVD.Location = new System.Drawing.Point(12, 12);
            this.btn_urunDVD.Name = "btn_urunDVD";
            this.btn_urunDVD.Size = new System.Drawing.Size(89, 27);
            this.btn_urunDVD.TabIndex = 0;
            this.btn_urunDVD.Text = "Ürün 1";
            this.btn_urunDVD.UseVisualStyleBackColor = true;
            this.btn_urunDVD.Click += new System.EventHandler(this.btn_urunDVD_Click);
            // 
            // btn_urunCD
            // 
            this.btn_urunCD.Location = new System.Drawing.Point(12, 45);
            this.btn_urunCD.Name = "btn_urunCD";
            this.btn_urunCD.Size = new System.Drawing.Size(89, 27);
            this.btn_urunCD.TabIndex = 1;
            this.btn_urunCD.Text = "Ürün 2";
            this.btn_urunCD.UseVisualStyleBackColor = true;
            this.btn_urunCD.Click += new System.EventHandler(this.btn_urunCD_Click);
            // 
            // btn_urunKAGIT
            // 
            this.btn_urunKAGIT.Location = new System.Drawing.Point(12, 78);
            this.btn_urunKAGIT.Name = "btn_urunKAGIT";
            this.btn_urunKAGIT.Size = new System.Drawing.Size(89, 27);
            this.btn_urunKAGIT.TabIndex = 2;
            this.btn_urunKAGIT.Text = "Ürün 3";
            this.btn_urunKAGIT.UseVisualStyleBackColor = true;
            this.btn_urunKAGIT.Click += new System.EventHandler(this.btn_urunKAGIT_Click);
            // 
            // btn_urunKASA
            // 
            this.btn_urunKASA.Location = new System.Drawing.Point(12, 111);
            this.btn_urunKASA.Name = "btn_urunKASA";
            this.btn_urunKASA.Size = new System.Drawing.Size(89, 27);
            this.btn_urunKASA.TabIndex = 3;
            this.btn_urunKASA.Text = "Ürün 4";
            this.btn_urunKASA.UseVisualStyleBackColor = true;
            this.btn_urunKASA.Click += new System.EventHandler(this.btn_urunKASA_Click);
            // 
            // btn_urunBILGISAYAR
            // 
            this.btn_urunBILGISAYAR.Location = new System.Drawing.Point(12, 144);
            this.btn_urunBILGISAYAR.Name = "btn_urunBILGISAYAR";
            this.btn_urunBILGISAYAR.Size = new System.Drawing.Size(89, 27);
            this.btn_urunBILGISAYAR.TabIndex = 4;
            this.btn_urunBILGISAYAR.Text = "Ürün 5";
            this.btn_urunBILGISAYAR.UseVisualStyleBackColor = true;
            this.btn_urunBILGISAYAR.Click += new System.EventHandler(this.btn_urunBILGISAYAR_Click);
            // 
            // lbl_urunFiyatPC
            // 
            this.lbl_urunFiyatPC.AutoSize = true;
            this.lbl_urunFiyatPC.Location = new System.Drawing.Point(203, 149);
            this.lbl_urunFiyatPC.Name = "lbl_urunFiyatPC";
            this.lbl_urunFiyatPC.Size = new System.Drawing.Size(40, 17);
            this.lbl_urunFiyatPC.TabIndex = 5;
            this.lbl_urunFiyatPC.Text = "1500";
            // 
            // lbl_urunFiyatKASA
            // 
            this.lbl_urunFiyatKASA.AutoSize = true;
            this.lbl_urunFiyatKASA.Location = new System.Drawing.Point(203, 116);
            this.lbl_urunFiyatKASA.Name = "lbl_urunFiyatKASA";
            this.lbl_urunFiyatKASA.Size = new System.Drawing.Size(40, 17);
            this.lbl_urunFiyatKASA.TabIndex = 6;
            this.lbl_urunFiyatKASA.Text = "1000";
            // 
            // lbl_urunFiyatKAGIT
            // 
            this.lbl_urunFiyatKAGIT.AutoSize = true;
            this.lbl_urunFiyatKAGIT.Location = new System.Drawing.Point(203, 83);
            this.lbl_urunFiyatKAGIT.Name = "lbl_urunFiyatKAGIT";
            this.lbl_urunFiyatKAGIT.Size = new System.Drawing.Size(32, 17);
            this.lbl_urunFiyatKAGIT.TabIndex = 7;
            this.lbl_urunFiyatKAGIT.Text = "100";
            // 
            // lbl_urunFiyatCD
            // 
            this.lbl_urunFiyatCD.AutoSize = true;
            this.lbl_urunFiyatCD.Location = new System.Drawing.Point(203, 50);
            this.lbl_urunFiyatCD.Name = "lbl_urunFiyatCD";
            this.lbl_urunFiyatCD.Size = new System.Drawing.Size(32, 17);
            this.lbl_urunFiyatCD.TabIndex = 8;
            this.lbl_urunFiyatCD.Text = "250";
            // 
            // lbl_urunFiyatDVD
            // 
            this.lbl_urunFiyatDVD.AutoSize = true;
            this.lbl_urunFiyatDVD.Location = new System.Drawing.Point(203, 17);
            this.lbl_urunFiyatDVD.Name = "lbl_urunFiyatDVD";
            this.lbl_urunFiyatDVD.Size = new System.Drawing.Size(32, 17);
            this.lbl_urunFiyatDVD.TabIndex = 9;
            this.lbl_urunFiyatDVD.Text = "500";
            // 
            // lbl_urunDVD
            // 
            this.lbl_urunDVD.AutoSize = true;
            this.lbl_urunDVD.Location = new System.Drawing.Point(119, 16);
            this.lbl_urunDVD.Name = "lbl_urunDVD";
            this.lbl_urunDVD.Size = new System.Drawing.Size(37, 17);
            this.lbl_urunDVD.TabIndex = 10;
            this.lbl_urunDVD.Text = "DVD";
            // 
            // lbl_urunCD
            // 
            this.lbl_urunCD.AutoSize = true;
            this.lbl_urunCD.Location = new System.Drawing.Point(119, 50);
            this.lbl_urunCD.Name = "lbl_urunCD";
            this.lbl_urunCD.Size = new System.Drawing.Size(27, 17);
            this.lbl_urunCD.TabIndex = 11;
            this.lbl_urunCD.Text = "CD";
            // 
            // lbl_urunKAGIT
            // 
            this.lbl_urunKAGIT.AutoSize = true;
            this.lbl_urunKAGIT.Location = new System.Drawing.Point(119, 83);
            this.lbl_urunKAGIT.Name = "lbl_urunKAGIT";
            this.lbl_urunKAGIT.Size = new System.Drawing.Size(40, 17);
            this.lbl_urunKAGIT.TabIndex = 12;
            this.lbl_urunKAGIT.Text = "Kağıt";
            // 
            // lbl_urunKASA
            // 
            this.lbl_urunKASA.AutoSize = true;
            this.lbl_urunKASA.Location = new System.Drawing.Point(119, 116);
            this.lbl_urunKASA.Name = "lbl_urunKASA";
            this.lbl_urunKASA.Size = new System.Drawing.Size(40, 17);
            this.lbl_urunKASA.TabIndex = 13;
            this.lbl_urunKASA.Text = "Kasa";
            // 
            // lbl_urunBILGISAYAR
            // 
            this.lbl_urunBILGISAYAR.AutoSize = true;
            this.lbl_urunBILGISAYAR.Location = new System.Drawing.Point(119, 149);
            this.lbl_urunBILGISAYAR.Name = "lbl_urunBILGISAYAR";
            this.lbl_urunBILGISAYAR.Size = new System.Drawing.Size(69, 17);
            this.lbl_urunBILGISAYAR.TabIndex = 14;
            this.lbl_urunBILGISAYAR.Text = "Bilgisayar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.btn_alisverisiBitir);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_toplamTutar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lst_urunTutar);
            this.groupBox1.Controls.Add(this.lst_urunAdet);
            this.groupBox1.Controls.Add(this.lst_urunAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 235);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sepetim";
            // 
            // btn_temizle
            // 
            this.btn_temizle.ImageKey = "b.jpg";
            this.btn_temizle.ImageList = this.ımageList2;
            this.btn_temizle.Location = new System.Drawing.Point(308, 97);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(65, 46);
            this.btn_temizle.TabIndex = 20;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "b.jpg");
            // 
            // btn_alisverisiBitir
            // 
            this.btn_alisverisiBitir.ImageKey = "a.png";
            this.btn_alisverisiBitir.ImageList = this.ımageList1;
            this.btn_alisverisiBitir.Location = new System.Drawing.Point(234, 97);
            this.btn_alisverisiBitir.Name = "btn_alisverisiBitir";
            this.btn_alisverisiBitir.Size = new System.Drawing.Size(68, 46);
            this.btn_alisverisiBitir.TabIndex = 16;
            this.btn_alisverisiBitir.UseVisualStyleBackColor = true;
            this.btn_alisverisiBitir.Click += new System.EventHandler(this.btn_alisverisiBitir_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "a.png");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ürün Adı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Adet";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Tutar";
            // 
            // txt_toplamTutar
            // 
            this.txt_toplamTutar.Location = new System.Drawing.Point(234, 69);
            this.txt_toplamTutar.Name = "txt_toplamTutar";
            this.txt_toplamTutar.ReadOnly = true;
            this.txt_toplamTutar.Size = new System.Drawing.Size(139, 22);
            this.txt_toplamTutar.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Toplam Tutar";
            // 
            // lst_urunTutar
            // 
            this.lst_urunTutar.FormattingEnabled = true;
            this.lst_urunTutar.ItemHeight = 16;
            this.lst_urunTutar.Location = new System.Drawing.Point(137, 49);
            this.lst_urunTutar.Name = "lst_urunTutar";
            this.lst_urunTutar.Size = new System.Drawing.Size(91, 180);
            this.lst_urunTutar.TabIndex = 18;
            // 
            // lst_urunAdet
            // 
            this.lst_urunAdet.FormattingEnabled = true;
            this.lst_urunAdet.ItemHeight = 16;
            this.lst_urunAdet.Location = new System.Drawing.Point(103, 49);
            this.lst_urunAdet.Name = "lst_urunAdet";
            this.lst_urunAdet.Size = new System.Drawing.Size(28, 180);
            this.lst_urunAdet.TabIndex = 17;
            // 
            // lst_urunAd
            // 
            this.lst_urunAd.FormattingEnabled = true;
            this.lst_urunAd.ItemHeight = 16;
            this.lst_urunAd.Location = new System.Drawing.Point(6, 49);
            this.lst_urunAd.Name = "lst_urunAd";
            this.lst_urunAd.Size = new System.Drawing.Size(91, 180);
            this.lst_urunAd.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(579, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Bakiyeniz:";
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Location = new System.Drawing.Point(676, 16);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(54, 17);
            this.lbl_bakiye.TabIndex = 17;
            this.lbl_bakiye.Text = "label16";
            // 
            // btn_paraYukle
            // 
            this.btn_paraYukle.Location = new System.Drawing.Point(622, 45);
            this.btn_paraYukle.Name = "btn_paraYukle";
            this.btn_paraYukle.Size = new System.Drawing.Size(108, 23);
            this.btn_paraYukle.TabIndex = 18;
            this.btn_paraYukle.Text = "Para Yükle";
            this.btn_paraYukle.UseVisualStyleBackColor = true;
            this.btn_paraYukle.Click += new System.EventHandler(this.btn_paraYukle_Click);
            // 
            // grpBoxBakiye
            // 
            this.grpBoxBakiye.BackColor = System.Drawing.Color.Peru;
            this.grpBoxBakiye.Controls.Add(this.btn_yukle);
            this.grpBoxBakiye.Controls.Add(this.txt_yuklenecekTutar);
            this.grpBoxBakiye.Controls.Add(this.txt_guncelBakiye);
            this.grpBoxBakiye.Controls.Add(this.label17);
            this.grpBoxBakiye.Controls.Add(this.label18);
            this.grpBoxBakiye.Location = new System.Drawing.Point(473, 306);
            this.grpBoxBakiye.Name = "grpBoxBakiye";
            this.grpBoxBakiye.Size = new System.Drawing.Size(257, 132);
            this.grpBoxBakiye.TabIndex = 19;
            this.grpBoxBakiye.TabStop = false;
            this.grpBoxBakiye.Text = "Bakiye";
            // 
            // btn_yukle
            // 
            this.btn_yukle.ImageKey = "(yok)";
            this.btn_yukle.Location = new System.Drawing.Point(116, 89);
            this.btn_yukle.Name = "btn_yukle";
            this.btn_yukle.Size = new System.Drawing.Size(75, 24);
            this.btn_yukle.TabIndex = 20;
            this.btn_yukle.Text = "Yükle";
            this.btn_yukle.UseVisualStyleBackColor = true;
            this.btn_yukle.Click += new System.EventHandler(this.btn_yukle_Click);
            // 
            // txt_yuklenecekTutar
            // 
            this.txt_yuklenecekTutar.Location = new System.Drawing.Point(151, 61);
            this.txt_yuklenecekTutar.Name = "txt_yuklenecekTutar";
            this.txt_yuklenecekTutar.Size = new System.Drawing.Size(100, 22);
            this.txt_yuklenecekTutar.TabIndex = 23;
            // 
            // txt_guncelBakiye
            // 
            this.txt_guncelBakiye.Location = new System.Drawing.Point(151, 29);
            this.txt_guncelBakiye.Name = "txt_guncelBakiye";
            this.txt_guncelBakiye.ReadOnly = true;
            this.txt_guncelBakiye.Size = new System.Drawing.Size(100, 22);
            this.txt_guncelBakiye.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Yüklenecek Tutar:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "Güncel Bakiye: ";
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "karakalem.jpg");
            // 
            // label1
            // 
            this.label1.ImageKey = "karakalem.jpg";
            this.label1.ImageList = this.ımageList3;
            this.label1.Location = new System.Drawing.Point(470, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 167);
            this.label1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBoxBakiye);
            this.Controls.Add(this.btn_paraYukle);
            this.Controls.Add(this.lbl_bakiye);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_urunBILGISAYAR);
            this.Controls.Add(this.lbl_urunKASA);
            this.Controls.Add(this.lbl_urunKAGIT);
            this.Controls.Add(this.lbl_urunCD);
            this.Controls.Add(this.lbl_urunDVD);
            this.Controls.Add(this.lbl_urunFiyatDVD);
            this.Controls.Add(this.lbl_urunFiyatCD);
            this.Controls.Add(this.lbl_urunFiyatKAGIT);
            this.Controls.Add(this.lbl_urunFiyatKASA);
            this.Controls.Add(this.lbl_urunFiyatPC);
            this.Controls.Add(this.btn_urunBILGISAYAR);
            this.Controls.Add(this.btn_urunKASA);
            this.Controls.Add(this.btn_urunKAGIT);
            this.Controls.Add(this.btn_urunCD);
            this.Controls.Add(this.btn_urunDVD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxBakiye.ResumeLayout(false);
            this.grpBoxBakiye.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_urunDVD;
        private System.Windows.Forms.Button btn_urunCD;
        private System.Windows.Forms.Button btn_urunKAGIT;
        private System.Windows.Forms.Button btn_urunKASA;
        private System.Windows.Forms.Button btn_urunBILGISAYAR;
        private System.Windows.Forms.Label lbl_urunFiyatPC;
        private System.Windows.Forms.Label lbl_urunFiyatKASA;
        private System.Windows.Forms.Label lbl_urunFiyatKAGIT;
        private System.Windows.Forms.Label lbl_urunFiyatCD;
        private System.Windows.Forms.Label lbl_urunFiyatDVD;
        private System.Windows.Forms.Label lbl_urunDVD;
        private System.Windows.Forms.Label lbl_urunCD;
        private System.Windows.Forms.Label lbl_urunKAGIT;
        private System.Windows.Forms.Label lbl_urunKASA;
        private System.Windows.Forms.Label lbl_urunBILGISAYAR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button btn_alisverisiBitir;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_toplamTutar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lst_urunTutar;
        private System.Windows.Forms.ListBox lst_urunAdet;
        private System.Windows.Forms.ListBox lst_urunAd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Button btn_paraYukle;
        private System.Windows.Forms.GroupBox grpBoxBakiye;
        private System.Windows.Forms.Button btn_yukle;
        private System.Windows.Forms.TextBox txt_yuklenecekTutar;
        private System.Windows.Forms.TextBox txt_guncelBakiye;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.Label label1;
    }
}

