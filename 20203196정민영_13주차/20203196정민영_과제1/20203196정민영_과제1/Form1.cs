using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203196정민영_과제1
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

        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isModified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장",
                        MessageBoxButtons.YesNo);
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
                }
                textBox1.Text = "";
                isModified = false;
                hasFileName = false;
                sFileName = "";
            }
            catch
            {
                MessageBox.Show("새 파일을 준비하는 도중 이상이 발생했습니다.",
                    "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isModified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장",
                        MessageBoxButtons.YesNo);
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
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sFileName = openFileDialog1.FileName;
                    System.IO.StreamReader fs =
                        System.IO.File.OpenText(sFileName);
                    textBox1.Text = fs.ReadToEnd();
                    fs.Close();
                    hasFileName = true;
                    isModified = false;
                }
            }
            catch
            {
                MessageBox.Show("새 파일을 준비하는 도중 이상이 발생했습니다.",
                    "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
                MessageBox.Show("새 파일을 준비하는 도중 이상이 발생했습니다.",
                    "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isModified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?", "저장",
                        MessageBoxButtons.YesNo);
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
                }
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("새 파일을 준비하는 도중 이상이 발생했습니다.",
                    "에러", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
