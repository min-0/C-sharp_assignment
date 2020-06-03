using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영_과제4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random ranNum = new System.Random();
            int who = ranNum.Next(1, 4);
            int what = ranNum.Next(1, 3);
            string sPrint = "쏠 사람 :";
            if (who == 1)
            {
                sPrint += "김태휘, 쏠 메뉴 :";
            }
            else if (who == 2)
            {
                sPrint += sPrint + "한가언, 쏠 메뉴 :";
            }
            else if (who == 3)
            {
                sPrint += sPrint + "설유리, 쏠 메뉴 :";
            }
            else
            {
                sPrint += sPrint + "한예술, 쏠 메뉴 :";
            }
            if (what == 1)
            {
                sPrint += "짜장면";
            }
            else if (what == 2)
            {
                sPrint += "간짜장";
            }
            else
            {
                sPrint += "짜장라면";
            }

            label3.Text = sPrint;
        }
    }
}
