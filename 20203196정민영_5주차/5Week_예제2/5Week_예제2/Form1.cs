using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5Week_예제2
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
                switch (iData01)
                {
                    case 1:
                        label2.Text = "숫자 1 이 입력되었습니다";
                        break;
                    case 2:
                        label2.Text = "숫자 2 가 입력되었습니다";
                        break;
                    case 3:
                        label2.Text = "숫자 3 이 입력되었습니다";
                        break;
                    case 4:
                        label2.Text = "숫자 4 가 입력되었습니다";
                        break;
                    case 5:
                        label2.Text = "숫자 5 가 입력되었습니다";
                        break;
                    default:
                        label2.Text = "1과 5 사이의 숫자가 아닙니다";
                        break;
                }
            }
            catch(Exception ee)
            {
                label2.Text = ee.Message;
            }
        }
    }
}
