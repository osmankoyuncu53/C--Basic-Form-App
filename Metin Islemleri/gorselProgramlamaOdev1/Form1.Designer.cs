namespace gorselProgramlamaOdev1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yazi = new System.Windows.Forms.TextBox();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_islemKaydet = new System.Windows.Forms.Button();
            this.btn_islemYap = new System.Windows.Forms.Button();
            this.cmb_yapilacakIslem = new System.Windows.Forms.ComboBox();
            this.lst_ciktilar = new System.Windows.Forms.ListBox();
            this.lbl_bilgilendirme = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.txt_aranacakP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_yeni = new System.Windows.Forms.TextBox();
            this.txt_eski = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_adetS = new System.Windows.Forms.TextBox();
            this.txt_baslangic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(255, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yapılacak İşlem";
            // 
            // txt_yazi
            // 
            this.txt_yazi.Location = new System.Drawing.Point(53, 40);
            this.txt_yazi.Name = "txt_yazi";
            this.txt_yazi.Size = new System.Drawing.Size(121, 22);
            this.txt_yazi.TabIndex = 3;
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(128, 88);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(0, 17);
            this.lbl_sonuc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(57, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sonuç -";
            // 
            // btn_islemKaydet
            // 
            this.btn_islemKaydet.Location = new System.Drawing.Point(197, 127);
            this.btn_islemKaydet.Name = "btn_islemKaydet";
            this.btn_islemKaydet.Size = new System.Drawing.Size(109, 23);
            this.btn_islemKaydet.TabIndex = 6;
            this.btn_islemKaydet.Text = "İşlemi Kaydet";
            this.btn_islemKaydet.UseVisualStyleBackColor = true;
            this.btn_islemKaydet.Click += new System.EventHandler(this.btn_islemKaydet_Click);
            // 
            // btn_islemYap
            // 
            this.btn_islemYap.Location = new System.Drawing.Point(60, 127);
            this.btn_islemYap.Name = "btn_islemYap";
            this.btn_islemYap.Size = new System.Drawing.Size(109, 23);
            this.btn_islemYap.TabIndex = 7;
            this.btn_islemYap.Text = "İşlem Yap";
            this.btn_islemYap.UseVisualStyleBackColor = true;
            this.btn_islemYap.Click += new System.EventHandler(this.btn_islemYap_Click);
            // 
            // cmb_yapilacakIslem
            // 
            this.cmb_yapilacakIslem.FormattingEnabled = true;
            this.cmb_yapilacakIslem.Location = new System.Drawing.Point(187, 40);
            this.cmb_yapilacakIslem.Name = "cmb_yapilacakIslem";
            this.cmb_yapilacakIslem.Size = new System.Drawing.Size(240, 24);
            this.cmb_yapilacakIslem.TabIndex = 8;
            this.cmb_yapilacakIslem.SelectedIndexChanged += new System.EventHandler(this.cmb_yapilacakIslem_SelectedIndexChanged);
            // 
            // lst_ciktilar
            // 
            this.lst_ciktilar.FormattingEnabled = true;
            this.lst_ciktilar.ItemHeight = 16;
            this.lst_ciktilar.Location = new System.Drawing.Point(60, 180);
            this.lst_ciktilar.Name = "lst_ciktilar";
            this.lst_ciktilar.Size = new System.Drawing.Size(246, 244);
            this.lst_ciktilar.TabIndex = 9;
            // 
            // lbl_bilgilendirme
            // 
            this.lbl_bilgilendirme.AutoSize = true;
            this.lbl_bilgilendirme.Location = new System.Drawing.Point(361, 351);
            this.lbl_bilgilendirme.Name = "lbl_bilgilendirme";
            this.lbl_bilgilendirme.Size = new System.Drawing.Size(0, 17);
            this.lbl_bilgilendirme.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_adet);
            this.groupBox1.Controls.Add(this.txt_aranacakP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(364, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametreler";
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(167, 63);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(100, 22);
            this.txt_adet.TabIndex = 15;
            // 
            // txt_aranacakP
            // 
            this.txt_aranacakP.Location = new System.Drawing.Point(29, 63);
            this.txt_aranacakP.Name = "txt_aranacakP";
            this.txt_aranacakP.Size = new System.Drawing.Size(108, 22);
            this.txt_aranacakP.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aranacak Metin*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_yeni);
            this.groupBox2.Controls.Add(this.txt_eski);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(364, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 119);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametreler";
            // 
            // txt_yeni
            // 
            this.txt_yeni.Location = new System.Drawing.Point(167, 52);
            this.txt_yeni.Name = "txt_yeni";
            this.txt_yeni.Size = new System.Drawing.Size(100, 22);
            this.txt_yeni.TabIndex = 3;
            // 
            // txt_eski
            // 
            this.txt_eski.Location = new System.Drawing.Point(29, 52);
            this.txt_eski.Name = "txt_eski";
            this.txt_eski.Size = new System.Drawing.Size(100, 22);
            this.txt_eski.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Yeni";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Eski*";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_adetS);
            this.groupBox3.Controls.Add(this.txt_baslangic);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(364, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 109);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parametreler";
            // 
            // txt_adetS
            // 
            this.txt_adetS.Location = new System.Drawing.Point(167, 48);
            this.txt_adetS.Name = "txt_adetS";
            this.txt_adetS.Size = new System.Drawing.Size(100, 22);
            this.txt_adetS.TabIndex = 3;
            // 
            // txt_baslangic
            // 
            this.txt_baslangic.Location = new System.Drawing.Point(29, 48);
            this.txt_baslangic.Name = "txt_baslangic";
            this.txt_baslangic.Size = new System.Drawing.Size(100, 22);
            this.txt_baslangic.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Adet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Başlangıç*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_bilgilendirme);
            this.Controls.Add(this.lst_ciktilar);
            this.Controls.Add(this.cmb_yapilacakIslem);
            this.Controls.Add(this.btn_islemYap);
            this.Controls.Add(this.btn_islemKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.txt_yazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_yazi;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_islemKaydet;
        private System.Windows.Forms.Button btn_islemYap;
        private System.Windows.Forms.ComboBox cmb_yapilacakIslem;
        private System.Windows.Forms.ListBox lst_ciktilar;
        private System.Windows.Forms.Label lbl_bilgilendirme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.TextBox txt_aranacakP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_yeni;
        private System.Windows.Forms.TextBox txt_eski;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_adetS;
        private System.Windows.Forms.TextBox txt_baslangic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

