using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Yuvarlama
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
            sayi = 15.3456378;
            MessageBox.Show("Sayinin ilk hali=" + Math.Round(sayi, 0).ToString());
            MessageBox.Show("Sayinin ikinci hali=" + Math.Round(sayi, 1).ToString());
            MessageBox.Show("Sayinin ücüncü hali=" + Math.Round(sayi, 2).ToString());
        }
    }
}
