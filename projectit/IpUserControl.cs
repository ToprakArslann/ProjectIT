using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectit
{
    public partial class IpUserControl : UserControl
    {


        private ToolTip toolTip = new ToolTip();

        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);
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
                string thisIp = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
                for (int i = ipInt1; i <= ipInt2; i++)
                {

                    string result = beginingIp + "." + i.ToString();
                    IPAddress my = IPAddress.Parse(result);
                    PingReply answer = await ping.SendPingAsync(my);

                    


                    if (answer.Status == IPStatus.Success)
                    {

                        ip = result;
                        name = GetHostName(result);

                        if (result == thisIp)
                        {
                            mac =
                                (
                                    from nic in NetworkInterface.GetAllNetworkInterfaces()
                                    where nic.OperationalStatus == OperationalStatus.Up
                                    select nic.GetPhysicalAddress().ToString()
                                ).FirstOrDefault();
                        }
                        else
                        {
                            try
                            {
                                byte[] ab = new byte[6];
                                int len = ab.Length,
                                    r = SendARP((int)my.Address, 0, ab, ref len);
                                mac = BitConverter.ToString(ab, 0, 6);
                            }
                            catch (DllNotFoundException)
                            {
                                MessageBox.Show("Error occurred while founding dll.");
                            }
                            catch
                            {
                                MessageBox.Show("Error occurred");
                            }
                        }

                        if (mac != string.Empty)
                        {
                            string[] _usedIps = [name, ip, mac];
                            ListViewItem lst = new ListViewItem(_usedIps);
                            listView1.Items.Add(lst);
                        }
                        
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
                string thisIp = Dns.GetHostEntry(hostname).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
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


        // Ip Query
        private async void button3_Click(object sender, EventArgs e)
        {
            string url = $"http://ip-api.com/json/{textBox2.Text}?fields=status,message,continent,continentCode,country,countryCode,region,regionName,city,district,zip,timezone,currency,isp,org,mobile,proxy,hosting,query";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        using (JsonDocument document = JsonDocument.Parse(responseBody))
                        {
                            JsonElement root = document.RootElement;
                            string status = root.GetProperty("status").ToString();
                            if (status == "success")
                            {
                                string country = root.GetProperty("country").ToString();
                                string city = root.GetProperty("city").ToString();
                                string zip = root.GetProperty("zip").ToString();
                                string timeZone = root.GetProperty("timezone").ToString();
                                string currency = root.GetProperty("currency").ToString();
                                string isp = root.GetProperty("isp").ToString();
                                string org = root.GetProperty("org").ToString();
                                bool mobile = root.GetProperty("mobile").GetBoolean();
                                bool proxy = root.GetProperty("proxy").GetBoolean();
                                bool hosting = root.GetProperty("hosting").GetBoolean();

                                textBox1.Text = country;
                                textBox3.Text = city;
                                textBox4.Text = zip;
                                textBox5.Text = currency;
                                textBox6.Text = isp;
                                textBox7.Text = org;
                                textBox8.Text = timeZone;
                                textBox9.Text = mobile.ToString();
                                textBox10.Text = proxy.ToString();
                                textBox11.Text = hosting.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Failed!\n" + root.GetProperty("message"),"ProjectIT",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            }
                            
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Check Your Internet Connection And Try Again!", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("An Error Occurred During Query!", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
    
