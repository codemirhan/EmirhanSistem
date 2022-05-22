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
    public partial class Hesaplama : Form
    {
        public Hesaplama()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double uzunluk = Convert.ToDouble(textBox1.Text);
            double agirlik = Convert.ToDouble(textBox2.Text);
            double yuvarlanmis1 = uzunluk / agirlik;
            double uzunlukc = uzunluk * 454;
            double agirlikb = 768 * agirlik;
            double yuvarlanmis2 = uzunlukc / agirlikb;
            double yuvarlanmis3 = agirlik / uzunluk * 1000;
            double yuvarlanmis4 = agirlik / uzunluk * 9000;
            double yuvarlanmis5 = agirlik / uzunluk * 10000;


            Math.Round(yuvarlanmis1);
            Math.Round(yuvarlanmis2);
            textBox8.Text = (yuvarlanmis1).ToString("0.");
            textBox7.Text = (yuvarlanmis2).ToString("0.");
            textBox6.Text = (yuvarlanmis3).ToString("0.");
            textBox5.Text = (yuvarlanmis4).ToString("0.");
            textBox3.Text = (yuvarlanmis5).ToString("0.");

        }
    }
}
