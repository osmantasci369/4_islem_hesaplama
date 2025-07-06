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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, total;

            bool sayi1=int.TryParse(textBox1.Text, out a);
            bool sayi2 = int.TryParse(textBox2.Text, out b);

            if (!sayi1 || !sayi2) 
            {
                MessageBox.Show ("Lütfen geçerli bir sayı girini ");
                return;
            }
            
            
                total = a + b;
                label4.Text=total.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            frm2.Show();
            this.Hide();
           
        }
    }
}
