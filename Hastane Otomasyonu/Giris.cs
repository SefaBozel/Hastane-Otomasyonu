using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hasta_Giris hg = new Hasta_Giris();
            hg.Show();
            this.Hide();
        }

        private void btn_Doktor_Click(object sender, EventArgs e)
        {
            Doktor_Giris dg = new Doktor_Giris();
            dg.Show();
            this.Hide();
        }

        private void btn_Asistan_Click(object sender, EventArgs e)
        {
            Asistan_Giris ag = new Asistan_Giris();
            ag.Show();
            this.Hide();
        }
    }
}
