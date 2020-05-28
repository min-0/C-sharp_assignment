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
        int iUsingCnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iMaxNum = int.Parse(textBox1.Text);
                if (iMaxNum >= 1 && iMaxNum <= 50000)
                {
                    int Sum = 0;
                    for (int i = 1; i <= iMaxNum; i++)
                    {
                        Sum += i;
                    }
                    label2.Text = "합 : " + Sum;
                    iUsingCnt++;
                    label3.Text = "프로그램 실행 횟수" + iUsingCnt + "회";
                }
                else
                {
                    label2.Text = " 1 ~ 50000 사이의 수만 입력해주세요";
                }
            }
            catch(Exception ee)
            {
                label2.Text = ee.Message;
            }
        }
    }
}
