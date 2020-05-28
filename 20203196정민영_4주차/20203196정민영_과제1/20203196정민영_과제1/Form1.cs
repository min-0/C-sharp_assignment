using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                if (iData01 < 0)
                {
                    textBox2.Text = "0보다 작은 값";
                }
                else if (iData01 < 10)
                    textBox2.Text = "0보다 크고 10보다 작은 수를 입력";
                else if (iData01 < 50)
                    textBox2.Text = "10보다 크고 50보다 작은 수를 입력";
                else if (iData01 < 100)
                    textBox2.Text = "50보다 크고 100보다 작은 수를 입력";
                else
                    textBox2.Text = "100보다 큰 수를 입력";
            }
            catch (Exception ee)
            {
                textBox2.Text = ee.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
