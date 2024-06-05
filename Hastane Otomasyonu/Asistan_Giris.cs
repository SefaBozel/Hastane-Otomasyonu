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
    public partial class Asistan_Giris : Form
    {
        public Asistan_Giris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select * from tbl_Asistan where AsistanTC=@p1 and AsistanSifre=@p2", bgl.baglanti());
            komut1.Parameters.Add("@p1", txt_TC.Text);
            komut1.Parameters.Add("@p2", txt_Sifre.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                Asistan_Anasayfa fr = new Asistan_Anasayfa();
                fr.tcNo = txt_TC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C ve ya Şifre Girdiniz!");
            }
            bgl.baglanti().Close();
        }

        private void Asistan_Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
