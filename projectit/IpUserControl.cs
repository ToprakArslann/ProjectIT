﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectit
{
    public partial class IpUserControl : UserControl
    {


        private ToolTip toolTip = new ToolTip();


        public IpUserControl()
        {
            InitializeComponent();


        }

        Ping ping = new Ping();
        private string name = "";
        private string mac = "";
        private string ip = "";

        // Searches The Local Ips.
        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var pCont = this.Parent as Panel;
                var form1 = pCont.TopLevelControl as Form1;

                button1.Enabled = false;

                progressBar1.Value = 0;
                listView1.Items.Clear();
                string ip1 = txtIp1.Text.Substring(txtIp1.Text.LastIndexOf(".") + 1);
                int ipInt1 = int.Parse(ip1);
                int ipInt2 = ipInt1 + Convert.ToInt32(numericUpDown1.Value);

                int progbarMinus = ipInt2 - ipInt1 + 1;
                progressBar1.Maximum = progbarMinus;

                string beginingIp = txtIp1.Text.Substring(0, txtIp1.Text.LastIndexOf("."));

                for (int i = ipInt1; i <= ipInt2; i++)
                {

                    string result = beginingIp + "." + i.ToString();
                    IPAddress my = IPAddress.Parse(result);
                    PingReply answer = await ping.SendPingAsync(my);

                    if (answer.Status == IPStatus.Success)
                    {

                        ip = result;
                        name = GetHostName(result);

                        string[] _usedIps = [name, ip, mac];
                        ListViewItem lst = new ListViewItem(_usedIps);
                        listView1.Items.Add(lst);
                    }

                    progressBar1.Value++;
                }
                if (progressBar1.Value == progbarMinus)
                {
                    button1.Enabled = true;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ip format.");
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured Please Try Again." + ex);
                button1.Enabled = true;
            }
        }
        // Get Host Name Of Ip.
        private string GetHostName(string ipAddress)
        {
            try
            {
                IPHostEntry iphost = Dns.GetHostEntry(ipAddress);
                if (iphost != null)
                {
                    return iphost.HostName.ToString();
                }

            }
            catch (SocketException)
            {
                return "";
            }
            return null;
        }

        // Check Internet Connection.
        private async void IpUserControl_Load(object sender, EventArgs e)
        {
            IPAddress google = IPAddress.Parse("8.8.8.8");
            PingReply checkConnection = await ping.SendPingAsync(google);
            if (checkConnection.Status == IPStatus.Success)
            {
                string hostname = Dns.GetHostName();
                string thisIp = Dns.GetHostByName(hostname).AddressList[0].ToString();
                txtIp1.Enabled = true;
                numericUpDown1.Enabled = true;
                button1.Enabled = true;
                label1.Text = thisIp;
            }
            else
            {
                Console.WriteLine(checkConnection.Status);
                txtIp1.Enabled = false;
                numericUpDown1.Enabled = false;
                button1.Enabled = false;
                label1.Text = "Unable to Connect.";
            }

        }

        // Refresh UserControl
        private void button2_Click(object sender, EventArgs e)
        {
            this.OnLoad(EventArgs.Empty);
            listView1.Items.Clear();
            progressBar1.Value = 0;
        }
    }
}
    
