using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영_과제3
{
    public partial class Form1 : Form
    {
        double dResult = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dPlusResult = double.Parse(textBox1.Text);
            dResult += dPlusResult;
            label1.Text = dResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dMinusResult = double.Parse(textBox1.Text);
            dResult -= dMinusResult; // dResult = dResult - dMinusResult
            label1.Text = dResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dMultiResult = double.Parse(textBox1.Text);
            dResult *= dMultiResult;
            label1.Text = dResult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dDivInput = double.Parse(textBox1.Text);
            if(dDivInput != 0)
            {
                dResult = dResult / dDivInput;
                label1.Text = dResult.ToString();
            }
            else
            {
                label1.Text = "0으로 나눌 수 없습니다";
                textBox1.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dResult = 0;
            label1.Text = "";
            textBox1.Text = "결과가 표시되는 곳입니다";
            textBox1.Text = dResult.ToString();
            textBox1.Focus();
        }
    }
}
