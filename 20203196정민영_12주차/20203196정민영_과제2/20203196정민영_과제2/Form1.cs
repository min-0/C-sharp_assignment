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
        CheckBox[] cMgr;
        const int cnt = 20;

        public Form1()
        {
            InitializeComponent();
            cMgr = new CheckBox[cnt];
            cMgr[0] = checkBox1;
            cMgr[1] = checkBox2;
            cMgr[2] = checkBox3;
            cMgr[3] = checkBox4;
            cMgr[4] = checkBox5;
            cMgr[5] = checkBox6;
            cMgr[6] = checkBox7;
            cMgr[7] = checkBox8;
            cMgr[8] = checkBox9;
            cMgr[9] = checkBox10;
            cMgr[10] = checkBox11;
            cMgr[11] = checkBox12;
            cMgr[12] = checkBox13;
            cMgr[13] = checkBox14;
            cMgr[14] = checkBox15;
            cMgr[15] = checkBox16;
            cMgr[16] = checkBox17;
            cMgr[17] = checkBox18;
            cMgr[18] = checkBox19;
            cMgr[19] = checkBox20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random num = new System.Random();
            for (int i = 0; i < cnt; i++)
            {
                cMgr[i].Text = num.Next(1, 99).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 0; i < cnt; i++)
            {
                cMgr[i].Text = "checkBox" + (i + 1);
            }
            for (int i = 0; i < cnt; i++)
            {
                cMgr[i].Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox1.Items.Add("각 체크박스의 숫자들");
                listBox1.Items.Add("--------------------");
                for (int i = 0; i < cnt; i++)
                {
                    listBox1.Items.Add("checkBox" + (i + 1) + " = " + cMgr[i].Text);
                }
                listBox2.Items.Add("각 체크박스의 숫자들");
                listBox2.Items.Add("--------------------");
                for (int i = 0; i < cnt; i++)
                {
                    if (cMgr[i].Checked == true)
                        listBox2.Items.Add("checkBox" + (i + 1) + " = " + cMgr[i].Text);
                }
                int sum = 0;
                double avg = 0;
                int count = 0;
                for (int i = 0; i < cnt; i++)
                {
                    if (cMgr[i].Checked == true)
                    {
                        sum += int.Parse(cMgr[i].Text);
                        count++;
                    }
                }
                listBox2.Items.Add("--------------------");
                listBox2.Items.Add("숫자합계 -→" + sum);
                avg = sum / count;
                listBox2.Items.Add("--------------------");
                listBox2.Items.Add("숫자평균 →" + avg);
            }
            catch
            {
                MessageBox.Show("숫자바꾸기를 먼저 하세요");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
