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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sKid = textBox1.Text;
                if (sKid.IndexOf("-") >= 0)
                {
                    label2.Text = "-빼고 입력해주세요";
                }
                else if (sKid.Length != 13)
                {
                    label2.Text = "정확히 입력해주세요";
                }
                else
                {
                    string sSex = sKid.Substring(6, 1);
                    if (sSex == "1" || sSex == "2")
                    {
                        label2.Text = "올바르게 입력되었습니다";
                    }
                    else if (sSex == "3" || sSex == "4")
                    {
                        label2.Text = "2000년 이후 출생자는 사용이 불가능합니다";
                    }
                }
            }
            catch (Exception ee)
            {
                label2.Text = ee.Message;
            }
        }
    }
}
