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
        int iData01 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData02 = int.Parse(textBox1.Text);
                iData01 += iData02;
                if(iData02 >= 1 && iData02 <1000)
                {
                    label5.Text = "김태희 계좌 잔고 : " + iData01 + "원";
                }
                else
                {
                    label5.Text="정상적인 금액을 입금해주세요\n"+
                        "김태희 계좌 잔고 : " + iData01 + "원";
                }
            }
            catch(Exception ee)
            {
                label5.Text = ee.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iData03 = int.Parse(textBox2.Text);

                if ((iData01- iData03) > 0)
                {
                    iData01 -= iData03;
                    if (iData01 <= iData03)
                    {
                        label5.Text = "김태희 계좌 잔고 : " + iData01 + "원";
                    }
                    else
                    {
                        label5.Text = "정상적인 금액을 출금해주세요\n" +
                            "김태희 계좌 잔고 : " + iData01 + "원";
                    }
                }
                else
                {
                    label5.Text = "정상적인 금액을 출금해주세요\n" +
                        "김태희 계좌 잔고 : " + iData01 + "원";
                }
            }
            catch(Exception ee)
            {
                label5.Text = ee.Message;
            }
        }
    }
}
