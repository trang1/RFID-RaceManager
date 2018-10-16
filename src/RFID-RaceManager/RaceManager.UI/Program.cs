﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RaceManager.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point of application program.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


        //Extension methods
        public static double? TryToDoubleNull(this object o)
        {
            try
            {
                if (o == null) return null;
                return Convert.ToDouble(o);
            }
            catch
            {
                return null;
            }
        }
    }
}
