using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        double xTemp;
        public Form1()
        {
            InitializeComponent();
        }

        private bool condition_(double x, double xk)
        {
            if (xTemp < xk) return x <= xk;
            else return x >= xk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            double x0 = double.Parse(textBox1.Text);
            double xk = double.Parse(textBox2.Text);
            double dx = double.Parse(textBox3.Text);
            double b = double.Parse(textBox4.Text);

            double x = x0;
            xTemp = x;

            if (dx == 0)
            {
                MessageBox.Show("Шаг не должен быть нулевым");
                return;
            }

            if (((dx < 0) && (x < xk)) || ((dx > 0) && (x > xk)))
            {
                MessageBox.Show("Данный шаг при данных значениях приведёт к бесконечному циклу");
                return;
            }

            while (condition_(x, xk))
            {
                double y = Math.Pow(x, 2) + Math.Tan(5 * x + b / x);
                textBox5.Text += "x = " + x.ToString() + " | y = " + Math.Round(y, 4).ToString() + Environment.NewLine;
                x += dx;
            }
        }
    }
}
