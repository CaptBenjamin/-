using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using 新一代CaptB点名器.Properties;

namespace 新一代CaptB点名器
{
    public partial class Form1 : Form
    {
        public Form1(string paths)
        {
            if (paths != null)
            {
                if (MessageBox.Show("是否导入此名单？", "打开名单文件", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Program.Import(paths);
                }
            }
            try
            {
                if (!File.Exists(Program.ProgramDatadirectoryPath))
                {
                    Directory.CreateDirectory(Program.ProgramDatadirectoryPath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Resources.ExRe_Reinstall, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InitializeComponent();
            if (Program.called_name == string.Empty)
            {
                button1.Text = Settings.Default.InitialWord;
            }
            else
            {
                button1.Text = Program.called_name;
            }
            if (Settings.Default.doCheckUpdate)
            {
                if (Settings.Default.LastestUpdateCheckTime != DateTime.Now.Date)
                {
                    Process checkupdate = new Process();
                    checkupdate.StartInfo.FileName = Application.StartupPath + @"\CBRC_Update.exe";
                    try
                    {
                        checkupdate.Start();
                        Settings.Default.LastestUpdateCheckTime = DateTime.Now.Date;
                        Settings.Default.Save();
                    }
                    catch (Exception ex)
                    {
                        Settings.Default.LastestUpdateCheckTime = DateTime.Now.Date;
                        Settings.Default.Save();
                        notifyIcon1.ShowBalloonTip(1000, Resources.UpdateErrToastTitle, ex.Message + Resources.ExRe_Reinstall, ToolTipIcon.Error);
                    }
                }
            }
            if (Program.called_num == 0)
            {
                if (File.Exists(Program.cbcfpath))
                {
                    if (File.Exists(Program.cfpath))
                    {
                        try
                        {
                            string[] strings = File.ReadAllLines(Program.cfpath);
                            int.TryParse(strings[0], out Program.num);
                            Settings.Default.编辑名单_Enabled = true;
                            Settings.Default.导出名单_Enabled = true;
                            Settings.Default.完整名单_Enabled = true;
                            Settings.Default.未点名单_Enabled = true;
                            Settings.Default.Save();
                            编辑名单BToolStripMenuItem.Enabled = true;
                            导出名单CToolStripMenuItem.Enabled = true;
                            完整名单ToolStripMenuItem.Enabled = true;
                            未点名单ToolStripMenuItem.Enabled = true;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message + "\n" + Resources.ExRe_RR, Resources.StartupErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    try
                    {
                        File.Copy(Program.cbcfpath, Program.cfpath, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + Resources.ExRe_ReImport, Resources.ExitErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Settings.Default.编辑名单_Enabled = false;
                    Settings.Default.导出名单_Enabled = false;
                    Settings.Default.完整名单_Enabled = false;
                    Settings.Default.未点名单_Enabled = false;
                    Settings.Default.Save();
                    编辑名单BToolStripMenuItem.Enabled = false;
                    导出名单CToolStripMenuItem.Enabled = false;
                    完整名单ToolStripMenuItem.Enabled = false;
                    未点名单ToolStripMenuItem.Enabled = false;
                }
            }
            ActiveControl = button2;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Settings.Default.doExitConfirm)
            {
                if (MessageBox.Show(Resources.ExitContent, Resources.ExitCTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    if (File.Exists(Program.cfpath))
                    {
                        try
                        {
                            File.Delete(Program.cfpath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Resources.ExitErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (File.Exists(Program.cbcfpath))
                    {
                        try
                        {
                            File.Copy(Program.cbcfpath, Program.cfpath, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Resources.ExitErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    ToastNotificationManagerCompat.Uninstall();
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                ToastNotificationManagerCompat.Uninstall();
                Environment.Exit(0);
            }
        }

        private void 导入名单AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Reset();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer),
                Filter = "支持的文件类型（*.cbcf,*.txt）|*.cbcf;*.txt|所有文件（*.*）|*.*",
                FilterIndex = 1,
                Multiselect = false,
                RestoreDirectory = true,
                Title = Resources.OpenFileDialogTitle
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                Program.Import(openFileDialog.FileName);
            Settings.Default.编辑名单_Enabled = true;
            Settings.Default.导出名单_Enabled = true;
            Settings.Default.完整名单_Enabled = true;
            Settings.Default.未点名单_Enabled = true;
            Settings.Default.Save();
            编辑名单BToolStripMenuItem.Enabled = true;
            导出名单CToolStripMenuItem.Enabled = true;
            完整名单ToolStripMenuItem.Enabled = true;
            未点名单ToolStripMenuItem.Enabled = true;
            button1.Text = Settings.Default.InitialWord; ;
        }

        private void 导出名单CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Save();
        }

        private void 退出CaptB点名器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.doExitConfirm)
            {
                if (MessageBox.Show(Resources.ExitContent, Resources.ExitCTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    if (File.Exists(Program.cfpath))
                    {
                        try
                        {
                            File.Delete(Program.cfpath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Resources.ExitErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (File.Exists(Program.cbcfpath))
                    {
                        try
                        {
                            File.Copy(Program.cbcfpath, Program.cfpath, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Resources.ExitErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    ToastNotificationManagerCompat.Uninstall();
                    Environment.Exit(0);
                }
            }
            else
            {
                ToastNotificationManagerCompat.Uninstall();
                Environment.Exit(0);
            }
        }

        private void 完整名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Content = true;
            Settings.Default.Save();
            new Content().Show();
        }

        private void 未点名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Content = false;
            Settings.Default.Save();
            new Content().Show();
        }

        private void 入门GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://dev.lykns.tk/CBRC/publish/Gettingstarted");
        }

        private void 新增功能WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://dev.lykns.tk/CBRC/publish/newfeatures");
        }

        private void 报告问题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://eow.lykns.tk/connect/feedback");
        }

        private void 建议功能LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://eow.lykns.tk/connect/SubmitSuggestions");
        }

        private void 检查更新LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process checkupdate = new Process();
            checkupdate.StartInfo.FileName = Application.StartupPath + @"\CBRC_Update.exe";
            try
            {
                checkupdate.Start();
                Settings.Default.LastestUpdateCheckTime = DateTime.Now.Date;
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                notifyIcon1.ShowBalloonTip(1000, Resources.UpdateErrToastTitle, ex.Message + Resources.ExRe_Reinstall, ToolTipIcon.Error);
            }
        }

        private void 技术支持TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://eow.lykns.tk/connect");
        }

        private void 隐私政策PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://eow.lykns.tk/Privacy");
        }

        private void 关于CaptB点名器ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
        }

        private void 首选项PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Setting().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.call();
            button1.Text = Program.called_name;
            ActiveControl = button2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Reset();
            button1.Text = Settings.Default.InitialWord;
            ActiveControl = button2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().ShowDialog();
            ActiveControl = button2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveControl = button2;
        }

        private void 编辑名单BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "此功能暂未开放", "名单编辑功能仍在开发中，敬请期待！", ToolTipIcon.Warning);
        }

        private void 复制当前值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(button1.Text);
        }

        private void 删除名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Program.Reset();
                if (File.Exists(Program.cfpath))
                    File.Delete(Program.cfpath);
                if (File.Exists(Program.cbcfpath))
                    File.Delete(Program.cbcfpath);
                Settings.Default.编辑名单_Enabled = false;
                Settings.Default.导出名单_Enabled = false;
                Settings.Default.完整名单_Enabled = false;
                Settings.Default.未点名单_Enabled = false;
                Settings.Default.Save();
                编辑名单BToolStripMenuItem.Enabled = false;
                导出名单CToolStripMenuItem.Enabled = false;
                完整名单ToolStripMenuItem.Enabled = false;
                未点名单ToolStripMenuItem.Enabled = false;
                notifyIcon1.ShowBalloonTip(1000, Resources.DelToastTitle, Resources.DelToastContent, ToolTipIcon.Info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + Resources.ExRe_ReImport, Resources.DelErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
