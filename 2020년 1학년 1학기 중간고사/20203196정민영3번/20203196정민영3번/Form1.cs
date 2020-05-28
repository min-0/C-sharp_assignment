using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영3번
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
                int iData01 = int.Parse(textBox1.Text) / 10;
                int iData02 = int.Parse(textBox1.Text);
                if (iData02 > -1)
                {
                    switch (iData01)
                    {
                        case 0:
                            label3.Text = iData02 + " -> 0 이상 9 이하의 수";
                            break;
                        case 1:
                            label3.Text = iData02 + " -> 10 이상 19 이하의 수";
                            break;
                        case 2:
                            label3.Text = iData02 + " ->20 이상 29 이하의 수";
                            break;
                        case 3:
                            label3.Text = iData02 + " -> 30 이상 39 이하의 수";
                            break;
                        case 4:
                            label3.Text = iData02 + " -> 40 이상 49 이하의 수";
                            break;
                        case 5:
                            label3.Text = iData02 + " -> 50 이상 59 이하의 수";
                            break;
                        case 6:
                            label3.Text = iData02 + " -> 60 이상 69 이하의 수";
                            break;
                        case 7:
                            label3.Text = iData02 + " -> 70 이상 79 이하의 수";
                            break;
                        case 8:
                            label3.Text = iData02 + " -> 80 이상 89 이하의 수";
                            break;
                        case 9:
                            label3.Text = iData02 + " -> 90 이상 99 이하의 수";
                            break;
                        default:
                            label3.Text = "알수 없는 수";
                            break;
                    }
                }
                else
                {
                    label3.Text = "알수 없는 수";
                }

            }
            catch (Exception ee)
            {
                label3.Text = ee.Message;
            }
        }
    }
}
