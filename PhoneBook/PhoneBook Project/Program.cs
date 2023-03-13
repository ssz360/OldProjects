using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook_Project.Forms;

namespace PhoneBook_Project
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

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("phonebook");

            frmSplashScreen loading = new frmSplashScreen();
            loading.ShowDialog();
            loading.Dispose();


            if (key==null)
            {
                Microsoft.Win32.Registry.CurrentUser.CreateSubKey("phonebook");
                Application.Run(new frmKey());  


            }
            else if (string.IsNullOrWhiteSpace(Convert.ToString(key.GetValue("key"))))
            {
                Application.Run(new frmKey());
            }
            else
            {
                Application.Run(new frmMain());

            }

        }
    }
}
