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
            int MaxNum = iArray01[0];
            int MinNum = iArray01[0];
            int Sum = 0;
            double Average =0 ;
            for(int i =0; i < iArray01.Length; i++)
            {
                if (MaxNum < iArray01[i])
                    MaxNum = iArray01[i];
                if (MinNum > iArray01[i])
                MinNum = iArray01[i];

                Sum += iArray01[i];
            }
            Average = Sum / iArray01.Length;
            label2.Text += "\n배열값의 최대는 " + MaxNum + "\n배열값의 최소는 " + MinNum;
            label2.Text += "\n\n" + iArray01.Length + "개 원소 배열 값의 평균은 " + Average;
        }
    }
}
