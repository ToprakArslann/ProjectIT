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
using Microsoft.Win32;
using System.Reflection;
using System.Security.Policy;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.ServiceProcess;
using System.Management.Automation.Runspaces;
using Microsoft.PowerShell.Commands;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;




namespace projectit
{
    public partial class TweaksControl : UserControl
    {
        public TweaksControl()
        {
            InitializeComponent();
        }
        
        // Shortcut To Access TEMP Folder.
        public string tempPath = Path.GetTempPath();

        // Click Event For All Tweaks Buttons.
        private void tweaks_click(object sender, EventArgs e)
        {
            
            int counter;
            PowerShell ps = PowerShell.Create();
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                // O&O ShutUp 10
                case "shut10Btn":
                    if (File.Exists(tempPath + "OOSU10.exe"))
                    {
                        Process.Start(tempPath + "OOSU10.exe");
                    }
                    else
                    {
                        Download_OOSU10();
                    }
                    break;
                // Disable GameDVR Tweak.
                case "gamedvrBtn":
                    try
                    {
                        RegistryKey gameDVR_path = Registry.CurrentUser.OpenSubKey(@"System\\GameConfigStore", true);
                        RegistryKey AllowGameDVR = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR", true);
                        if (gameDVR_path != null && AllowGameDVR != null)
                        {
                            gameDVR_path.SetValue("GameDVR_FSEBehavior", 2);
                            gameDVR_path.SetValue("GameDVR_Enabled", 0);
                            gameDVR_path.SetValue("GameDVR_HonorUserFSEBehaviorMode", 1);
                            gameDVR_path.SetValue("GameDVR_EFSEFeatureFlags", 0);
                            AllowGameDVR.SetValue("AllowGameDVR", 0);
                            MessageBox.Show("GameDVR successfully disabled.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("GameDVR already disabled.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An Error Occurred While Disabling GameDVR.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    break;
                // Disable Hibernation Tweak.
                case "hibernationBtn":
                   
                    string hibernationScript = "powercfg.exe /hibernate off";
                    try
                    {
                        RegistryKey hibernation1 = Registry.LocalMachine.OpenSubKey(@"System\\CurrentControlSet\\Control\\Session Manager\\Power", true);
                        RegistryKey hibernation2 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FlyoutMenuSettings", true);
                        if (hibernation1 != null && hibernation2 != null)
                        {
                            hibernation1.SetValue("HibernateEnabled", 0);
                            hibernation2.SetValue("ShowHibernateOption", 0);

                            ps.AddScript(hibernationScript).Invoke();
                            MessageBox.Show("Successfully disabled hibernation.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Hibernation Already Disabled.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An Error Occurred While Disabling Hibernation.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                // Disable HomeGroup Tweak.
                case "homegroupBtn":
                    string Listener = $"Set-Service -Name HomeGroupListener -StartupType Manual"; 
                    string Provider = $"Set-Service -Name HomeGroupProvider -StartupType Manual";
                    ps.AddScript(Listener).Invoke();
                    ps.AddScript(Provider).Invoke();
                    MessageBox.Show("Successfully Disabled Home Group.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                // Disable Location Tracking Tweak.
                case "locationTrackingBtn":
                    counter = 0;
                    try
                    {
                        RegistryKey path1 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location", true);
                        RegistryKey path2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Sensor\\Overrides\\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}", true);
                        RegistryKey path3 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\lfsvc\\Service\\Configuration", true);
                        RegistryKey path4 = Registry.LocalMachine.OpenSubKey("SYSTEM\\Maps", true);
                        if (path1 != null)
                        {
                            path1.SetValue("Value", "Deny");
                            counter++;
                        }

                        if (path2 != null)
                        {
                            path2.SetValue("SensorPermissionState", 0);
                            counter++;
                        }

                        if (path3 != null)
                        {
                            path3.SetValue("Status", 0);
                            counter++;
                        }

                        if (path4 != null)
                        {
                            path4.SetValue("AutoUpdateEnabled", 0);
                            counter++;
                        }

                        if (counter == 0)
                        {
                            MessageBox.Show("Location Tracking already disabled.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Successfully Disabled " + counter + " of 4 process.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An Error Occured While Disabling Location Tracking", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                // Disable Wifi-Sense Tweak.
                case "wifisenseBtn":
                    counter = 0;
                    try
                    {
                        RegistryKey wifiPath1 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\PolicyManager\\default\\WiFi\\AllowWiFiHotSpotReporting", true);
                        RegistryKey wifiPath2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\PolicyManager\\default\\WiFi\\AllowAutoConnectToWiFiSenseHotspots", true);
                        if (wifiPath1 != null)
                        {
                            wifiPath1.SetValue("Value", 0);
                            counter++;
                        }
                        if (wifiPath2 != null)
                        {
                            wifiPath2.SetValue("Value", 0);
                            counter++;
                        }

                        if (counter == 0)
                        {
                            MessageBox.Show("Wifi-Sense already disabled.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Successfully Disabled " + counter + " of 2 process.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An Error Occured While Disabling wifi-sense.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                // Disk CleanUp Tweak.
                case "diskCleanupBtn":
                    string cleanUpScript =
                        @"
                            cleanmgr.exe /d C: /VERYLOWDISK
                            Dism.exe /online /Cleanup-Image /StartComponentCleanup /ResetBase
                         ";
                    ps.AddScript(cleanUpScript).Invoke();
                    break;
                // Debloat Edge Tweak.
                case "debloatEdgeBtn":
                    try
                    {
                        RegistryKey edgeUpdate = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Policies\\Microsoft\\EdgeUpdate", true);
                        RegistryKey edgePath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Policies\\Microsoft\\Edge", true);
                        if (edgeUpdate != null)
                        {
                            edgeUpdate.SetValue("CreateDesktopShortcutDefault", 0);
                        }

                        if (edgePath != null)
                        {
                            edgePath.SetValue("EdgeEnhanceImagesEnabled", 0);
                            edgePath.SetValue("PersonalizationReportingEnabled", 0);
                            edgePath.SetValue("ShowRecommendationsEnabled", 0);
                            edgePath.SetValue("HideFirstRunExperience", 1);
                            edgePath.SetValue("UserFeedbackAllowed", 0);
                            edgePath.SetValue("ConfigureDoNotTrack", 1);
                            edgePath.SetValue("AlternateErrorPagesEnabled", 0);
                            edgePath.SetValue("EdgeCollectionsEnabled", 0);
                            edgePath.SetValue("EdgeFollowEnabled", 0);
                            edgePath.SetValue("EdgeShoppingAssistantEnabled", 0);
                            edgePath.SetValue("MicrosoftEdgeInsiderPromotionEnabled", 0);
                            edgePath.SetValue("PersonalizationReportingEnabled", 0);
                            edgePath.SetValue("ShowMicrosoftRewards", 0);
                            edgePath.SetValue("WebWidgetAllowed", 0);
                            edgePath.SetValue("DiagnosticData", 0);
                            edgePath.SetValue("EdgeAssetDeliveryServiceEnabled", 0);
                            edgePath.SetValue("CryptoWalletEnabled", 0);
                            edgePath.SetValue("WalletDonationEnabled", 0);
                            MessageBox.Show("Successfully Debloated Edge.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Edge is missing.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("An Error Occured While Debloating Edge.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                // Disable Windows Copilot Tweak.
                case "copilotBtn":
                    try
                    {
                        string copilotScript = "dism /online /remove-package /package-name:Microsoft.Windows.Copilot";
                        RegistryKey copilotPath1 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsCopilot", true);
                        RegistryKey copilotPath2 = Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\WindowsCopilot", true);
                        RegistryKey copilotPath3 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);


                        ps.AddScript(copilotScript).Invoke();

                        if (copilotPath1 != null & copilotPath2 != null & copilotPath3 != null)
                        {
                            copilotPath1.SetValue("TurnOffWindowsCopilot", 1);
                            copilotPath2.SetValue("TurnOffWindowsCopilot", 1);
                            copilotPath3.SetValue("ShowCopilotButton", 0);
                            MessageBox.Show("Successfully Disabled Copilot.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Copilot already Disabled", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An Error Occured While Disabling Copilot", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                // Enable Hidden Files Tweak.
                case "hiddenfilesBtn":
                    try
                    {
                        RegistryKey folderPath = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);
                        folderPath.SetValue("Hidden", 0);
                    }
                    catch (System.Management.Automation.ItemNotFoundException)
                    {
                        MessageBox.Show("Cant find items to change.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch
                    {
                        MessageBox.Show("An Error Occured While Enabling Hidden Files", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                // Enable File Extensions Tweak.
                case "fileextensionsBtn":
                    try
                    {
                        RegistryKey folderPath = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);
                        folderPath.SetValue("HideFileExt", 0);
                    }
                    catch (System.Management.Automation.ItemNotFoundException)
                    {
                        MessageBox.Show("Cant find items to change.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch
                    {
                        MessageBox.Show("An Error Occured While Enabling File Extensions", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
        }

        // Process Void For AsyncCompletedEventHandler
        public void Process_OOSU10(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                var oosu10 = Process.Start(tempPath + "OOSU10.exe");
            }
            catch
            {
                MessageBox.Show("An Error Occurred While Running O&O SHUTUP 10.");
            }
        }
        
        // Boolean For Internet Connection.
        private bool CheckInternetConnection()
        {
            try
            {
                using (Ping p = new Ping())
                {
                    PingReply ping = p.Send("8.8.8.8");
                    return ping.Status == IPStatus.Success;
                }
            }
            catch (PingException)
            {
                return false;
            }
        }

        // Void For Download O&O ShutUp 10.
        private void Download_OOSU10()
        {
            if (CheckInternetConnection())
            {
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadFileAsync(
                            new System.Uri("https://dl5.oo-software.com/files/ooshutup10/OOSU10.exe"),
                            tempPath + "OOSU10.exe"
                            );

                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Process_OOSU10);
                    }
                }
                catch
                {
                    MessageBox.Show("Error Occurred While Downloading O&O ShutUp 10.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Check Your Internet Connection.", "ProjectIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TweaksControl_Load(object sender, EventArgs e)
        {
            
        }
    }










}
