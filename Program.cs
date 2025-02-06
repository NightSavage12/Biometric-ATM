using Fingerprint_Authentication.Windows_Forms;
using System;
using System.Windows.Forms;

namespace Fingerprint_Authentication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ATM_Machine());
        }
    }
}
