using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Otomasyonu
{
    public partial class Hasta_Giris : Form
    {
        public Hasta_Giris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hasta_Kayit hk = new Hasta_Kayit();
            hk.Show();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_Hasta where HastaTC=@p1 and hastaSifre=@p2", bgl.baglanti());
            komut.Parameters.Add("@p1", msk_TC.Text);
            komut.Parameters.Add("@p2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                Hasta_Anasayfa fr = new Hasta_Anasayfa();
                fr.tc = msk_TC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C no ve ya Şifre...");
            }
            bgl.baglanti().Close();
        }
    }
}
