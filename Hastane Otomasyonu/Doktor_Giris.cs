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
    public partial class Doktor_Giris : Form
    {
        public Doktor_Giris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_Doktor where doktorTC=@p1 and doktorSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_TC.Text);
            komut.Parameters.AddWithValue("@p2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Doktor_Anasayfa da = new Doktor_Anasayfa();
                da.TC = txt_TC.Text;
                da.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali TC yada Şifre Girişi..");
            }
            bgl.baglanti().Close();
        }
    }
}
