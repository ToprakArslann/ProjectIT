using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Security.Policy;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;




namespace projectit
{
    public partial class Form1 : Form
    {

        
        
        public bool mouseDown;
        private Point lastLocation;
        public bool specsMenu = false;
        public bool ipMenu = false;
        public bool progbarIp = false;
        private SpecsUserControl usrContr = new SpecsUserControl();
        private IpUserControl ipContr = new IpUserControl();


        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {            
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown=false;
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       

        }

        private void Add_UControlsMain(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Add_UControlsSide(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PnlSide.Controls.Clear();
            PnlSide.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            cmbSpecList.Items.Clear();

            foreach (var pnl in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.FromArgb(52, 52, 52);
            }

            string[] specsItems = { "cpu", "gpu", "all" };
            string[] ipItems = { "Ip Quary", "Local Ip's", "ports" };
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "BtnSpecs":
                    cmbSpecList.Visible = true;
                    btnGetSpecs.Visible = true;
                    PnlMain.Size = new Size(320, 367);
                    Add_UControlsSide(new UserControl5());
                    Add_UControlsMain(usrContr);
                    cmbSpecList.Items.AddRange(specsItems);
                    PnlSpecs.BackColor = Color.White;
                    break;
                case "BtnTask":
                    cmbSpecList.Visible = false;
                    btnGetSpecs.Visible = false;
                    PnlMain.Size = new Size(320, 367);
                    Add_UControlsMain(usrContr);
                    PnlTask.BackColor = Color.White;
                    break;
                case "BtnDisk":
                    btnGetSpecs.Visible = false;
                    cmbSpecList.Visible = false;
                    PnlMain.Size = new Size(320, 367);
                    Add_UControlsMain(new TweaksControl());
                    PnlDisk.BackColor = Color.White;
                    break;
                case "BtnIp":
                    cmbSpecList.Visible = true;
                    btnGetSpecs.Visible = true;
                    PnlMain.Size = new Size(507, 367);
                    Add_UControlsMain(ipContr);
                    cmbSpecList.Items.AddRange(ipItems);
                    PnlIp.BackColor = Color.White;
                    break;
                case "BtnInfo":
                    cmbSpecList.Visible = false;
                    btnGetSpecs.Visible = false;
                    PnlMain.Size = new Size(320, 367);
                    Add_UControlsMain(new UserControl4());
                    PnlInfo.BackColor = Color.White;
                    break;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        public void btnGetSpecs_Click(object sender, EventArgs e)
        {
            if (cmbSpecList.SelectedItem == "cpu")
            {
                usrContr.pnlCpu.Visible = true;
                usrContr.pnlGpu.Visible = false;
                usrContr.GetProcessInfo();
            }
            else if (cmbSpecList.SelectedItem == "gpu")
            {
                usrContr.pnlCpu.Visible = false;
                usrContr.pnlGpu.Visible = true;
                usrContr.GetVideoCardInfo();
            }
            else if (cmbSpecList.SelectedItem == "all")
            {

            }
            else if (cmbSpecList.SelectedItem == "Ip Quary")
            {
                ipContr.panel1.Visible = false ;
            }
            else if (cmbSpecList.SelectedItem == "Local Ip's")
            {
                ipContr.panel1.Visible = true;

            }
            else if (cmbSpecList.SelectedItem == "ports")
            {
                ipContr.panel1.Visible = false;

            }
        }

        private void PnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelaaaa_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
