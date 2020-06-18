using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14Week_예제
{
    public partial class Form1 : Form
    {
        bool isDrag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
            label1.Text = "드래그 : 안하고 있음";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag == true)
            {
                label1.Text = "드래그 : 하고 있음";
            }
        }
    }
}
