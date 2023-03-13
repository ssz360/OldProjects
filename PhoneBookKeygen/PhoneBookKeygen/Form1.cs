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

namespace PhoneBookKeygen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string txtToEncrypt;
            string encrypted;

            NetworkInterface[] a = NetworkInterface.GetAllNetworkInterfaces();
            txtToEncrypt = a[0].GetPhysicalAddress().ToString();
            txtToEncrypt += txtbName.Text + txtbEmail.Text;

            encrypted = EncryptDecrypt.EncryptString(txtToEncrypt);

            SaveFileDialog saveD = new SaveFileDialog();
            saveD.Filter = "KEY files (*.key)|*.key";
            DialogResult result = saveD.ShowDialog();
            if (result==DialogResult.OK)
            {
                File.WriteAllText(saveD.FileName, encrypted);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
