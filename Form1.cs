using Microsoft.Win32;
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

namespace SleepMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> openApps = GetAllOpenApps();
            List<string> installedApps = GetInstalledApps();
            lstBoxOpenApps.DataSource = openApps;
            lstBoxInstalledApps.DataSource = installedApps;
        }

        private List<string> GetAllOpenApps()
        {
            List<string> apps = new List<string>();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (!string.IsNullOrEmpty(process.MainWindowTitle))
                {
                    apps.Add(process.MainWindowTitle + " <" + process.ProcessName + ">");
                }
            }
            return apps;
        }

        private List<string> GetInstalledApps()
        {
            List<string> installedApps = new List<string>();
            string registryPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath))
            {
                foreach (string name in key.GetSubKeyNames())
                {
                    using (RegistryKey app = key.OpenSubKey(name))
                    {
                        try
                        {
                            var displayName = app.GetValue("DisplayName");
                            if (displayName != null)
                            {
                                installedApps.Add(displayName.ToString() + " <" + app.GetValue("InstallLocation") + ">");
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
            return installedApps;
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            AboutForm aboutFrm = new AboutForm();
            aboutFrm.ShowDialog();
        }
    }
}
