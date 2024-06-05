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
    public partial class Hasta_Bilgileri : Form
    {
        public Hasta_Bilgileri()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Hasta_Bilgileri_Load(object sender, EventArgs e)
        {
            txt_TC.Text = TCno;
            SqlCommand komut1 = new SqlCommand("select * from tbl_Hasta where hastatc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txt_TC.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                txt_Ad.Text = dr[1].ToString();
                txt_Soyad.Text = dr[2].ToString();
                txt_Tel.Text = dr[4].ToString();
                txt_Sifre.Text = dr[5].ToString();
                cmb_Cinsiyet.Text = dr[6].ToString();
            }
            dr.Close();
            bgl.baglanti().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_Hasta set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut2.Parameters.AddWithValue("@p3",txt_Tel.Text);
            komut2.Parameters.AddWithValue("@p4",txt_Sifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmb_Cinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", txt_TC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
