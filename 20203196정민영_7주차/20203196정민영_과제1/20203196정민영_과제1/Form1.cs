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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ulong initalVal = ulong.Parse(textBox1.Text);
                ulong limitVal = ulong.Parse(textBox2.Text);
                string sOutPut = "";
                ulong sumAdd = 0;
                ulong sumMulti = 1;
                if (initalVal >= 1)
                {
                    if (limitVal <= 20)
                    {
                        if (initalVal < limitVal)
                        {

                            for (ulong i = initalVal; i <= limitVal; i++)
                            {
                                sumAdd = sumAdd + i;
                                sumMulti = sumMulti * i;
                            }
                            sOutPut = initalVal + "부터" + limitVal + "까지의 합은" +
                             sumAdd + "\n 곱은" + sumMulti + "입니다";
                            label4.Text = sOutPut;
                        }
                        else
                        {
                            label3.Text = "시작값은 마지막 값 보다 작은값 이어야 합니다";
                        }
                    }
                    else
                    {
                        label3.Text = "마지막 값은 20 이하여야 합니다";
                    }
                }
                else 
                {
                    label3.Text = "시작 값은 0보다 큰 수 여야합니다";
                }
            }
            catch (Exception ee)
            {
                label4.Text = ee.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
