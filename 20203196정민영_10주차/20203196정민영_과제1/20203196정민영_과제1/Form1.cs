using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] iarray01 = new int[100];
            for (int i = 0; i < iarray01.Length; i++)
                iarray01[i] = i + 1;

            label2.Text = " ";
            foreach (int indexNum01 in iarray01)
            {
                label2.Text += " " + indexNum01;
                if (indexNum01 % 10 ==0)
                {
                    label2.Text += "\n";
                }
            }
        }
    }
}
