using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Week_예제2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int iData01 = int.Parse(textBox1.Text);
                    label1.Text = "결과는 " + iData01 + " 입니다";
                }
                catch (Exception ee)
                {
                    label1.Text = ee.Message;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double dData01 = double.Parse(textBox1.Text);
                label1.Text = "결과는 " + dData01 + " 입니다";
            }
            catch (Exception ee)
            {
                label1.Text = ee.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sData01 = textBox1.Text;
                sData01 = "홍길동";
                label1.Text = "결과는 " + sData01 + " 입니다";
            }
            catch (Exception ee)
            {
                label1.Text = ee.Message;
            }
        }
    }
}
