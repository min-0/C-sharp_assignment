using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9Week_예제2
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
                if(iMaxNum >=2 && iMaxNum <=50000)
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
                        label2.Text ="당신은" + iMaxNum + "을 입력했습니다\n"
                        + " 2 와 50000 사이의 값을 입력하세요";
                }
            }
            catch
            {

            }
        }
    }
}
