using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Week_예제1
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
            label1.Text = "결과는 " + iData01 + " 입니다";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dData01 = 3.5;
            label1.Text = "걸과는 " + dData01 + " 입니다";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sData01 = "홍길동";
            label1.Text = "결과는 " + sData01 + " 입니다";
        }
    }
}
