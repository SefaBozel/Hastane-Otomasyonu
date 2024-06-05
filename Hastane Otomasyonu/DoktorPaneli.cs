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
    public partial class DoktorPaneli : Form
    {
        public DoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void DoktorPaneli_Load(object sender, EventArgs e)
        {
            cmb_Brans.DropDownStyle = ComboBoxStyle.DropDownList;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Doktor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları ComboBoxa Çekme
            SqlCommand komut = new SqlCommand("Select BransAd from tbl_Brans", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_Brans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Doktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre,DoktorTel,DoktorCinsiyet) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@d2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@d3", cmb_Brans.Text);
            komut.Parameters.AddWithValue("@d4", txt_TC.Text);
            komut.Parameters.AddWithValue("@d5", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@d6", txt_Tel.Text);
            komut.Parameters.AddWithValue("@d7", cmb_Cinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmb_Brans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_TC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_Tel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txt_Sifre.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmb_Cinsiyet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From tbl_Doktor where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txt_TC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Silindi.");
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE tbl_Doktor SET DoktorBrans=@d1, DoktorAd=@d2, DoktorSoyad=@d3, DoktorTel=@d5, DoktorSifre=@d6, DoktorCinsiyet=@d7 WHERE DoktorTC=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", cmb_Brans.Text);
            komut.Parameters.AddWithValue("@d2", txt_Ad.Text);
            komut.Parameters.AddWithValue("@d3", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@d4", txt_TC.Text);
            komut.Parameters.AddWithValue("@d5", txt_Tel.Text);
            komut.Parameters.AddWithValue("@d6", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@d7", cmb_Cinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
