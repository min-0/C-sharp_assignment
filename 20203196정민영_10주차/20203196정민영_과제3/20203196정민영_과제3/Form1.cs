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
        int Win = 0;
        int Drew = 0;
        int Lose = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "가위";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "바위";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "보";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try 
            {
                string user_input = textBox1.Text;

                if (user_input == "가위" || user_input == "바위" || user_input == "보")
                {
                    string ResultStr = "";
                    System.Random ranNum = new System.Random();
                    int System_num = ranNum.Next(1, 4);
                    String System_input = "";
                    if (System_num == 1)
                        System_input = "가위";
                    else if (System_num == 2)
                        System_input = "바위";
                    else if (System_num == 3)
                    System_input = "보";

                    if (user_input == "가위" && System_input == "가위")
                    {
                        Drew++;
                        ResultStr = "무승부";
                    }
                    else if (user_input == "가위" && System_input == "바위")
                    {
                        Lose++;
                        ResultStr = "User 패";
                    }
                    else
                    {
                        Win++;
                        ResultStr = "User 승";
                    }
                }
            }
            catch
            {

            }
        }
    }
}
