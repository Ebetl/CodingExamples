using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayilariBicimlendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 15000000;
            MessageBox.Show("Sayinin para hali=" +sayi.ToString("C"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1;
            sayi1 = 15000000;
            MessageBox.Show("Sayinin ondaliksiz normal hali=" + sayi1.ToString("C0"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1;
            sayi1 = 15000000;
            MessageBox.Show(sayi1.ToString("N")); // paraBirimi no defined.
        }
    }
}
