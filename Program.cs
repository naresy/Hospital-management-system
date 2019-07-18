using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pharmacy_Management_System
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
           //string s = "MPusparaaj i";
            Application.Run(new  Login());
        }

       
        }
    }

