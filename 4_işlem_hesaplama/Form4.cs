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
    public partial class Form4 : Form
    {
        public Form4()
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
            int a, b, carpma;

            bool sayi1 = int.TryParse(textBox1.Text, out a);
            bool sayi2 = int.TryParse(textBox2.Text, out b);

            if (!sayi1 || !sayi2 )
            {
                MessageBox.Show("Lütfen geçerli bir sayı girini ");
                return;
            }
            if (a == 0 || b == 0)
            {
                MessageBox.Show("Geçersiz giriş: 0 sayısı etkisiz elemandır. Lütfen geçerli bir sayı giriniz.");
            }


            carpma = a * b;
            label4.Text = carpma.ToString();

        }
    }
}
