using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Windows.Networking;
using 新一代CaptB点名器.Properties;

namespace 新一代CaptB点名器
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length == 2)
                Application.Run(new Form1(args[1]));
            else
                Application.Run(new Form1(null));
        }
        public static int num;
        public static int called_num = 0;
        public static string called_name = string.Empty;
        public static string ProgramData = "%PROGRAMDATA%";
        public static string ProgramDatadirectoryPath = Environment.ExpandEnvironmentVariables(ProgramData) + @"\CBRC";
        public static string cbcfpath = ProgramDatadirectoryPath + @"\cbcf.file";
        public static string cfpath = ProgramDatadirectoryPath + @"\cf.file";
        public static void Import(string ImportFilePath)
        {
            try
            {
                File.Copy(ImportFilePath, cbcfpath, true);
                File.Copy(ImportFilePath, cfpath, true);
                string[] strings = File.ReadAllLines(cfpath);
                int.TryParse(strings[0], out num);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ImportErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form1 form1 = new Form1(null);
            form1.notifyIcon1.ShowBalloonTip(1000, Resources.ImportToastTitle, Resources.ImportToastContent, ToolTipIcon.Info);
        }
        public static void Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            saveFileDialog.Filter = "CaptB点名器名单文件（*.cbcf）|*.cbcf|文本文档（*.txt）|*.txt";
            saveFileDialog.Title = Resources.SaveFileDialogTitle;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string SaveFilePath = saveFileDialog.FileName;
                try
                {
                    File.Copy(cbcfpath, SaveFilePath);
                    Form1 form1 = new Form1(null);
                    form1.notifyIcon1.ShowBalloonTip(1000, Resources.SaveToastTitle, Resources.SaveToastContent, ToolTipIcon.Info);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.SaveErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void call()
        {
            try
            {
            Retry:
                Random random = new Random();
                int n = random.Next(1, num + 1);
                StreamReader streamReader = new StreamReader(cfpath);
                string str = streamReader.ReadToEnd();
                string[] strings = Regex.Split(str, "\r\n");
                string lastname = strings[strings.Length - n];
                streamReader.Close();
                if (called_num == num)
                {
                    if (MessageBox.Show(Resources.OverflowContent, Resources.OverflowTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        Reset();
                    }
                }
                else
                {
                    if (lastname == "")
                        goto Retry;
                    called_name = lastname;
                    if (Settings.Default.doDelete == true)
                    {
                        called_num++;
                        string s = File.ReadAllText(cfpath);
                        s = s.Replace(called_name, string.Empty);
                        File.WriteAllText(cfpath, s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.OverflowTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                called_num = 0;
                called_name = Settings.Default.InitialWord;
            }
        }
        public static void Reset()
        {
            try
            {
                File.Delete(cfpath);
                File.Copy(cbcfpath, cfpath, true);
                called_num = 0;
                called_name = Settings.Default.InitialWord;
                Form1 form1 = new Form1(null);
                form1.notifyIcon1.ShowBalloonTip(1000, Resources.ResetToastTitle, Resources.ResetToastContent, ToolTipIcon.Info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ResetErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
