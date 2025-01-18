using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
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


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        Ping ping = new Ping();
        private async void button1_Click(object sender, EventArgs e)
        {
            string[] _usedIps = []; 
            string[] _nonusedIps = [];
            List<string> usedIps = new List<string>();
            List<string> nonusedIps = new List<string>();
            try
            {
                var pCont = this.Parent as Panel;
                var form1 = pCont.TopLevelControl as Form1;

                button1.Enabled = false;

                progressBar1.Value = 0;
                listBox1.Items.Clear();
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
                        usedIps.Add(result);
                    }
                    else
                    {
                        nonusedIps.Add(result);
                    }
                    progressBar1.Value++;
                }
                if (progressBar1.Value == progbarMinus)
                {
                    button1.Enabled = true;
                }
                _usedIps = usedIps.ToArray();
                _nonusedIps = nonusedIps.ToArray();
                listBox1.Items.AddRange(_usedIps);
                listBox2.Items.AddRange(_nonusedIps);
    

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ip format.");
                button1.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured Please Try Again.");
                button1.Enabled = true;
            }
        }

        private async void IpUserControl_Load(object sender, EventArgs e)
        {
            IPAddress google = IPAddress.Parse("8.8.8.8");
            PingReply checkConnection = await ping.SendPingAsync(google);
            if (checkConnection.Status == IPStatus.Success)
            {
                Console.WriteLine(checkConnection.Status);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.OnLoad(EventArgs.Empty);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            progressBar1.Value = 0;
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            ListBox lstBox1 = sender as ListBox;
            toolTip.SetToolTip(lstBox1, lstBox1.SelectedItem.ToString());
        }
    }
}
    
