using System;
using System.IO;
using System.Windows.Forms;
using 新一代CaptB点名器.Properties;

namespace 新一代CaptB点名器
{
    public partial class Content : Form
    {
        public Content()
        {
            InitializeComponent();
        }

        string[] strings;

        private void Content_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Content == true)
            {
                label2.Text = Program.num.ToString() + Resources.Units;
                try
                {
                    strings = File.ReadAllLines(Program.cbcfpath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + Resources.ExRe_RR, Resources.CErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            else
            {
                label1.Text = "未点人数：";
                int display_num = Program.num - Program.called_num;
                label2.Text = display_num + Resources.Units;
                try
                {
                    strings = File.ReadAllLines(Program.cfpath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + Resources.ExRe_RR, Resources.CErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            listView1.BeginUpdate();
            for (int i = 1; i < Program.num + 1; i++)
            {
                ListViewItem listViewItem = new ListViewItem
                {
                    Text = strings[i]
                };
                if (listViewItem.Text != "")
                    listView1.Items.Add(listViewItem);
            }
            listView1.EndUpdate();
        }
    }
}
