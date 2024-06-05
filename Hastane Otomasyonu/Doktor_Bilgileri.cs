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
    public partial class Doktor_Bilgileri : Form
    {
        public Doktor_Bilgileri()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tcNO;
        private void Doktor_Bilgileri_Load(object sender, EventArgs e)
        {
            txt_TC.Text = tcNO;

            SqlCommand komut = new SqlCommand("Select * from tbl_Doktor where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_Ad.Text = dr[2].ToString();
                txt_Soyad.Text = dr[3].ToString();
                txt_Tel.Text = dr[5].ToString();
                cmb_Brans.Text = dr[1].ToString();
                txt_Sifre.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorTel=@p3,DoktorBrans=@p4,DoktorSifre=@p5 where DoktorTC=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", txt_Tel.Text);
            komut.Parameters.AddWithValue("@p4", cmb_Brans.Text);
            komut.Parameters.AddWithValue("@p5", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@p6", txt_TC.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Başarıyla Güncellenmiştir..");
        }
    }
}
