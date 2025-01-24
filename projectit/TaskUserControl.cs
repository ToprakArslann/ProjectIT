using System;
using System.Collections;
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
        private int id;
        private bool _status;
        private string statusStr;
        private void TaskUserControl_Load(object sender, EventArgs e)
        {
            GetProcesses();
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

                _name = proc.ProcessName.ToString();
                id = proc.Id;
                _status = proc.Responding;
                statusStr = _status ? "Working" : "No Responding";
                string[] _lst = [_name, id.ToString(), statusStr];
                ListViewItem lst = new ListViewItem(_lst);
                listView1.Items.Add(lst);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                button3.Enabled = false;
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Process selectedProcess = Process.GetProcessById(int.Parse(selectedItem.SubItems[1].Text));
                selectedProcess.Kill();
                await Task.Delay(500);
                GetProcesses();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please Select An Process To Kill","ProjectIT",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            catch
            {
                MessageBox.Show("Error Occurred While Killing Application.","ProjectIT",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            finally
            {
                button3.Enabled = true;
            }
        }
    }
}
