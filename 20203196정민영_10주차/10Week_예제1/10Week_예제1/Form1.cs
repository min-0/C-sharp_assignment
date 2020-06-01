using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10Week_예제1
{
    public partial class Form1 : Form
    {
        int[] iAdata01 = { 0, 0, 0, 0 };
        int iData01 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i =0; i < iAdata01.Length; i++)
            {
                iData01 += 1;
                iAdata01[i] = iData01;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            foreach (int iOne in iAdata01)
                label1.Text += iOne + ".";
        }
    }
}
