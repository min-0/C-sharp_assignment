﻿using System;
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
        CheckBox[] chkBoxMgr;
        const int ChkCunt = 7;
        public Form1()
        {
            InitializeComponent();
            chkBoxMgr = new CheckBox[ChkCunt];
            chkBoxMgr[0] = checkBox1;
            chkBoxMgr[1] = checkBox2;
            chkBoxMgr[2] = checkBox3;
            chkBoxMgr[3] = checkBox4;
            chkBoxMgr[4] = checkBox5;
            chkBoxMgr[5] = checkBox6;
            chkBoxMgr[6] = checkBox7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ChkCunt; i++)
            {
                if (chkBoxMgr[i].Checked == true)
                    listBox1.Items.Add(chkBoxMgr[i].Text);
            }
            /* if (checkBox1.Checked == true)
                 listBox1.Items.Add(checkBox1.Text);
             if (checkBox2.Checked == true)
                 listBox1.Items.Add(checkBox2.Text);
             if (checkBox3.Checked == true)
                 listBox1.Items.Add(checkBox3.Text);
             if (checkBox4.Checked == true)
                 listBox1.Items.Add(checkBox4.Text);
             if (checkBox5.Checked == true)
                 listBox1.Items.Add(checkBox5.Text);
             if (checkBox6.Checked == true)
                 listBox1.Items.Add(checkBox6.Text);
             if (checkBox7.Checked == true)
                 listBox1.Items.Add(checkBox7.Text);
                 */
        }
    }
}
