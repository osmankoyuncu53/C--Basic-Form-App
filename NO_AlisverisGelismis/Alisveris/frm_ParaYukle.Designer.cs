namespace Alisveris
{
    partial class frm_ParaYukle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_yukle = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.txt_kAdi = new System.Windows.Forms.TextBox();
            this.txt_bakiye = new System.Windows.Forms.TextBox();
            this.txt_yukle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Güncel Bakiyeniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yüklenecek tutar:";
            // 
            // btn_yukle
            // 
            this.btn_yukle.Location = new System.Drawing.Point(116, 99);
            this.btn_yukle.Name = "btn_yukle";
            this.btn_yukle.Size = new System.Drawing.Size(75, 23);
            this.btn_yukle.TabIndex = 3;
            this.btn_yukle.Text = "Yükle";
            this.btn_yukle.UseVisualStyleBackColor = true;
            this.btn_yukle.Click += new System.EventHandler(this.btn_yukle_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackgroundImage = global::Alisveris.Properties.Resources.icon_27941_640;
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_geri.Location = new System.Drawing.Point(294, 92);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(44, 46);
            this.btn_geri.TabIndex = 3;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // txt_kAdi
            // 
            this.txt_kAdi.Location = new System.Drawing.Point(153, 19);
            this.txt_kAdi.Name = "txt_kAdi";
            this.txt_kAdi.ReadOnly = true;
            this.txt_kAdi.Size = new System.Drawing.Size(138, 22);
            this.txt_kAdi.TabIndex = 4;
            // 
            // txt_bakiye
            // 
            this.txt_bakiye.Location = new System.Drawing.Point(153, 45);
            this.txt_bakiye.Name = "txt_bakiye";
            this.txt_bakiye.ReadOnly = true;
            this.txt_bakiye.Size = new System.Drawing.Size(100, 22);
            this.txt_bakiye.TabIndex = 5;
            // 
            // txt_yukle
            // 
            this.txt_yukle.Location = new System.Drawing.Point(153, 71);
            this.txt_yukle.Name = "txt_yukle";
            this.txt_yukle.Size = new System.Drawing.Size(100, 22);
            this.txt_yukle.TabIndex = 6;
            // 
            // frm_ParaYukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 189);
            this.ControlBox = false;
            this.Controls.Add(this.txt_yukle);
            this.Controls.Add(this.txt_bakiye);
            this.Controls.Add(this.txt_kAdi);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_yukle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_ParaYukle";
            this.Text = "frm_ParaYukle";
            this.Load += new System.EventHandler(this.frm_ParaYukle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_yukle;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.TextBox txt_kAdi;
        private System.Windows.Forms.TextBox txt_bakiye;
        private System.Windows.Forms.TextBox txt_yukle;
    }
}