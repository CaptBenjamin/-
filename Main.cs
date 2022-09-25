using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 点名器
{
    public partial class Main : Form
    {
        public static int m;
        public static string c_name ="----";
        public static int num = 0;
        public Main()
        {
            InitializeComponent();
            if (File.Exists(Application.StartupPath + @"\cf.txt"))
            {
                string[] str = File.ReadAllLines(Application.StartupPath + @"\cf.txt");
                int.TryParse(str[0], out m);
            }
        }

        private void 导入名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "captb caller files (*.cbcf)|*.cbcf|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "导入名单";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                System.IO.File.Copy(filePath, Application.StartupPath + @"\cbcf.txt", true);
                System.IO.File.Copy(filePath, Application.StartupPath + @"\cf.txt", true);
                string[] str = File.ReadAllLines(Application.StartupPath + @"\cf.txt");
                int.TryParse(str[0], out m);
                MessageBox.Show("导入成功", "导入名单", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 导出名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\cbcf.txt"))
            {
                var filePath = string.Empty;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog1.Filter = "captb caller files (*.cbcf)|*.cbcf|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.Title = "导出名单";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    System.IO.File.Copy(Application.StartupPath + @"\cbcf.txt", filePath, true);
                    MessageBox.Show("导出成功", "导出名单", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("导出失败\n暂无名单可供导出", "导出名单", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set set = new Set();
            set.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\cbcf.txt"))
            {
                if (File.Exists(Application.StartupPath + @"\cf.txt"))
                {
                    System.IO.File.Delete(Application.StartupPath + @"\cf.txt");
                    System.IO.File.Copy(Application.StartupPath + @"\cbcf.txt", Application.StartupPath + @"\cf.txt", true);
                }
                else
                {
                    System.IO.File.Copy(Application.StartupPath + @"\cbcf.txt", Application.StartupPath + @"\cf.txt", true);
                }
            }
            else
            {
                if (File.Exists(Application.StartupPath + @"\cf.txt"))
                {
                    System.IO.File.Delete(Application.StartupPath + @"\cf.txt");
                }
            }
            System.Environment.Exit(0);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\cbcf.txt"))
            {
                if (File.Exists(Application.StartupPath + @"\cf.txt"))
                {
                    System.IO.File.Delete(Application.StartupPath + @"\cf.txt");
                    System.IO.File.Copy(Application.StartupPath + @"\cbcf.txt", Application.StartupPath + @"\cf.txt", true);
                }
                else
                {
                    System.IO.File.Copy(Application.StartupPath + @"\cbcf.txt", Application.StartupPath + @"\cf.txt", true);
                }
            }
            else
            {
                if (File.Exists(Application.StartupPath + @"\cf.txt"))
                {
                    System.IO.File.Delete(Application.StartupPath + @"\cf.txt");
                }
            }
            System.Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = 0;
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sm sm = new Sm();
            sm.ShowDialog();
        }

        private void 完整名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\cbcf.txt"))
            {
                Properties.Settings.Default.content = 1;
                Properties.Settings.Default.Save();
                content content = new content();
                content.Show();
            }
            else
            {
                MessageBox.Show("查看完整名单失败\n未检索到可用名单", "查看完整名单", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 未点名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\cf.txt"))
            {
                Properties.Settings.Default.content = 2;
                Properties.Settings.Default.Save();
                content content = new content();
                content.Show();
            }
            else
            {
                MessageBox.Show("查看剩余名单失败\n未检索到可用名单", "查看剩余名单", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\cf.txt"))
            {
            retry:
                Random ran = new Random();
                int n = ran.Next(1, Main.m+1);
                string path = Application.StartupPath + @"\cf.txt";
                StreamReader sr = new StreamReader(path);
                string str = sr.ReadToEnd();
                string[] arrayStr = Regex.Split(str, "\r\n");
                string lastMessage = arrayStr[arrayStr.Length - n];
                sr.Close();
                if (Properties.Settings.Default.del == true)
                {
                    if (num == m)
                    {
                        MessageBox.Show("点名失败\n无剩余可点人名，请检查首选项设置是否正确或重置状态", "CB点名器", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (lastMessage == "")
                            goto retry;
                        num++;
                        Main.c_name = lastMessage;
                        button1.Text = Main.c_name;
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

        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\cf.txt"))
            {
                if (MessageBox.Show("未检测到可用名单\n请导入名单", "CB点名器", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    r1:
                    var filePath = string.Empty;
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    openFileDialog.Filter = "captb caller files (*.cbcf)|*.cbcf|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.Title = "导入名单";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                        System.IO.File.Copy(filePath, Application.StartupPath + @"\cbcf.txt", true);
                        System.IO.File.Copy(filePath, Application.StartupPath + @"\cf.txt", true);
                        string[] str = File.ReadAllLines(Application.StartupPath + @"\cf.txt");
                        int.TryParse(str[0], out m);
                        MessageBox.Show("导入成功", "导入名单", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if(MessageBox.Show("导入失败", "导入名单", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)==DialogResult.Retry)
                        {
                            goto r1;
                        }
                        else
                        {
                            System.Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            //button1.Text = c_name;
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
                    if (num == m)
                    {
                        MessageBox.Show("点名失败\n无剩余可点人名，请检查首选项设置是否正确或重置状态", "CB点名器", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (lastMessage == "")
                            goto retry;
                        num++;
                        Main.c_name = lastMessage;
                        button1.Text = Main.c_name;
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

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("LYKNS CaptB 技术博客已于2022年7月停用，功能整合至 LYKNS 开发人员网络\n是否前往 LYKNS 开发人员网络（https://dev.lykns.tk/）", "是否打开外部网页", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://dev.lykns.tk/");
            }
        }
    }
}
