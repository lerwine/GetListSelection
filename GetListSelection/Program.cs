using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GetListSelection
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
            object r = MainForm.GetSelectionFromList(new string[] { "One", "Two", "Three", "" },
                "My Caption", "My Message", true, "My Other Value", "My Empty Value");
            if (r == null)
            {
                MessageBox.Show("Returned null");
            }
            else
            {
                MessageBox.Show(String.Format("Returned '{0}'", r));
            }
        }
    }
}
