namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btn_kategori = new System.Windows.Forms.Button();
            this.btn_urun_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kategori
            // 
            this.btn_kategori.Location = new System.Drawing.Point(46, 93);
            this.btn_kategori.Name = "btn_kategori";
            this.btn_kategori.Size = new System.Drawing.Size(99, 23);
            this.btn_kategori.TabIndex = 0;
            this.btn_kategori.Text = "Kategori Ekle";
            this.btn_kategori.UseVisualStyleBackColor = true;
            this.btn_kategori.Click += new System.EventHandler(this.btn_kategori_Click);
            // 
            // btn_urun_ekle
            // 
            this.btn_urun_ekle.Location = new System.Drawing.Point(182, 93);
            this.btn_urun_ekle.Name = "btn_urun_ekle";
            this.btn_urun_ekle.Size = new System.Drawing.Size(94, 23);
            this.btn_urun_ekle.TabIndex = 1;
            this.btn_urun_ekle.Text = "Urun Ekle";
            this.btn_urun_ekle.UseVisualStyleBackColor = true;
            this.btn_urun_ekle.Click += new System.EventHandler(this.btn_urun_ekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 272);
            this.Controls.Add(this.btn_urun_ekle);
            this.Controls.Add(this.btn_kategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kategori;
        private System.Windows.Forms.Button btn_urun_ekle;
    }
}

