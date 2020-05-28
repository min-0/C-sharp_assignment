using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9Week_예제1
{
    public partial class Form1 : Form
    {
        int iGData01 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iLData01 = 0;
            try
            {
                int iData02 = int.Parse(textBox1.Text);
                iGData01 += iData02;
                iLData01 += iData02;
                label1.Text = "김태희 계좌 금액 " + iGData01 + "원";
                label2.Text = "한가인 계좌 금액 " + iLData01 + "원";
            }
            catch
            {

            }
        }
    }
}
