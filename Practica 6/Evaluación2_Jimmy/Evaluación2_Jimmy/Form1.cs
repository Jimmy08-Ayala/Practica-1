using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluación2_Jimmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            textBox8.Visible = false;
        }
        double T1, T2, T3, L1, L2, L3;
        double Promedio;
        private void button1_Click(object sender, EventArgs e)
        {
            T1 = Convert.ToDouble(textBox1.Text);
            T2 = Convert.ToDouble(textBox2.Text);
            T3 = Convert.ToDouble(textBox3.Text);
            L1 = Convert.ToDouble(textBox4.Text);
            L2 = Convert.ToDouble(textBox5.Text);
            L3 = Convert.ToDouble(textBox6.Text);
            Promedio = (T1 + T2 + T3 + L1 + L2 + L3)/ 6;

            textBox7.Text = "" + Promedio;

            if (Promedio >=7)
            {
                pictureBox1.Visible = true;
                textBox8.Visible = true;
                pictureBox1.BackgroundImage = Image.FromFile("1.jpg");
                textBox8.Text = "PERFECTO! Sigue así >:D!";
            }
        }

        
    }
}
