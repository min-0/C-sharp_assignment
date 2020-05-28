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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01=int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                string sData01 = textBox3.Text;
                if (sData01 == "") label6.Text = "Operator에 관계연산자 하나를 입력하세요!";
                else
                {
                    if (sData01 == "=="|| sData01 == "!=" || sData01 == ">" || sData01 == "<" || sData01 == ">=" || sData01 == "<=")
                    {
                        bool bData01 = iData01 == iData02;
                        label6.Text = iData01 + sData01 + iData02 +
                            "의 결과는" + bData01;
                    }
                    else if (sData01 == "!==")
                    {
                        bool bData01 = iData01 != iData02;
                        label6.Text = iData01 + sData01 + iData02 +
                            "의 결과는" + bData01;
                    }
                    else if (sData01 == ">")
                    {
                        bool bData01 = iData01 > iData02;
                        label6.Text = iData01 + sData01 + iData02 +
                            "의 결과는" + bData01;
                    }
                    else if (sData01 == "<")
                    {
                        bool bData01 = iData01 < iData02;
                        label6.Text = iData01 + sData01 + iData02 +
                            "의 결과는" + bData01;
                    }
                    else if (sData01 == "<=")
                    {
                        bool bData01 = iData01 <= iData02;
                        label6.Text = iData01 + sData01 + iData02 +
                            "의 결과는" + bData01;
                    }
                    else if (sData01 == ">=")
                    {
                        bool bData01 = iData01 >= iData02;
                        label6.Text = iData01 + sData01 + iData02 +
                            "의 결과는" + bData01;
                    }
                    else
                    {
                        label6.Text = textBox3.Text + "는 올바른 관계연산자가 아님\n" +
                            "올바른 관계연산자를 입력하세요";
                    }
                }
            }
            catch(Exception ee)
            {
                label6.Text = ee.Message;
                if (textBox1.Text == "") label6.Text = "숫자 1에 정수를 입력하세요!";
                else if (textBox2.Text == "")
                {
                    label6.Text = "숫자 2에 정수를 입력하세요!";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "결과가 나오는 곳입니다!";
        }
    }
}
