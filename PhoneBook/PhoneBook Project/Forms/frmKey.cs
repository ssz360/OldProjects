using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using PhoneBook_Project.Classes;
using System.IO;

namespace PhoneBook_Project.Forms
{
    public partial class frmKey : Form
    {
        public frmKey()
        {
            InitializeComponent();
        }

        private void btnAddKey_Click(object sender, EventArgs e)
        {
            string importEncryptKey = string.Empty ;
            string textToEnCrypt;
            string importedKey;
            OpenFileDialog openD = new OpenFileDialog();
            openD.Filter = "KEY files (*.key)|*.key";
            DialogResult result = openD.ShowDialog();
            if (result==DialogResult.OK)
            {
                importEncryptKey = File.ReadAllText(openD.FileName);
            }
            else
            {
                return;
            }
            NetworkInterface[] a = NetworkInterface.GetAllNetworkInterfaces();
            textToEnCrypt = a[0].GetPhysicalAddress().ToString();
            textToEnCrypt += txtbName.Text + txtbEmail.Text;

            importedKey = EncryptDecrypt.DecryptString(importEncryptKey);

            if (string.Compare(importedKey,textToEnCrypt)==0)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("phonebook",true);

                key.SetValue("key", "Hi " + txtbName.Text + " :)");

                MessageBox.Show("Thank you "+txtbName.Text+" ! The Application will be restart...");
                Application.Restart();


            }
            else
            {
                MessageBox.Show("The informations are wrong!");
            }


        }

        private void glsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void glsbTooltip_Click(object sender, EventArgs e)
        {
            toolTip.Active = !toolTip.Active;
        }
    }
}
