using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabanCevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long sayi;
            int taban_degeri;
            string sayi_olusumu = "";
            sayi = int.Parse(textBox1.Text);
            taban_degeri = Convert.ToInt16(textBox2.Text);
            long kalan_deger;
            while (sayi >= taban_degeri)
            {
                kalan_deger = sayi % taban_degeri;
            } 
        }
    }
}
