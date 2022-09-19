using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace 点名器
{
    public partial class wb : Form
    {
        public wb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webView21.Refresh();
        }

        private void wb_Load(object sender, EventArgs e)
        {
            Uri support = new Uri("https://eow.lykns.tk/connect");
            Uri dev = new Uri("https://dev.lykns.tk/");
            if (Properties.Settings.Default.web == 0)
            {
                webView21.Source = support;
                textBox1.Text = "[LYKNS 站点]" + support.ToString();
            }
            if (Properties.Settings.Default.web == 1)
            {
                webView21.Source = dev;
                textBox1.Text = "[LYKNS 站点]"+dev.ToString();
            }
        }
    }
}
