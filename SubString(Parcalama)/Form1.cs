using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubString_Parcalama_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade = "EbruBetul";
            string kesim = "";
            kesim = ifade.Substring(3,2);
            MessageBox.Show(kesim);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 2000; // yazının kayma hızı ayarlanıyor.Kodların ne kadar sürede tekrar edecegi. 200 ms 
            timer1.Enabled = true; //timer calısır. timer enabled true ise tick kısmı calısır.
        }

        private void timer1_Tick_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1); // ilk kısımda baslangıctan tüm kısmı alır + lı kısımda ise 0 dan baslayıp 1 de dahil olmak üzere elemanları ekler
            MessageBox.Show(textBox1.Text);
        }
    }
}
