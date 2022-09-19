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

namespace 点名器
{
    public partial class Set : Form
    {
        public Set()
        {
            InitializeComponent();
            label9.Text = "当前值：" + Properties.Settings.Default.howtrans + "%";
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
            Properties.Settings.Default.web = 0;
            Properties.Settings.Default.Save();
            wb wb = new wb();
            wb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LYKNS 软件许可条款\n请注意：使用该订购服务和软件时，必须遵守您注册订购服务时同意的协议以及您为获得该软件的许可而签订的协议中的条款和条件。例如，如果您是：\n\n• 批量许可客户，则对该软件的使用应受批量许可协议的约束。\n• LYKNS 在线订购客户，则对该软件的使用应受 LYKNS 在线订购协议的约束。\n\n如果您尚未通过正规渠道从 LYKNS 或其授权分销商处获得该服务或软件的有效许可，则不得使用该服务或软件。\n\n如果你的组织是 LYKNS 客户，你就可以使用 LYKNS 软件中的某些已连接服务。你也许还能访问 LYKNS 提供的其他已连接服务，它们受到单独的条款和隐私承诺保护。请访问 www.lykns.tk，详细了解 LYKNS 的其他已连接服务。","LYKNS 软件许可条款",MessageBoxButtons.OK,MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
