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
    public partial class Asistan_Bilgileri : Form
    {
        public Asistan_Bilgileri()
        {
            InitializeComponent();
        }
        public string TCnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Asistan_Bilgileri_Load(object sender, EventArgs e)
        {
            txt_TC.Text = TCnumara;
            SqlCommand komut1 = new SqlCommand("select * from tbl_Asistan where AsistanTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txt_TC.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                txt_Ad.Text = dr[1].ToString();
                txt_Soyad.Text = dr[2].ToString();
                txt_Tel.Text = dr[4].ToString();
                txt_Sifre.Text = dr[5].ToString();
                txt_Cinsiyet.Text = dr[6].ToString();
            }
            dr.Close();
            bgl.baglanti().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_Asistan set AsistanAd=@p1,AsistanSoyad=@p2,AsistanTel=@p3,AsistanSifre=@p4,AsistanCinsiyet=@p5 where AsistanTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut2.Parameters.AddWithValue("@p3", txt_Tel.Text);
            komut2.Parameters.AddWithValue("@p4", txt_Sifre.Text);
            komut2.Parameters.AddWithValue("@p5", txt_Cinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", txt_TC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
