using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "정민영";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sData01 = textBox1.Text;
            label5.Text = "성명 : " + sData01;
            string sData02 = textBox2.Text;
            label6.Text = "학번 : " + sData02;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sData03 = textBox3.Text;
            label7.Text = "무선 : " + sData03;
            string sData04 = textBox4.Text;
            label8.Text = "유선 : " + sData04;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "20203196";
        }
    }
}