using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 点名器
{
    public partial class content : Form
    {
        public content()
        {
            InitializeComponent();
            var fileContent = string.Empty;
            if (Properties.Settings.Default.content==1)
            {
                var fileStream = Application.StartupPath + @"\cbcf.txt";

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }

                textBox1.Text= fileContent;
            }
            else
            {
                if (Properties.Settings.Default.content == 2)
                {
                    var fileStream = Application.StartupPath + @"\cf.txt";

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    textBox1.Text = fileContent;
                }
            }
        }
    }
}
