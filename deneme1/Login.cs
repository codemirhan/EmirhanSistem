namespace deneme1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="em" && textBox2.Text =="123")
                {
                MessageBox.Show("Giri� \n��lemi ba�ar�LI", "Bilgi",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Giri� \n��lemi ba�ar�s�z", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}