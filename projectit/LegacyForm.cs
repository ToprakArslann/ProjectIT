using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectit
{
    public partial class LegacyForm : Form
    {
        public LegacyForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Legacy Menus Buttons
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch(btn.Name)
            {
                case "controlBtn":
                    try
                    {
                        Process.Start("control");
                    }
                    catch
                    {
                        MessageBox.Show("Cant open Control Panel.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "networksBtn":
                    try
                    {
                        Process.Start("control","ncpa.cpl");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cant open Network Panel." + ex, "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "powerBtn":
                    try
                    {
                        Process.Start("control","powercfg.cpl");
                    }
                    catch
                    {
                        MessageBox.Show("Cant open Power Panel.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "printerBtn":
                    try
                    {
                        Process.Start("control", "printers");
                    }
                    catch
                    {
                        MessageBox.Show("Cant open Printer Panel.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "regionBtn":
                    try
                    {
                        Process.Start("control", "intl.cpl");
                    }
                    catch
                    {
                        MessageBox.Show("Cant open Region Panel.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "soundBtn":
                    try
                    {
                        Process.Start("control", "mmsys.cpl");
                    }
                    catch
                    {
                        MessageBox.Show("Cant open Sound Panel.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "sysBtn":
                    try
                    {
                        Process.Start("control", "sysdm.cpl");
                    }
                    catch
                    {
                        MessageBox.Show("Cant open System Properties Panel.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "userBtn":
                    try
                    {
                        Process.Start("mmc","lusrmgr.msc");
                    }
                    catch
                    {
                        MessageBox.Show("Cant open User Panel.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }

        }
    }
}
