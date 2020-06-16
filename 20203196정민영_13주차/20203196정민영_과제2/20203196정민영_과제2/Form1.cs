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
        bool isModified = false;
        bool hasFileName = false;
        string sFileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void 새로만들기NCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(isModified == true)
                {
                    DialogResult answer = MessageBox.Show
                        ("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (hasFileName == true)
                        {
                            System.IO.StreamWriter fs =
                                System.IO.File.CreateText(sFileName);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            isModified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sFileName = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter
                                    (sFileName, false, System.Text.Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                hasFileName = true;
                                isModified = false;
                            }
                        }
                    }
                }
                textBox1.Text = "";
                isModified = false;
                hasFileName = false;
                sFileName = "";
            }
            catch
            {
                MessageBox.Show("새 파일을 준비하는 도중 이상이 발생했습니다",
                    "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 저장SCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (hasFileName == true)
                {
                    System.IO.StreamWriter fs = new System.IO.StreamWriter
                        (sFileName, false, System.Text.Encoding.Default);
                    fs.WriteLine(textBox1.Text);
                }
                else
                {
                    DialogResult answer = MessageBox.Show("Text 내용을 저장하시겠습니까?", "저장",
                       MessageBoxButtons.YesNo);
                    if (saveFileDialog1.ShowDialog()
                        == DialogResult.OK)
                    {
                        sFileName = saveFileDialog1.FileName;
                        System.IO.StreamWriter fs =
                            System.IO.File.CreateText(sFileName);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        hasFileName = true;
                        isModified = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("저장을 하는 도중 이상이 발생했습니다", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 열기OCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(isModified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장",
                        MessageBoxButtons.YesNo);
                    if(answer == DialogResult.Yes)
                    {
                        if(hasFileName == true)
                        {
                            System.IO.StreamReader fs = new System.IO.StreamReader
                                (sFileName, System.Text.Encoding.Default);
                            textBox1.Text = fs.ReadToEnd();
                            fs.Close();
                            isModified = false;
                        }
                        else
                        {
                            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
                            {
                                sFileName = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter
                                    (sFileName, false, System.Text.Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                hasFileName = true;
                                isModified = false;
                            }
                        }
                    }
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sFileName = openFileDialog1.FileName;
                    System.IO.StreamReader fs = System.IO.File.OpenText(sFileName);
                    textBox1.Text = fs.ReadToEnd();
                    fs.Close();
                    hasFileName = true;
                    isModified = false;
                }
            }
            catch
            {
                MessageBox.Show("열기를 하는 도중 이상이 발생했습니다", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 끝내기XCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(isModified == true)
                {
                    DialogResult answer = MessageBox.Show
                        ("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNoCancel);
                    if(answer == DialogResult.Yes)
                    {
                        if(hasFileName == true)
                        {
                            System.IO.StreamWriter fs = new System.IO.StreamWriter
                                (sFileName, false, System.Text.Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            isModified = false;
                        }
                        else
                        {
                            if(saveFileDialog1.ShowDialog()
                                == DialogResult.OK)
                            {
                                sFileName = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter
                                    (sFileName, false, System.Text.Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                hasFileName = true;
                                isModified = false;
                            }
                        }
                    }
                }
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("끝내는 도중 이상이 발생했습니다", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 잘라내기TCtrlTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 복사CCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 붙여넣기PCtrlPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 삭제DCtrlDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste("");
        }

        private void 모두선택ACtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 글꼴FCtrlFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.Cancel)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void 색깔CCtrlShiftCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.Cancel)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (isModified == true)
                {
                    DialogResult answer = MessageBox.Show
                        ("변경된 내용을 저장하시겠습니까?", "저장", MessageBoxButtons.YesNoCancel);
                    if (answer == DialogResult.Yes)
                    {
                        if (hasFileName == true)
                        {
                            System.IO.StreamWriter fs = new System.IO.StreamWriter
                                (sFileName, false, System.Text.Encoding.Default);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            isModified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog()
                                == DialogResult.OK)
                            {
                                sFileName = saveFileDialog1.FileName;
                                System.IO.StreamWriter fs = new System.IO.StreamWriter
                                    (sFileName, false, System.Text.Encoding.Default);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                hasFileName = true;
                                isModified = false;
                            }
                        }
                    }
                }
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("끝내는 도중 이상이 발생했습니다", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
