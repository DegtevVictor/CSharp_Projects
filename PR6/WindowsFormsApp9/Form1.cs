using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Point relPoint = this.PointToClient(Cursor.Position);
            x = relPoint.X;
            y = relPoint.Y;
            counter++;
            if (counter % 2 == 1)
            {
                TextBox txt = new TextBox() { Parent = this, Size = new Size(50, 35) };
                txt.Location = new Point(x - txt.Size.Width, y - txt.Size.Height);
            }
            else new Button() { Parent = this, Location = new Point(x, y), Size = new Size(50, 35) };
        }
    }
}
