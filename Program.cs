using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace SICAT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool exclusive;
            Mutex m = new Mutex(true, "SICAT", out exclusive);

            if (exclusive)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                formConfiguration mainForm = new formConfiguration();
                
                Application.Run();
            }
            else
            {
                MessageBox.Show("Šù‚É‹N“®‚µ‚Ä‚¢‚Ü‚·");
            }
        }
    }
}