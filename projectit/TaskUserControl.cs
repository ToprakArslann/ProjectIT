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
    public partial class TaskUserControl : UserControl
    {
        public TaskUserControl()
        {
            InitializeComponent();
        }
        private string _name;
        private string id;
        private bool _status;
        private string statusStr;
        private void TaskUserControl_Load(object sender, EventArgs e)
        {
            GetProcesses();
        }
        private void GetProcesses()
        {
            Process[] processes = Process.GetProcesses();


            foreach (Process proc in processes)
            {
                string[] _lst = [_name, id, statusStr];

                ListViewItem lst = new ListViewItem(_lst);
                _name = proc.ProcessName.ToString();
                id = proc.Id.ToString();
                _status = proc.Responding;
                statusStr = _status ? "Working" : "No Responding";
                listView1.Items.Add(lst);
            }
        }
    }
}
