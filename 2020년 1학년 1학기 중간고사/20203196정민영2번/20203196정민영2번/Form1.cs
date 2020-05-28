using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영2번
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
                string sData01 = textBox1.Text;
                string sData02 = textBox2.Text;
                if ((sData01 == "가위" || sData01 == "바위" || sData01 == "보") &&
                    (sData02 == "가위" || sData02 == "바위" || sData02 == "보"))
                {
                    if (sData01 == "가위")
                    {
                        if (sData02 == "가위")
                            label6.Text = "user1 은 ->" + textBox1.Text + "\n \n" +
                                "user2 는 ->" + textBox2.Text + "\n \n" + "결과는 -> user1과 user2 무";
                        else if (sData02 == "바위")
                            label6.Text = "user1 은 ->" + textBox1.Text + "\n \n" +
                                "user2 는 ->" + textBox2.Text + "\n \n" + "결과는 -> user1 패";
                        else if (sData02 == "보")
                            label6.Text = "user1 은 ->" + textBox1.Text + "\n \n" +
                                "user2 는 ->" + textBox2.Text + "\n \n" + "결과는 -> user1 승";
                    }
                    else if (sData01 == "바위")
                    {
                        if (sData02 == "가위")
                            label6.Text = "user1 은 ->" + textBox1.Text + "\n \n" +
                                "user2 는 ->" + textBox2.Text + "\n \n" + "결과는 -> user1 승";
                        else if (sData02 == "바위")
                            label6.Text = "user1 은 ->" + textBox1.Text + "\n \n" +
                                "user2 는 ->" + textBox2.Text + "\n \n" + "결과는 -> user1과 user2 무";
                        else if (sData02 == "보")
                            label6.Text = "user1 은 ->" + textBox1.Text + "\n \n" +
                                "user2 는 ->" + textBox2.Text + "\n \n" + "결과는 -> user1 패";
                    }
                    else if (sData01 == "보")
                    {
                        if (sData02 == "가위")
                            label6.Text = "user1 은 ->" + textBox1.Text + "\n \n" +
                                "user2 는 ->" + textBox2.Text + "\n \n" + "결과는 -> user1 패";
                        else if (sData02 == "바위")
                            label6.Text = "user1 은 ->" + textBox1.Text + "\n \n" +
                                "user2 는 ->" + textBox2.Text + "\n \n" + "결과는 -> user1 승";
                        else if (sData02 == "보")
                            label6.Text = "user1 은 ->" + textBox1.Text + "\n \n" +
                                "user2 는 ->" + textBox2.Text + "\n \n" + "결과는 -> user1과 user2 무";
                    }
                }
                else label6.Text = "입력 값이 '가위, 바위, 보' 중 하나가 아닙니다. 다시 입력하세요";
            }

            catch (Exception ee)
            {
                label6.Text = ee.Message;
            }
        }
    }
}
