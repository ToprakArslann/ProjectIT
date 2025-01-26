using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectit
{
    public partial class TaskUserControl : UserControl
    {
        ManagementEventWatcher processStartWatcher = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStartTrace");
        ManagementEventWatcher processStopWatcher = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStopTrace");

        public TaskUserControl()
        {
            InitializeComponent();
            processStartWatcher.EventArrived += new EventArrivedEventHandler(processStartWatcher_EventArrived);
            processStartWatcher.Start();
            processStopWatcher.EventArrived += new EventArrivedEventHandler(processStopWatcher_EventArrived);
            processStopWatcher.Start();
        }
        private string _name;
        private int id;
        private bool _status;
        private string statusStr;
        private string _path;
        private void TaskUserControl_Load(object sender, EventArgs e)
        {
            listView1.Columns[3].Width = 0;
            GetProcesses();
        }

        private void processStartWatcher_EventArrived(object sender, EventArrivedEventArgs e)
        {
            try
            {
                string pathNew = "";
                string nameNew = e.NewEvent.Properties["ProcessName"].Value.ToString();
                int idNew = int.Parse(e.NewEvent.Properties["ProcessID"].Value.ToString());
                Process proc = Process.GetProcessById(idNew);
                try
                {
                    pathNew = proc.MainModule.FileName;
                }
                catch(SecurityAccessDeniedException)
                {
                    pathNew = "Access Denied";
                }
                catch
                {
                }
                bool _statusNew = proc.Responding;
                string statusStrNew = _statusNew ? "Working" : "No Responding";
                string[] lst = [nameNew, idNew.ToString(), statusStrNew, pathNew];
                if (listView1.InvokeRequired)
                {
                    listView1.Invoke(new Action(() =>
                        listView1.Items.Add(new ListViewItem(lst))
                    ));
                }
                else
                {
                    listView1.Items.Add(new ListViewItem(lst));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void processStopWatcher_EventArrived(object sender, EventArrivedEventArgs e)
        {
            try
            {
                string idNew = e.NewEvent.Properties["ProcessID"].Value.ToString();
                if (listView1.InvokeRequired)
                {
                    listView1.Invoke(new Action(() =>
                        {
                            foreach (ListViewItem lst in listView1.Items)
                            {
                                if (lst.SubItems[1].Text == idNew)
                                {
                                    listView1.Items.Remove(lst);
                                }
                            }
                        }
                    ));
                }
                else
                {
                    foreach (ListViewItem lst in listView1.Items)
                    {
                        if (lst.SubItems[0].Text == idNew)
                        {
                            listView1.Items.Remove(lst);
                        }
                    }
                }
                
            }
            catch
            {
            }
        }
        private bool ascending = true;
        private int sortColumn = -1;
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == sortColumn)
            {
                ascending = !ascending;
            }
            else
            {
                ascending = true;
            }
            sortColumn = e.Column;
            listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, ascending);
            listView1.Sort();
        }
        private class ListViewItemComparer : IComparer<ListViewItem>, IComparer
        {
            private readonly int columnIndex;
            private readonly bool ascending;

            public ListViewItemComparer(int columnIndex, bool ascending)
            {
                this.columnIndex = columnIndex;
                this.ascending = ascending;
            }

            public int Compare(ListViewItem x, ListViewItem y)
            {
                string textX = x.SubItems[columnIndex].Text;
                string textY = y.SubItems[columnIndex].Text;

                if (columnIndex == 1)
                {
                    int processIdX = int.Parse(textX);
                    int processIdY = int.Parse(textY);
                    return ascending ? processIdX.CompareTo(processIdY) : processIdY.CompareTo(processIdX);
                }

                return ascending ? string.Compare(textX, textY) : string.Compare(textY, textX);
            }
            int IComparer.Compare(object x, object y)
            {
                return Compare((ListViewItem)x, (ListViewItem)y);
            }
        }
        private void GetProcesses()
        {
            listView1.Items.Clear();

            Process[] processes = Process.GetProcesses();

            foreach (Process proc in processes)
            {
                _name = proc.ProcessName;
                try
                {
                    _path = proc.MainModule.FileName;
                    string extension = Path.GetExtension(_path).ToLower();
                    _name += extension;
                }
                catch(SecurityAccessDeniedException)
                {
                    _path = "Access Denied";
                }
                catch
                {
                }
                id = proc.Id;
                _status = proc.Responding;
                statusStr = _status ? "Working" : "No Responding";
                
                string[] _lst = [_name, id.ToString(), statusStr, _path];
                ListViewItem lst = new ListViewItem(_lst);
                listView1.Items.Add(lst);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Process selectedProcess = Process.GetProcessById(int.Parse(selectedItem.SubItems[1].Text));
                selectedProcess.Kill();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please Select An Process To Kill", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch
            {
                MessageBox.Show("Error Occurred While Killing Application.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error Occurred While Running Application.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Process selectedProcess = Process.GetProcessById(int.Parse(selectedItem.SubItems[1].Text));
                selectedProcess.Kill();
            }
            catch
            {
                MessageBox.Show("Error Occurred While Killing Application.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }
    }
}
