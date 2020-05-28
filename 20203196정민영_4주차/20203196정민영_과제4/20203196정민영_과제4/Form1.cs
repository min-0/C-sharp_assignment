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
                int iData02 = iData01 % 2;
                if (iData02 == 0)
                    label3.Text = "입력한 수: " + iData01 + " 는 짝수입니다";
                else
                    label3.Text = "입력한 수: " + iData01 + " 은 홀수입니다";
            }
            catch(Exception ee)
            {
                label3.Text = ee.Message;
            }
        }
    }
}
