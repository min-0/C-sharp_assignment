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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                string sOutput = "";
                if (iData01 > 0 && iData01 <= 20)
                {
                    for (int i = 1; i <= iData01; i++)
                    {
                        sOutput += i + ".";
                    }
                    label3.Text = "수행된 i 값 : " + sOutput;
                }
                else
                    label3.Text = "1부터 20 사이의 숫자를 입력하세요";
            }
            catch(Exception ee)
            {
                label3.Text = ee.Message;
            }
        }
    }
}
