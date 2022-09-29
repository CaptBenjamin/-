using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 点名器
{
    public partial class Sm : Form
    {
        public Sm()
        {
            InitializeComponent();
            if(Properties.Settings.Default.istrans==true)
            {
                Sm frm = this;
                frm.Opacity = (double)(Properties.Settings.Default.howtrans) / 100;
                button3.BackColor = Color.Green;
            }
            else
            {
                Sm frm = this;
                frm.Opacity = 100;
                button3.BackColor = Color.Red;
            }
            if(Properties.Settings.Default.topmost==true)
            {
                button2.BackColor = Color.Green;
                this.TopMost = true;
            }
            else
            {
                button2.BackColor = Color.Red;
                this.TopMost = false;
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main form1 = new Main();
            form1.Show();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set form2 = new Set();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.topmost==true)
            {
                Properties.Settings.Default.topmost = false;
                Properties.Settings.Default.Save();
                this.TopMost = false;
                button2.BackColor = Color.Red;
            }
            else
            {
                Properties.Settings.Default.topmost = true;
                Properties.Settings.Default.Save();
                this.TopMost = true;
                button2.BackColor = Color.Green;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.istrans == true)
            {
                Properties.Settings.Default.istrans = false;
                Properties.Settings.Default.Save();
                Sm frm = this;
                frm.Opacity = 100;
                button3.BackColor = Color.Red;
            }
            else
            {
                Properties.Settings.Default.istrans = true;
                Properties.Settings.Default.Save();
                Sm frm = this;
                frm.Opacity = (double)(Properties.Settings.Default.howtrans) / 100;
                button3.BackColor = Color.Green;
            }
        }

        private void Sm_Load(object sender, EventArgs e)
        {

            textBox1.Text = Main.c_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\cf.txt"))
            {
            retry:
                Random ran = new Random();
                int n = ran.Next(1, Main.m + 1);
                string path = Application.StartupPath + @"\cf.txt";
                StreamReader sr = new StreamReader(path);
                string str = sr.ReadToEnd();
                string[] arrayStr = Regex.Split(str, "\r\n");
                string lastMessage = arrayStr[arrayStr.Length - n];
                sr.Close();
                if (Properties.Settings.Default.del == true)
                {
                    if (Main.num == Main.m)
                    {
                        if (MessageBox.Show("点名失败\n无剩余可点人名，请检查首选项设置是否正确或重置状态\n单击“确定”将会重置状态", "CB点名器", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            Main.num = 0;
                            Main.c_name = "----";
                            button1.Text = "----";
                            if (File.Exists(Application.StartupPath + @"\cbcf.txt"))
                            {
                                if (File.Exists(Application.StartupPath + @"\cf.txt"))
                                {
                                    System.IO.File.Delete(Application.StartupPath + @"\cf.txt");
                                    System.IO.File.Copy(Application.StartupPath + @"\cbcf.txt", Application.StartupPath + @"\cf.txt", true);
                                    MessageBox.Show("重置成功", "重置状态", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("重置失败\n未检索到可用名单", "重置状态", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("重置失败\n未检索到可用名单", "重置状态", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        if (lastMessage == "")
                            goto retry;
                        Main.num++;
                        Main.c_name = lastMessage;
                        textBox1.Text = Main.c_name;
                        if (Properties.Settings.Default.del == true)
                        {
                            string s = File.ReadAllText(Application.StartupPath + @"\cf.txt");
                            s = s.Replace(Main.c_name, string.Empty);
                            File.WriteAllText(Application.StartupPath + @"\cf.txt", s);
                        }
                    }
                }
                else
                {
                    Main.c_name = lastMessage;
                    button1.Text = Main.c_name;
                }
            }
            else
            {
                MessageBox.Show("点名失败\n未检索到可用名单", "CB点名器", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main.c_name = "----";
            Main.num = 0;
            textBox1.Text = "----";
            if (File.Exists(Application.StartupPath + @"\cbcf.txt"))
            {
                if (File.Exists(Application.StartupPath + @"\cf.txt"))
                {
                    System.IO.File.Delete(Application.StartupPath + @"\cf.txt");
                    System.IO.File.Copy(Application.StartupPath + @"\cbcf.txt", Application.StartupPath + @"\cf.txt", true);
                    MessageBox.Show("重置成功", "重置状态", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("重置失败\n未检索到可用名单", "重置状态", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("重置失败\n未检索到可用名单", "重置状态", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
