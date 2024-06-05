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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Otomasyonu
{
    public partial class Hasta_Anasayfa : Form
    {
        public Hasta_Anasayfa()
        {
            InitializeComponent();
        }
        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Hasta_Bilgileri hb = new Hasta_Bilgileri();
            hb.TCno = lbl_TC.Text;
            hb.Show();
        }

        private void btn_RandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_Randevu set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where RandevuID=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_TC.Text);
            komut.Parameters.AddWithValue("@p2", txt_Sikayet.Text);
            komut.Parameters.AddWithValue("@p3", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Hasta_Anasayfa_Load(object sender, EventArgs e)
        {
            cmb_Brans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Doktor.DropDownStyle = ComboBoxStyle.DropDownList;


            lbl_TC.Text = tc;
            // AD SOYAD ÇEKME
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from tbl_Hasta where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_AdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
            //RANDEVU ÇEKME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_Randevu where hastaTC="+tc,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //BRANŞÇEKME
            SqlCommand komut2 = new SqlCommand("select BransAd from tbl_Brans",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_Brans.Items.Add(dr2[0]);
            }
            bgl.baglanti() .Close();
        }

        private void cmb_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from tbl_Doktor where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmb_Brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmb_Doktor.Items.Add(dr3[0]+ " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmb_Doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_Randevu WHERE RandevuBrans='" + cmb_Brans.Text + "' AND RandevuDoktor='" + cmb_Doktor.Text + "'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txt_ID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

    }
}
