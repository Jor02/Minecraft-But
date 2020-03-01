using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_But
{
    public partial class About : Form
    {
        Font font;

        public About(Font McFont)
        {
            font = McFont;
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            AboutText.Font = font;
            Version.Font = font;
            Version.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
