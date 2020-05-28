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
            string sData01 = "정민영";
            string sData02 = "20203196";
            label1.Text = "성명은 " + sData01;
            label2.Text = "학번은 " + sData02;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sData01 = "01025440421";
            string sData02 = "0555513640";
            label3.Text = "무선은 " + sData01;
            label4.Text = "유선은 " + sData02;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }
    }
}
