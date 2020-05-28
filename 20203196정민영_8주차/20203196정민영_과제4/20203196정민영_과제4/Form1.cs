using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영_과제4
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
                bool is_prime = false;
                uint iData01 = uint.Parse(textBox1.Text);
                for (int i = 2; i <= iData01 / 2; i++)
                {
                    if (iData01 % i == 0)
                    {
                        is_prime = true;
                            if (is_prime)
                            {
                            label3.Text = iData01.ToString() + "은 소수가 아닙니다!";
                            }
                             else
                            label3.Text = iData01.ToString() + "은 소수입니다!";
                    }
                }
            }
            catch(Exception ee)
            {
                label3.Text = ee.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
