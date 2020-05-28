using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Week_예제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iData01 = 3;
            int iData02 = 3;
            int iData03 = iData01 + iData02;
            label1.Text = "결과는 " + iData03 + " 입니다";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sData01 = "3";
            string sData02 = "3";
            string sData03 = sData01 + sData02;
            label1.Text = "결과는 " + sData03 + " 입니다";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iData01 = 3;
            string sData01 = "3";
            string sData02 = iData01 + sData01;
            label1.Text = "결과는 " + sData02 + " 입니다";
        }
    }
}
