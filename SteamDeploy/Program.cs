using System;
using System.Threading;
using System.Windows.Forms;

namespace SteamDeploy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool mutexCreated = false;
            Mutex mutex = new System.Threading.Mutex(true, @"Local\Surashu.SteamDeploy.exe", out mutexCreated);

            if (!mutexCreated)
            {
                mutex.Close();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

            mutex.Close();
        }
    }
}
