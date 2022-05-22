using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokTakip stokTakip = new StokTakip();
            stokTakip.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cari cari = new Cari();
            cari.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hesaplama hesaplama = new Hesaplama();
            hesaplama.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ajanda ajanda = new Ajanda();
                ajanda.Show();
            this.Hide();
        }
    }
}
