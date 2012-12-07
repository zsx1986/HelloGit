using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HelloWorld
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

            bool IsCreateNew = true;
            //System.Threading.Mutex mutex = new System.Threading.Mutex(true, "HelloWorld", out IsRunning);
            //System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out IsCreateNew);
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName, out IsCreateNew);

            if (!IsCreateNew)
                MessageBox.Show("Application is running!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Application.Run(new Form1());
        }
    }
}
