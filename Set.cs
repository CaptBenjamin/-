using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace 点名器
{
    public partial class Set : Form
    {
        public Set()
        {
            InitializeComponent();
            label9.Text = "当前值：" + Properties.Settings.Default.howtrans + "%";
            label15.Text = "上次检查更新时间：" + Properties.Settings.Default.uptime;
            trackBar1.Value = Properties.Settings.Default.howtrans;
            if(Properties.Settings.Default.istrans==true)
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }
            if (Properties.Settings.Default.topmost == true)
            {
                radioButton6.Checked = true;
            }
            else
            {
                radioButton5.Checked = true;
            }
            if (Properties.Settings.Default.del == true)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\cbcf.txt"))
            {
                System.IO.File.Delete(Application.StartupPath + @"\cbcf.txt");
                System.IO.File.Delete(Application.StartupPath + @"\cf.txt");
                MessageBox.Show("删除成功", "删除已导入名单", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("删除失败\n没有可供删除的名单", "删除已导入名单", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                int.TryParse(str[0], out Main.m);
                MessageBox.Show("导入成功", "导入名单", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.howtrans = trackBar1.Value;
            Properties.Settings.Default.Save();
            label9.Text= "当前值："+ Properties.Settings.Default.howtrans + "%";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked==true)
            {
                Properties.Settings.Default.istrans = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.istrans = true;
                Properties.Settings.Default.Save();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                Properties.Settings.Default.topmost = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.topmost = true;
                Properties.Settings.Default.Save();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Properties.Settings.Default.del = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.del = true;
                Properties.Settings.Default.Save();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://eow.lykns.tk/support");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://eow.lykns.tk/slt");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\CBRC_Update.exe"))
            {
                Process pr = new Process();//声明一个进程类对象
                pr.StartInfo.FileName = Application.StartupPath + @"\CBRC_Update.exe";
                pr.Start();
                Properties.Settings.Default.update = System.DateTime.Now.ToString("d");
                Properties.Settings.Default.uptime = System.DateTime.Now.ToString("F");
                Properties.Settings.Default.Save();
            }
            else
            {
                if (MessageBox.Show("更新程序可能损坏或被禁用\n您可以尝试重新安装此应用程序\n单击“确定”下载最新安装程序", "检查更新失败", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    System.Diagnostics.Process.Start("https://dev.lykns.tk/CBRC/publish");
                Properties.Settings.Default.update = System.DateTime.Now.ToString("d");
                Properties.Settings.Default.uptime = System.DateTime.Now.ToString("F");
                Properties.Settings.Default.Save();
            }
        }
    }
}
