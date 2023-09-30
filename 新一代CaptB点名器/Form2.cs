using System;
using System.Threading;
using System.Windows.Forms;
using 新一代CaptB点名器.Properties;

namespace 新一代CaptB点名器
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ActiveControl = button1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Settings.Default.doTransparent == true)
            {
                Opacity = (double)Settings.Default.Opacity / 100;
                checkBox1.Checked = true;
            }
            else
            {
                Opacity = 100;
                checkBox1.Checked = false;
            }
            if (Settings.Default.doTopmost == true)
            {
                TopMost = true;
                checkBox2.Checked = true;
            }
            else
            {
                TopMost = false;
                checkBox2.Checked = false;
            }
            if (Program.called_name == string.Empty)
            {
                textBox1.Text = Settings.Default.InitialWord;
            }
            else
            {
                textBox1.Text = Program.called_name;
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Settings.Default.doTransparent = true;
                Settings.Default.Save();
                Opacity = (double)Settings.Default.Opacity / 100;
            }
            else
            {
                Settings.Default.doTransparent = false;
                Settings.Default.Save();
                Opacity = 100;
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Settings.Default.doTopmost = true;
                Settings.Default.Save();
                TopMost = true;
            }
            else
            {
                Settings.Default.doTopmost = false;
                Settings.Default.Save();
                TopMost = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.call();
            textBox1.Text = Program.called_name;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1(null).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Reset();
            textBox1.Text = Settings.Default.InitialWord;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            Height = 203;
            ActiveControl = button1;
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
    }
}
