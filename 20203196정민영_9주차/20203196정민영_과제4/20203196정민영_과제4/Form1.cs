using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영_과제4
{
    public partial class Form1 : Form
    {
        int Cnt = 0;
        double dResult = 0;
        bool bFirstTrue = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                double dPlusResult = double.Parse(textBox1.Text);
                Cnt++;
                if(bFirstTrue)
                {
                    label1.Text = "0 + " + dPlusResult;
                    bFirstTrue = false;
                }
                else
                {
                    label1.Text = label1.Text + " + " + dPlusResult;
                }
                dResult += dPlusResult;
                label2.Text = dResult.ToString();
                label3.Text = "수행 횟수 : " + Cnt;
            }
            catch(Exception ee)
            {
                label2.Text = ee.Message;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                double dMinusResult = double.Parse(textBox1.Text);
                Cnt++;
                if (bFirstTrue)
                {
                    label1.Text = "0 - " + dMinusResult;
                    bFirstTrue = false;
                }
                else
                {
                    label1.Text = label1.Text + " - " + dMinusResult;
                }
                dResult -= dMinusResult;
                label2.Text = dResult.ToString();
                label3.Text = "수행 횟수 : " + Cnt;
            }
            catch (Exception ee)
            {
                label2.Text = ee.Message;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                double dMultiResult = double.Parse(textBox1.Text);
                Cnt++;
                if (bFirstTrue)
                {
                    label1.Text = "0 * " + dMultiResult;
                    bFirstTrue = false;
                }
                else
                {
                    label1.Text = label1.Text + " * " + dMultiResult;
                }
                dResult *= dMultiResult;
                label2.Text = dResult.ToString();
                label3.Text = "수행 횟수 : " + Cnt;
            }
            catch (Exception ee)
            {
                label2.Text = ee.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double dDivResult = double.Parse(textBox1.Text);
                Cnt++;
                if (bFirstTrue)
                {
                    label1.Text = "0 / " + dDivResult;
                    bFirstTrue = false;
                }
                else
                {
                    label1.Text = label1.Text + " / " + dDivResult;
                }
                dResult /= dDivResult;
                label2.Text = dResult.ToString();
                label3.Text = "수행 횟수 : " + Cnt;
            }
            catch (Exception ee)
            {
                label2.Text = ee.Message;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            label1.Text = "수행단계:";
            label2.Text = "계산 결과: 결과가 나오는 곳입니다!";
            label3.Text = "계산 수행 횟수";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
