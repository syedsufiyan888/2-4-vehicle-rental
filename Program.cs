// File: Program.cs
using System;
using System.Windows.Forms;

namespace VehicleRentalApp
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

            // Start the application with Form1 (Vehicle Selection)
            Application.Run(new Form1());
        }
    }
}
