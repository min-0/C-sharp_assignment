using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = int.Parse(textBox2.Text);
                int sum = 0; string sOutPut = "";
                if (iData01 <= iData02)
                {
                    if (iData01 > 1 && iData01 <= 9)
                    {
                        if(iData02 >= 2 && iData02 < 10)
                        {
                            sOutPut = "구구단 " + iData01 + "단 부터 " + iData02 + "단 까지 입니다 \n\n";
                            for (int k = iData01; k<= iData02; k++)
                            {

                                for (int i = 2; i <= 9; i++)
                                {
                                    sum = i * k;
                                    sOutPut += k + " x " + i + " = " + sum +"\n";
                                }
                                sOutPut += "\n";
                            }
                            label4.Text = sOutPut;
                        }
                        else
                            label4.Text = "2~9 사이의 수를 입력하세요";
                    }
                    else
                        label4.Text = "2~9 사이의 수를 입력하세요";
                }
                else
                    label4.Text = "시작단수가 마지막 단수보다 작거나 같아야 합니다";
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
