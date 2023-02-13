using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            double x = double.Parse(textBox1.Text);
            textBox4.Text += "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = Math.Sqrt(10 * (Math.Pow(x, 0.3333334) + Math.Pow(x, y+2)));
            double b = Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y);
            double u = Math.Round(a * b, 3);
            textBox4.Text += Environment.NewLine + "Beta = " + u.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
        }
    }
}
