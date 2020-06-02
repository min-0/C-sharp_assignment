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
            int[] iArray01 = new int[10];
            System.Random ranNum = new System.Random();
            for(int i = 0; i < iArray01.Length; i++)
            {
                iArray01[i] = ranNum.Next(1, 101);
            }
            label2.Text = "";
            for(int i = 0; i< iArray01.Length; i++)
            {
                label2.Text = "iArray01[" + i + "] = " + iArray01[i];
                if ((i+1) % 2 == 0)
                    label2.Text += "\n\n";
            }
        }
    }
}
