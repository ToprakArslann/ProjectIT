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

namespace projectit
{
    public partial class SpecsUserControl : UserControl
    {
        

        private ToolTip toolTip = new ToolTip();
        public SpecsUserControl()
        {
            InitializeComponent();
            
        }

        private void lblCpu_Click(object sender, EventArgs e)
        {

        }

        /* UnOptimized
        public void GetVideoCardInfo()
        {
            Console.WriteLine("video");
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");

                foreach (ManagementObject obj in searcher.Get())
                {
                    string videoName = string.IsNullOrEmpty(obj["Caption"]?.ToString()) ? "unknown" : obj["Caption"].ToString();
                    string videoAdapter = string.IsNullOrEmpty(obj["AdapterCompatibility"]?.ToString()) ? "unknown" : obj["AdapterCompatibility"].ToString();
                    double videoByteMemory = Convert.ToDouble(obj["AdapterRAM"]);
                    double videoGbMemory = (videoByteMemory / (1024.0 * 1024 * 1024));
                    int videoAvailabilityInt = Convert.ToInt32(obj["Availability"]);
                    string videoAvailabilityStr = GetAvailabilityStatus(videoAvailabilityInt);
                    int videoStatusInt = Convert.ToInt32(obj["ConfigManagerErrorCode"]);
                    string videoStatusStr = GetErrorDescription(videoStatusInt);
                    string videoColorBit = string.IsNullOrEmpty(obj["CurrentBitsPerPixel"]?.ToString()) ? "unknown" : obj["CurrentBitsPerPixel"].ToString() ;
                    string videoRes = obj["CurrentHorizontalResolution"].ToString() + "x" + obj["CurrentVerticalResolution"].ToString();
                    string videoHz = obj["CurrentRefreshRate"].ToString() + " hz";
                    string videoDriverDateStr = string.IsNullOrEmpty(obj["DriverDate"]?.ToString()) ? "unknown" : obj["DriverDate"].ToString();
                    string videoDriverDate = videoDriverDateStr == "unknown" ? "unknown" : videoDriverDateStr.Substring(0, 4) + "/" + videoDriverDateStr.Substring(4,2) + "/" + videoDriverDateStr.Substring(6,2);
                    string videoDriverVers = string.IsNullOrEmpty(obj["DriverVersion"]?.ToString()) ? "unknown" : obj["DriverVersion"].ToString();
                    string videoMaxHz = obj["MaxRefreshRate"].ToString();
                    string videoMinHz = obj["MinRefreshRate"].ToString();
                    int videoArchitecture = Convert.ToInt32(obj["VideoArchitecture"]);
                    int videoMemoryType = Convert.ToInt32(obj["VideoMemoryType"]);
                    string videoProcessor = obj["VideoProcessor"].ToString();



                    Console.WriteLine(videoName);
                    Console.WriteLine(videoAdapter);
                    Console.WriteLine(videoGbMemory + " vram");
                    Console.WriteLine(videoAvailabilityStr);
                    Console.WriteLine(videoStatusStr);
                    Console.WriteLine(videoColorBit);
                    Console.WriteLine(videoRes);
                    Console.WriteLine(videoHz);
                    Console.WriteLine(videoDriverDate);
                    Console.WriteLine(videoDriverVers);
                    Console.WriteLine(videoMaxHz + " Hz max");
                    Console.WriteLine(videoMinHz + " Hz min");
                    Console.WriteLine(GetVideoArchitecture(videoArchitecture));
                    Console.WriteLine(GetVideoMemoryType(videoMemoryType));
                    Console.WriteLine(videoProcessor);


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        */
        // Optimized By Ai
        public void GetVideoCardInfo()
        {
            Console.WriteLine("Video Information:");
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");

                foreach (ManagementObject obj in searcher.Get())
                {
                    // Helper methods for safe conversion and default values
                    string GetSafeString(string key) => string.IsNullOrEmpty(obj[key]?.ToString()) ? "Unknown" : obj[key].ToString();
                    double GetSafeDouble(string key) => double.TryParse(obj[key]?.ToString(), out double value) ? value : 0;
                    int GetSafeInt(string key) => int.TryParse(obj[key]?.ToString(), out int value) ? value : 0;

                    // Video card information
                    string videoName = GetSafeString("Caption");
                    string videoAdapter = GetSafeString("AdapterCompatibility");
                    double videoByteMemory = GetSafeDouble("AdapterRAM");
                    double videoGbMemory = videoByteMemory / (1024.0 * 1024 * 1024);
                    int videoAvailabilityInt = GetSafeInt("Availability");
                    string videoAvailabilityStr = GetAvailabilityStatus(videoAvailabilityInt);
                    int videoStatusInt = GetSafeInt("ConfigManagerErrorCode");
                    string videoStatusStr = GetErrorDescription(videoStatusInt);
                    string videoColorBit = GetSafeString("CurrentBitsPerPixel");
                    string videoRes = $"{GetSafeString("CurrentHorizontalResolution")}x{GetSafeString("CurrentVerticalResolution")}";
                    string videoHz = $"{GetSafeString("CurrentRefreshRate")} Hz";
                    string videoDriverDateStr = GetSafeString("DriverDate");
                    string videoDriverDate = videoDriverDateStr == "Unknown" ? "Unknown" : $"{videoDriverDateStr.Substring(0, 4)}/{videoDriverDateStr.Substring(4, 2)}/{videoDriverDateStr.Substring(6, 2)}";
                    string videoDriverVers = GetSafeString("DriverVersion");
                    string videoMaxHz = GetSafeString("MaxRefreshRate");
                    string videoMinHz = GetSafeString("MinRefreshRate");
                    int videoArchitecture = GetSafeInt("VideoArchitecture");
                    int videoMemoryType = GetSafeInt("VideoMemoryType");
                    string videoProcessor = GetSafeString("VideoProcessor");
                    // Output
                    txtGpuName.Text = $"{videoName}";
                    txtGpuAdapter.Text =$"{videoAdapter}";
                    txtGpuMemory.Text =$"{Math.Round(videoGbMemory, 2)} GB VRAM";
                    txtGpuAvai.Text =$"{videoAvailabilityStr}";
                    txtGpuStatus.Text =$"{videoStatusStr}";
                    txtGpuColor.Text =$"{videoColorBit} bit";
                    txtRes.Text =$"{videoRes}";
                    txtHz.Text =$"{videoHz}";
                    txtGpuDDate.Text =$"{videoDriverDate}";
                    txtGpuDVers.Text =$"{videoDriverVers}";
                    txtMaxHz.Text =$"{videoMaxHz} Hz";
                    txtMinHz.Text =$"{videoMinHz} Hz";
                    txtGpuArch.Text =$"{GetVideoArchitecture(videoArchitecture)}";
                    txtGpuMemType.Text =$"{GetVideoMemoryType(videoMemoryType)}";
                    txtGpuProcessor.Text =$"{videoProcessor}";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        public static string GetVideoMemoryType(int videoMemoryType)
        {
            switch (videoMemoryType)
            {
                case 1:
                    return "Other";

                case 2:
                    return "Unknown";

                case 3:
                    return "VRAM";

                case 4:
                    return "DRAM";

                case 5:
                    return "SRAM";

                case 6:
                    return "WRAM";

                case 7:
                    return "EDO RAM";

                case 8:
                    return "Burst Synchronous DRAM";

                case 9:
                    return "Pipelined Burst SRAM";

                case 10:
                    return "CDRAM";

                case 11:
                    return "3DRAM";

                case 12:
                    return "SDRAM";

                case 13:
                    return "SGRAM";

                default:
                    return "Unknown Memory Type";
            }
        }

        public static string GetVideoArchitecture(int videoType)
        {
            switch (videoType)
            {
                case 1:
                    return "Other";
                case 2:
                    return "Unknown";
                case 3:
                    return "CGA";
                case 4:
                    return "EGA";
                case 5:
                    return "VGA";
                case 6:
                    return "SVGA";
                case 7:
                    return "MDA";
                case 8:
                    return "HGC";
                case 9:
                    return "MCGA";
                case 10:
                    return "8514A";
                case 11:
                    return "XGA";
                default:
                    return "Unknown Type";
            }

        }

        public static string GetErrorDescription(int errorCode)
        {
            switch (errorCode)
            {
                case 0:
                    return "This device is working properly.";
                case 1:
                    return "This device is not configured correctly.";
                case 2:
                    return "Windows cannot load the driver for this device.";
                case 3:
                    return "The driver for this device might be corrupted, or your system may be running low on memory or other resources.";
                case 4:
                    return "This device is not working properly. One of its drivers or your registry might be corrupted.";
                case 5:
                    return "The driver for this device needs a resource that Windows cannot manage.";
                case 6:
                    return "The boot configuration for this device conflicts with other devices.";
                case 7:
                    return "Cannot filter.";
                case 8:
                    return "The driver loader for the device is missing.";
                case 9:
                    return "This device is not working properly because the controlling firmware is reporting the resources for the device incorrectly.";
                case 10:
                    return "This device cannot start.";
                case 11:
                    return "This device failed.";
                case 12:
                    return "This device cannot find enough free resources that it can use.";
                case 13:
                    return "Windows cannot verify this device's resources.";
                case 14:
                    return "This device cannot work properly until you restart your computer.";
                case 15:
                    return "This device is not working properly because there is probably a re-enumeration problem.";
                case 16:
                    return "Windows cannot identify all the resources this device uses.";
                case 17:
                    return "This device is asking for an unknown resource type.";
                case 18:
                    return "Reinstall the drivers for this device.";
                case 19:
                    return "Failure using the VxD loader.";
                case 20:
                    return "Your registry might be corrupted.";
                case 21:
                    return "System failure: Try changing the driver for this device. If that does not work, see your hardware documentation. Windows is removing this device.";
                case 22:
                    return "This device is disabled.";
                case 23:
                    return "System failure: Try changing the driver for this device. If that doesn't work, see your hardware documentation.";
                case 24:
                    return "This device is not present, is not working properly, or does not have all its drivers installed.";
                case 25:
                    return "Windows is still setting up this device.";
                case 26:
                    return "Windows is still setting up this device.";
                case 27:
                    return "This device does not have valid log configuration.";
                case 28:
                    return "The drivers for this device are not installed.";
                case 29:
                    return "This device is disabled because the firmware of the device did not give it the required resources.";
                case 30:
                    return "This device is using an Interrupt Request (IRQ) resource that another device is using.";
                case 31:
                    return "This device is not working properly because Windows cannot load the drivers required for this device.";
                default:
                    return "Unknown error code.";
            }
        }

        static string GetAvailabilityStatus(int availability)
        {
            switch (availability)
            {
                case 1:
                    return "Other";
                case 2:
                    return "Unknown";
                case 3:
                    return "Running/Full Power";
                case 4:
                    return "Warning";
                case 5:
                    return "In Test";
                case 6:
                    return "Not Applicable";
                case 7:
                    return "Power Off";
                case 8:
                    return "Off Line";
                case 9:
                    return "Off Duty";
                case 10:
                    return "Degraded";
                case 11:
                    return "Not Installed";
                case 12:
                    return "Install Error";
                case 13:
                    return "Power Save - Unknown";
                case 14:
                    return "Power Save - Low Power Mode";
                case 15:
                    return "Power Save - Standby";
                case 16:
                    return "Power Cycle";
                case 17:
                    return "Power Save - Warning";
                case 18:
                    return "Paused";
                case 19:
                    return "Not Ready";
                case 20:
                    return "Not Configured";
                case 21:
                    return "Quiesced";
                default:
                    return "Unknown Status";
            }
        }

        public void GetProcessInfo()
        {
            Console.WriteLine("proc");
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

                foreach (ManagementObject obj in searcher.Get())
                {
                    string processorName = obj["Name"].ToString();
                    string processorCurrentClockS = obj["CurrentClockSpeed"].ToString();
                    string processor64bit = obj["DataWidth"].ToString();
                    string processorVoltage = obj["CurrentVoltage"].ToString();
                    string processorDesc = obj["Description"].ToString();
                    string processorID = obj["DeviceID"].ToString();
                    string processorManufacturer = obj["Manufacturer"].ToString();
                    string processorCores = obj["NumberOfCores"].ToString();
                    string processorLogicalProcessors = obj["NumberOfLogicalProcessors"].ToString();
                    string proccesorID = obj["ProcessorId"].ToString();
                    string proccesorSerialNO = obj["SerialNumber"].ToString();
                    string proccesorStatus = obj["Status"].ToString();
                    string proccesorSysName = obj["SystemName"].ToString();
                    string proccesorVirtualization = obj["VirtualizationFirmwareEnabled"].ToString();

                    lblCpu.Text = processorName;
                    lblCurrentClockS.Text = processorCurrentClockS + " Mhz";
                    lblBit.Text = processor64bit + " Bit";
                    lblVoltage.Text = processorVoltage + " V";
                    lblDesc.Text = processorDesc;
                    lblId.Text = processorID;
                    lblManufacturer.Text = processorManufacturer;
                    lblCores.Text = processorCores;
                    lblLogicalProcessors.Text = processorLogicalProcessors;
                    lblProcID.Text = proccesorID;
                    lblSerial.Text = proccesorSerialNO;
                    lblStatus.Text = proccesorStatus;
                    //lblSysName.Text = proccesorSysName;
                    lblVirtu.Text = proccesorVirtualization;
                    
                }
            }
            catch (Exception ex) {
            
                MessageBox.Show("Error Occured While Taking Info.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                
            }
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {  
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_hover(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            toolTip.SetToolTip(txtBox, txtBox.Text);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtGpuDDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGpuDVers_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
