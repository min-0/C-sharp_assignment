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
                uint iData01 = uint.Parse(textBox1.Text);
                uint iData02 = uint.Parse(textBox2.Text);
                if (iData01 >= iData02)
                {
                    uint iData_Sum = 0;
                    double iData_Sum2 = 1;
                    for (uint i = 1; i <= iData01; i = i + iData02)
                    {
                        iData_Sum = iData_Sum + i;
                        iData_Sum2 = iData_Sum2 * i;
                    }
                    label4.Text = "1 부터 입력된 최대값 :" + iData01 + " 까지 증가값 : " + iData02 + " 로 반복한 결과"
                        + "\n\n << i 의 더하기 합계 값 : " + iData_Sum + ">>\n\n" +
                        "<< i 의 곱하기 결과 값 : " + iData_Sum2 + ">>";
                }
                else
                    label4.Text = "증가값은 최대값보다 작은 수를 입력하세요";
            }
            catch (Exception ee)
            {
                label4.Text = ee.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "결과가 표시되는 곳입니다!";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
