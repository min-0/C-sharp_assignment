using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영_과제4
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
                switch(iData01)
                {
                    case 1: label3.Text = "입력값 " + iData01 + "->" + "January";
                        break;
                    case 2:
                        label3.Text = "입력값 " + iData01 + "->" + "February";
                        break;
                    case 3:
                        label3.Text = "입력값 " + iData01 + "->" + "March";
                        break;
                    case 4:
                        label3.Text = "입력값 " + iData01 + "->" + "April";
                        break;
                    case 5:
                        label3.Text = "입력값 " + iData01 + "->" + "May";
                        break;
                    case 6:
                        label3.Text = "입력값 " + iData01 + "->" + "June";
                        break;
                    case 7:
                        label3.Text = "입력값 " + iData01 + "->" + "July";
                        break;
                    case 8:
                        label3.Text = "입력값 " + iData01 + "->" + "August";
                        break;
                    case 9:
                        label3.Text = "입력값 " + iData01 + "->" + "September";
                        break;
                    case 10:
                        label3.Text = "입력값 " + iData01 + "->" + "October";
                        break;
                    case 11:
                        label3.Text = "입력값 " + iData01 + "->" + "November";
                        break;
                    case 12:
                        label3.Text = "입력값 " + iData01 + "->" + "December";
                        break;
                    default:
                        label3.Text = "해당하는 월이 없으니 \n 1 ~ 12 사이의 숫자를 입력하세요";
                        break;
                }
            }
            catch(Exception ee)
            {
                label3.Text = ee.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
