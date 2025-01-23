using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectit
{
    public partial class InfoUserControl : UserControl
    {
        public InfoUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo
            {
                FileName = "https://www.github.com/ToprakArslann/ProjectIT",
                UseShellExecute = true
            };

            Process.Start(info);
        }
    }
}
