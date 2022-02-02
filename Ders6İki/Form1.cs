using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6İki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kelime = textBox1.Text;
            string[] parcalar;
            parcalar = kelime.Split(textBox2.Text.ToCharArray());
            label1.Text = parcalar[0];
            label2.Text = parcalar[1];
            label3.Text = parcalar[2];
            label4.Text = parcalar[3];      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox3.Text);
            switch (sayi)
            {
                case 0: label5.Text = "sıfır"; break;
                case 1: label5.Text = "bir"; break;
                case 2: label5.Text = "iki"; break;
                case 3: label5.Text = "üç"; break;
                case 4: label5.Text = "dört"; break;
                case 5: label5.Text = "beş"; break;
                case 6: label5.Text = "altı"; break;
                case 7: label5.Text = "yedi"; break;
                case 8: label5.Text = "sekiz"; break;
                default: label5.Text = "Hafızamda değil";
                    break;
            }
        }
    }
}
