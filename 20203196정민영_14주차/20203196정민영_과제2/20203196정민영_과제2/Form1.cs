using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영_과제2
{
    public partial class Form1 : Form
    {
        bool isDrag = false;
        Point previousPoint;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            previousPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDrag == true)
            {
                Pen currentPen;
                Point currentPoint = new Point(e.X, e.Y);

                if(comboBox1.SelectedIndex == 0)
                {
                    currentPen = new Pen(Color.Black);
                }
                else if(comboBox1.SelectedIndex == 1)
                {
                    currentPen = new Pen(Color.Red);
                }
                else if(comboBox1.SelectedIndex == 2)
                {
                    currentPen = new Pen(Color.Blue);
                }
                else
                {
                    currentPen = new Pen(Color.Yellow);
                }

                if (radioButton2.Checked == true)
                {
                    currentPen.Width = 3;
                }

                if(comboBox2.SelectedIndex == 0)
                {
                    currentPen.DashStyle =
                        System.Drawing.Drawing2D.DashStyle.Solid;
                }
                else if(comboBox2.SelectedIndex == 1)
                {
                    currentPen.DashStyle =
                        System.Drawing.Drawing2D.DashStyle.Dot;
                }
                else
                {
                    currentPen.DashStyle =
                        System.Drawing.Drawing2D.DashStyle.DashDot;
                }
                Graphics g = panel1.CreateGraphics();
                g.DrawLine(currentPen, previousPoint, currentPoint);
                previousPoint = currentPoint;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
