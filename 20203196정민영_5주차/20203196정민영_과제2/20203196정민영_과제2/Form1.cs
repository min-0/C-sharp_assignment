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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                char cData01 = char.Parse(textBox1.Text);
                if (cData01 >= 'a' && cData01 <= 'z')
                {
                    switch(cData01)
                    {


                        case 'a':
                            label3.Text = cData01+" is a vower";
                            break;
                        case 'e':
                            label3.Text = cData01+" is a vower";
                            break;
                        case 'o':
                            label3.Text = cData01+" is a vower";
                            break;
                        case 'u':
                            label3.Text = cData01+" is a vower";
                            break;
                        case 'y':
                            label3.Text = cData01+" is a vower";
                            break;
                        default:
                            label3.Text = cData01+" is a consonant";
                            break;
                    }
                }
                else
                {
                    label3.Text = "영문 알파벳 한 글자를 입력하세요";
                }
            }
            catch
            {
                label3.Text ="문자열의 길이는 1자여야 합니다";
            }
        }
    }
}
