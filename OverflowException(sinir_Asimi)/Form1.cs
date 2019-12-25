using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverflowException_sinir_Asimi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte x = 250;
            x += 100;
            MessageBox.Show(x.ToString(), "x in degeri");  /* x in tipi byte oldugu icin 0-255 arası deger alabilir,ama burda 350-256 yaparız ve cıktı 94 olur */

        }
    }
}
