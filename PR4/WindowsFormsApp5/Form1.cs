using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double f(double x)
        {
            if (radioButton1.Checked) return Math.Abs(Math.Sin(x));
            else if (radioButton2.Checked) return Math.Pow(x, 2);
            else if (radioButton3.Checked) return Math.Exp(x);
            else return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double b = double.Parse(textBox3.Text);
            textBox2.Text = "При x = " + x.ToString() + " и b = " + b.ToString() + ": ";
            double u = 0;
            if ((0.5 < x * b) && (x < 10)) u = Math.Exp(f(x) - b);
            else if ((0.1 < x * b) && (x < 0.5)) u = Math.Sqrt(Math.Abs(f(x) + b));
            else u = 2 * Math.Pow(f(x), 2);
            textBox2.Text += Environment.NewLine + "g = " + u.ToString();
        }
    }
}
