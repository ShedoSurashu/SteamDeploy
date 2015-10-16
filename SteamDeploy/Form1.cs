using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SteamDeploy
{
    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();

            string steamPath = Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Steam", "UninstallString", "none") as string;
            if (steamPath != "none")
            {
                steamPath = Path.GetDirectoryName(steamPath) + Path.DirectorySeparatorChar + "steam.exe";
                steamInstallGame(steamPath);
            }
        }
        
        private void downloadSteam_Click(object sender, EventArgs e)
        {
            Process.Start("http://store.steampowered.com/about/");
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void browseSteam_Click(object sender, EventArgs e)
        {
            DialogResult result = findSteam.ShowDialog();
            if (result == DialogResult.OK)
            {
                steamInstallGame(findSteam.FileName);
            }
        }

        private void steamInstallGame(string steamPath)
        {
            if (File.Exists(steamPath))
            {
                string rootDrive = Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location);
                rootDrive = rootDrive.Remove(rootDrive.Length - 1, 1);

                Process.Start(steamPath, "-install \"" + rootDrive + "\"");
                // For debugging only:
                // MessageBox.Show(steamPath + " -install \"" + rootDrive + "\"");
                Application.ExitThread();
                Environment.Exit(0);
            }
        }
    }
}
