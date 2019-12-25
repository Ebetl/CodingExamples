using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karsılastırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade = "";
            int sonuc;
            ifade = textBox1.Text;
            sonuc = string.Compare("Evet", ifade);
            if (sonuc == 0)
            { MessageBox.Show("Burs isteminde bulunamazsınız"); }
            else { MessageBox.Show("Burs islemeleri icin devam ediniz"); }
        }
    }
}
