using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using 新一代CaptB点名器.Properties;

namespace 新一代CaptB点名器
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            if (!Settings.Default.doCheckUpdate)
                radioButton7.Checked = true;
            if (!Settings.Default.doDelete)
                radioButton2.Checked = true;
            if (!Settings.Default.doTopmost)
                radioButton3.Checked = true;
            if (!Settings.Default.doTransparent)
                radioButton5.Checked = true;
            if (!Settings.Default.doExitConfirm)
                radioButton9.Checked = true;
            trackBar1.Value = Settings.Default.Opacity;
            label5.Text = "当前值：" + Settings.Default.Opacity.ToString() + "%";
            textBox1.Text = Settings.Default.InitialWord;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            label9.Text = "上次检查更新时间：" + Settings.Default.LastestUpdateCheckTime.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
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
                Form1 form1 = new Form1(null);
                form1.notifyIcon1.ShowBalloonTip(1000, Resources.UpdateErrToastTitle, ex.Message + Resources.ExRe_Reinstall, ToolTipIcon.Error);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                Settings.Default.doDelete = false;
            else
                Settings.Default.doDelete = true;
            Settings.Default.Save();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                Settings.Default.doTopmost = false;
            else
                Settings.Default.doTopmost = true;
            Settings.Default.Save();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                Settings.Default.doTransparent = false;
            else
                Settings.Default.doTransparent = true;
            Settings.Default.Save();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = "当前值：" + trackBar1.Value.ToString() + "%";
            Settings.Default.Opacity = trackBar1.Value;
            Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.InitialWord = textBox1.Text;
            Settings.Default.Save();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
                Settings.Default.doExitConfirm = false;
            else
                Settings.Default.doExitConfirm = true;
            Settings.Default.Save();
        }
    }
}
