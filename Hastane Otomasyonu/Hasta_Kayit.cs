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
    public partial class Hasta_Kayit : Form
    {
        public Hasta_Kayit()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_Kayitol_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Hasta (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", txt_TC.Text);
            komut.Parameters.AddWithValue("@p4", txt_Tel.Text);
            komut.Parameters.AddWithValue("@p5", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@p6", cmb_Cinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Başarıyla Gerçekleşmiştir.\n Şifreniz: " + txt_Sifre.Text,"bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Hasta_Kayit_Load(object sender, EventArgs e)
        {
            cmb_Cinsiyet.Items.Add("Erkek");
            cmb_Cinsiyet.Items.Add("Kadın");
        }
    }
}
