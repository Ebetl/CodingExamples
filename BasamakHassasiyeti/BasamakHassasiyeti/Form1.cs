using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasamakHassasiyeti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi1;
            double sayi2;
            decimal sayi3;
            sayi1 = 123456789;
            sayi2 = 123456789;
            sayi3 = 123456789;
            MessageBox.Show(sayi1.ToString(), "Sayi 1 in degeri");
            MessageBox.Show(sayi2.ToString(), "Sayi 2 nin degeri");
            MessageBox.Show(sayi3.ToString(), "sayi 3 ün degeri");
        }
    }
}
