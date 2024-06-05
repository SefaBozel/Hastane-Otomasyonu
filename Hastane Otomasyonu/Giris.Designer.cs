namespace Hastane_Otomasyonu
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btn_Hasta = new System.Windows.Forms.Button();
            this.btn_Doktor = new System.Windows.Forms.Button();
            this.btn_Asistan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Hasta
            // 
            this.btn_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Hasta.Location = new System.Drawing.Point(159, 81);
            this.btn_Hasta.Name = "btn_Hasta";
            this.btn_Hasta.Size = new System.Drawing.Size(250, 74);
            this.btn_Hasta.TabIndex = 0;
            this.btn_Hasta.Text = "Hasta Giriş";
            this.btn_Hasta.UseVisualStyleBackColor = true;
            this.btn_Hasta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Doktor
            // 
            this.btn_Doktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Doktor.Location = new System.Drawing.Point(159, 176);
            this.btn_Doktor.Name = "btn_Doktor";
            this.btn_Doktor.Size = new System.Drawing.Size(250, 74);
            this.btn_Doktor.TabIndex = 1;
            this.btn_Doktor.Text = "Doktor Giriş";
            this.btn_Doktor.UseVisualStyleBackColor = true;
            this.btn_Doktor.Click += new System.EventHandler(this.btn_Doktor_Click);
            // 
            // btn_Asistan
            // 
            this.btn_Asistan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Asistan.Location = new System.Drawing.Point(159, 273);
            this.btn_Asistan.Name = "btn_Asistan";
            this.btn_Asistan.Size = new System.Drawing.Size(250, 74);
            this.btn_Asistan.TabIndex = 2;
            this.btn_Asistan.Text = "Asistan Giriş";
            this.btn_Asistan.UseVisualStyleBackColor = true;
            this.btn_Asistan.Click += new System.EventHandler(this.btn_Asistan_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.btn_Asistan);
            this.Controls.Add(this.btn_Doktor);
            this.Controls.Add(this.btn_Hasta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Hasta;
        private System.Windows.Forms.Button btn_Doktor;
        private System.Windows.Forms.Button btn_Asistan;
    }
}