using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int q;
        double qcost;
        double f;
        double fCost;
        double cantidad;
        double cantidadC;
        double m;
        double mCost;
        double totalPupusas;

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
             f= Convert.ToDouble(textBox2.Text);
            q= Convert.ToInt32(textBox1.Text);
            cantidad = Convert.ToDouble(textBox4.Text);
            m= Convert.ToDouble(textBox5.Text);
            fCost = f * 0.25;
            qcost = q * 0.75;
            cantidadC = cantidad * 0.70;
            mCost = m * 0.65;
            totalPupusas = fCost + qcost + cantidadC + mCost;
            textBox3.Text = "$" + Convert.ToInt32(totalPupusas);
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
