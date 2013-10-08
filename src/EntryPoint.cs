using System;
using System.Windows.Forms;
using Rampage.Forms;

namespace Rampage
{
    /// <summary>
    /// EntryPoint
    /// </summary>
    static class EntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
