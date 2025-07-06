using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_işlem_hesaplama
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a, b, cikar;

            bool sayi1 = int.TryParse(textBox1.Text, out a);
            bool sayi2 = int.TryParse(textBox2.Text, out b);

            if (!sayi1 || !sayi2)
            {
                MessageBox.Show("Lütfen geçerli bir sayı girini ");
                return;
            }


            cikar = a - b;
            label4.Text = cikar.ToString();
        }
    }
}
