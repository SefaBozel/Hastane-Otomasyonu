using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class Asistan_Anasayfa : Form
    {
        public Asistan_Anasayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tcNo;
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Asistan_Bilgileri ab = new Asistan_Bilgileri();
            ab.TCnumara = lbl_TC.Text;
            ab.Show();
        }

        private void btn_Doktor_Click(object sender, EventArgs e)
        {
            DoktorPaneli dp = new DoktorPaneli();
            dp.Show();
        }

        private void btn_Brans_Click(object sender, EventArgs e)
        {
            Brans bf = new Brans();
            bf.Show();
        }

        private void btn_Randevu_Click(object sender, EventArgs e)
        {
            Randevu_Listesi rl = new Randevu_Listesi();
            rl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Duyurular dp = new Duyurular();
            dp.Show();
        }

        private void Asistan_Anasayfa_Load(object sender, EventArgs e)
        {
            cmb_Doktor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Brans.DropDownStyle = ComboBoxStyle.DropDownList;
            
            lbl_TC.Text = tcNo;
            //AD-SOYAD ÇEKME
            SqlCommand komut1 = new SqlCommand("select asistanAd,AsistanSoyad from tbl_Asistan where AsistanTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbl_TC.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                lbl_AdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
            // Branşları Datagride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd From tbl_Brans", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            //Doktorları DataGride Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select DoktorBrans,(DoktorAd + ' ' + DoktorSoyad) as 'Doktor' From tbl_Doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            //Branşı Comboboxa Aktarma
            SqlCommand komut3 = new SqlCommand("Select BransAd from tbl_Brans", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmb_Brans.Items.Add(dr3[0]);
            }
            bgl.baglanti() .Close();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Insert into Tbl_Randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@r1", txt_Tarih.Text);
            komut2.Parameters.AddWithValue("@r2", txt_Saat.Text);
            komut2.Parameters.AddWithValue("@r3", cmb_Brans.Text);
            komut2.Parameters.AddWithValue("@r4", cmb_Doktor.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }

        private void cmb_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Doktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From tbl_Doktor where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmb_Brans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_Doktor.Items.Add(dr[0]+ " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btn_Duyuru_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into tbl_Duyuru (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",rch_Duyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }
    }
}
