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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                double dData01 = double.Parse(textBox2.Text);
                if (iData01 == 1)
                {
                    dData01 = dData01 * 3.28;
                    textBox3.Text = dData01.ToString();
                }
                else if (iData01 == 2)
                {
                    dData01 = dData01 / 3.28;
                    textBox3.Text = dData01.ToString();
                }
                else
                    textBox1.Text = "1 또는 2를 입력하세요";
            }
            catch (Exception ee)
            {
                textBox3.Text = ee.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
