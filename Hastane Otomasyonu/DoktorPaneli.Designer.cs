﻿namespace Hastane_Otomasyonu
{
    partial class DoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.cmb_Brans = new System.Windows.Forms.ComboBox();
            this.cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.txt_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_Tel = new System.Windows.Forms.MaskedTextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "T.C. No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Şifre:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(146, 26);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(135, 30);
            this.txt_Ad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefon No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cinsiyet:";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(146, 62);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(135, 30);
            this.txt_Soyad.TabIndex = 2;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(146, 173);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(135, 30);
            this.txt_Sifre.TabIndex = 5;
            // 
            // cmb_Brans
            // 
            this.cmb_Brans.FormattingEnabled = true;
            this.cmb_Brans.Location = new System.Drawing.Point(146, 98);
            this.cmb_Brans.Name = "cmb_Brans";
            this.cmb_Brans.Size = new System.Drawing.Size(135, 33);
            this.cmb_Brans.TabIndex = 3;
            // 
            // cmb_Cinsiyet
            // 
            this.cmb_Cinsiyet.FormattingEnabled = true;
            this.cmb_Cinsiyet.Location = new System.Drawing.Point(146, 245);
            this.cmb_Cinsiyet.Name = "cmb_Cinsiyet";
            this.cmb_Cinsiyet.Size = new System.Drawing.Size(135, 33);
            this.cmb_Cinsiyet.TabIndex = 7;
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(146, 137);
            this.txt_TC.Mask = "00000000000";
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(135, 30);
            this.txt_TC.TabIndex = 4;
            this.txt_TC.ValidatingType = typeof(int);
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(146, 209);
            this.txt_Tel.Mask = "(999) 000-0000";
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(135, 30);
            this.txt_Tel.TabIndex = 6;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(34, 301);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(120, 36);
            this.btn_Ekle.TabIndex = 8;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(164, 301);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(120, 36);
            this.btn_Sil.TabIndex = 9;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(901, 353);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(94, 343);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(128, 36);
            this.btn_Guncelle.TabIndex = 10;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // DoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1203, 393);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.cmb_Cinsiyet);
            this.Controls.Add(this.cmb_Brans);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DoktorPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.DoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.ComboBox cmb_Brans;
        private System.Windows.Forms.ComboBox cmb_Cinsiyet;
        private System.Windows.Forms.MaskedTextBox txt_TC;
        private System.Windows.Forms.MaskedTextBox txt_Tel;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Guncelle;
    }
}