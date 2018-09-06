using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double havuz = double .Parse (textBox1 .Text );
            double tipa = double .Parse (textBox2 .Text );
            double saat = double.Parse(textBox3.Text);
            double sonuc = (havuz - (tipa * saat));

            if ((havuz - (tipa * saat) > 0))
            {
                MessageBox.Show("havuzda kalan su " + (havuz - (tipa * saat)).ToString() + " kalan saat = " + ((havuz - (tipa * saat)) / tipa).ToString());

            }
            else
            {
                MessageBox.Show("havuz boşalmıştır");
            }
        }
    }
}
