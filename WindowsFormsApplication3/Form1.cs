using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racionales.Model;

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
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            int d2 = Convert.ToInt16(textBox4.Text);

            Racionales r1 = new Racionales(n1, d1);
            Racionales r2 = new Racionales(n2, d2);
            Racionales producto = r1.multiplicar(r2);

            textBox5.Text = producto.getNumerador().ToString();
            textBox6.Text = producto.getDenominador().ToString();
        }
    }
}
