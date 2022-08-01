namespace Alisveris
{
    partial class frm_AnaMenu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_bitir = new System.Windows.Forms.Button();
            this.txt_toplam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_tutar = new System.Windows.Forms.ListBox();
            this.list_adet = new System.Windows.Forms.ListBox();
            this.list_urun = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.btn_yukle = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vT_AlisverisDataSet = new Alisveris.VT_AlisverisDataSet();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vT_AlisverisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btn_bitir);
            this.groupBox2.Controls.Add(this.txt_toplam);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.list_tutar);
            this.groupBox2.Controls.Add(this.list_adet);
            this.groupBox2.Controls.Add(this.list_urun);
            this.groupBox2.Location = new System.Drawing.Point(13, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sepet";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ürün Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_bitir
            // 
            this.btn_bitir.Location = new System.Drawing.Point(303, 96);
            this.btn_bitir.Name = "btn_bitir";
            this.btn_bitir.Size = new System.Drawing.Size(90, 49);
            this.btn_bitir.TabIndex = 3;
            this.btn_bitir.Text = "Alışverişi Bitir";
            this.btn_bitir.UseVisualStyleBackColor = true;
            this.btn_bitir.Click += new System.EventHandler(this.btn_bitir_Click);
            // 
            // txt_toplam
            // 
            this.txt_toplam.Location = new System.Drawing.Point(303, 68);
            this.txt_toplam.Name = "txt_toplam";
            this.txt_toplam.ReadOnly = true;
            this.txt_toplam.Size = new System.Drawing.Size(90, 22);
            this.txt_toplam.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Tutar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // list_tutar
            // 
            this.list_tutar.FormattingEnabled = true;
            this.list_tutar.ItemHeight = 16;
            this.list_tutar.Location = new System.Drawing.Point(219, 47);
            this.list_tutar.Name = "list_tutar";
            this.list_tutar.Size = new System.Drawing.Size(78, 164);
            this.list_tutar.TabIndex = 0;
            // 
            // list_adet
            // 
            this.list_adet.FormattingEnabled = true;
            this.list_adet.ItemHeight = 16;
            this.list_adet.Location = new System.Drawing.Point(186, 47);
            this.list_adet.Name = "list_adet";
            this.list_adet.Size = new System.Drawing.Size(26, 164);
            this.list_adet.TabIndex = 0;
            // 
            // list_urun
            // 
            this.list_urun.FormattingEnabled = true;
            this.list_urun.ItemHeight = 16;
            this.list_urun.Location = new System.Drawing.Point(6, 47);
            this.list_urun.Name = "list_urun";
            this.list_urun.Size = new System.Drawing.Size(174, 164);
            this.list_urun.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bakiyeniz:";
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Location = new System.Drawing.Point(704, 34);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(64, 17);
            this.lbl_bakiye.TabIndex = 2;
            this.lbl_bakiye.Text = "k_bakiye";
            // 
            // btn_yukle
            // 
            this.btn_yukle.Location = new System.Drawing.Point(652, 64);
            this.btn_yukle.Name = "btn_yukle";
            this.btn_yukle.Size = new System.Drawing.Size(116, 23);
            this.btn_yukle.TabIndex = 3;
            this.btn_yukle.Text = "Para Yükle";
            this.btn_yukle.UseVisualStyleBackColor = true;
            this.btn_yukle.Click += new System.EventHandler(this.btn_yukle_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.vT_AlisverisDataSet;
            this.bindingSource1.Position = 0;
            // 
            // vT_AlisverisDataSet
            // 
            this.vT_AlisverisDataSet.DataSetName = "VT_AlisverisDataSet";
            this.vT_AlisverisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(569, 123);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // frm_AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_yukle);
            this.Controls.Add(this.lbl_bakiye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_AnaMenu";
            this.Text = "frm_AnaMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_AnaMenu_FormClosed);
            this.Load += new System.EventHandler(this.frm_AnaMenu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vT_AlisverisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_toplam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_tutar;
        private System.Windows.Forms.ListBox list_adet;
        private System.Windows.Forms.ListBox list_urun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Button btn_yukle;
        private System.Windows.Forms.Button btn_bitir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private VT_AlisverisDataSet vT_AlisverisDataSet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}