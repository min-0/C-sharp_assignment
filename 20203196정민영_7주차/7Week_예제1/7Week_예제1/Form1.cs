using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7Week_예제1
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
                int iBaseNum = int.Parse(textBox1.Text);
                if(iBaseNum >= 2 && iBaseNum <= 9)
                {
                    int iTempValue = 0;
                    string sOutPut = "구구단" + iBaseNum + " 단" + "\n";
                    for (int i = 2; i <= 9; i++)
                    {
                        iTempValue = iBaseNum * i;
                        sOutPut = sOutPut + iBaseNum + "*" + i + "=" + iTempValue + "\n";
                    }     
                }
                label2.Text = sOutPut;
            }
            catch(Exception ee)
            {
                label2.Text = ee.Message;
            }
        }
    }
}
