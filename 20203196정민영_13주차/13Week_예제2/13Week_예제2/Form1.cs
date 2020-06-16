using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13Week_예제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point point1 = new Point(50, 10);
            Point point2 = new Point(280, 210);
            Pen pen1 = new Pen(Color.Black);
            Graphics g = this.CreateGraphics();
            g.DrawLine(pen1, point1, point2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point point1 = new Point(250, 60);
            Point point2 = new Point(200, 250);
            Pen pen1 = new Pen(Color.Red);
            Graphics g = this.CreateGraphics();
            g.DrawLine(pen1, point1, point2);
        }
    }
}
