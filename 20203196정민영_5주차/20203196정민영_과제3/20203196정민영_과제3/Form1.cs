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
                string sData01 = textBox1.Text;
                switch(sData01)
                {
                    case"int" :
                        int iData01 = int.MaxValue;
                        int iData02 = int.MinValue;
                        label3.Text = sData01 + " 의 허용값은" + iData02 + " ~ " + iData01;
                        break;
                    case "double":
                        double dData01 = double.MaxValue;
                        double dData02 = double.MinValue;
                        label3.Text = dData01 + " 의 허용값은" + dData02 + " ~ " + dData01;
                        break;
                    case "uint":
                        uint uData01 = uint.MaxValue;
                        uint uData02 = uint.MinValue;
                        label3.Text = sData01 + " 의 허용값은" + uData02 + " ~ " + uData01;
                        break;
                    case "float":
                        float fData01 = float.MaxValue;
                        float fData02 = float.MinValue;
                        label3.Text = sData01 + " 의 허용값은" + fData02 + " ~ " + fData01;
                        break;
                    case "long":
                        long lData01 = long.MaxValue;
                        long lData02 = long.MinValue;
                        label3.Text = sData01 + " 의 허용값은" + lData02 + " ~ " + lData01;
                        break;
                    case "ulong":
                        ulong nData01 = ulong.MaxValue;
                        ulong nData02 = ulong.MinValue;
                        label3.Text = sData01 + " 의 허용값은" + nData02 + " ~ " + nData01;
                        break;
                    case "byte":
                        byte bData01 = byte.MaxValue;
                        byte bData02 = byte.MinValue;
                        label3.Text = sData01 + " 의 허용값은" + bData02 + " ~ " + bData01;
                        break;
                    case "sbyte":
                        sbyte yData01 = sbyte.MaxValue;
                        sbyte yData02 = sbyte.MinValue;
                        label3.Text = sData01 + " 의 허용값은" + yData02 + " ~ " + yData01;
                        break;
                    case "short":
                        short tData01 = short.MaxValue;
                        short tData02 = short.MinValue;
                        label3.Text = sData01 + " 의 허용값은" + tData02 + " ~ " + tData01;
                        break;
                    case "ushort":
                        ushort hData01 = ushort.MaxValue;
                        ushort hData02 = ushort.MinValue;
                        label3.Text = sData01 + " 의 허용값은" + hData02 + " ~ " + hData01;
                        break;
                    default:
                        label3.Text = sData01 + " 는 알 수 없는 Data Type 입니다";
                        break;
                }
            }
            catch
            {

            }
        }
    }
}
