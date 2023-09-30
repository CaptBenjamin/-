using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 名单编辑器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int num = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                ListViewItem listViewItem = new ListViewItem
                {
                    Text = textBox1.Lines[i]
                };
                if (listViewItem.Text != "")
                    listView1.Items.Add(listViewItem);
                num++;
            }
            listView1.EndUpdate();
            toolStripStatusLabel2.Text = num.ToString();
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {

        }
    }
}
