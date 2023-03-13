using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook_Project.Classes;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PhoneBook_Project.Enums;

namespace PhoneBook_Project.Forms
{
    public partial class frmMain : Form
    {

        #region Initializing
      //  public static LinkedList<Contact> contactCollection;
        public static linked_list.linked_list<Contact> contactCollection;
        public static ArrayList groupCollection;
        #endregion

        public frmMain()
        {
            InitializeComponent();


  //          contactCollection = new System.Collections.Generic.LinkedList<Contact>();
            contactCollection = new linked_list.linked_list<Contact>();
            groupCollection = new ArrayList();
            splashScreen();

        }
       


        #region Methods

        private void refreshLiestView()
        {
            //clear listView
            lstvContactsView.Items.Clear();
            //add new items to list
            foreach (var item in contactCollection)
            {
                //see http://stackoverflow.com/questions/473148/c-sharp-listview-how-do-i-add-items-to-columns-2-3-and-4-etc

                lstvContactsView.Items.Add(new ListViewItem(new[] { item.FirstName, item.LastName, item.PhoneNumber.ToString(), item.Email, item.BirthDate.ToShortDateString(), item.Comment }));
            }
        }

        #region Buttons
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            frmAddGroup groupWindow = new frmAddGroup();
            panel.Location = new Point(118, 103);
            groupWindow.ShowDialog();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            frmAddContact addContactWindow = new frmAddContact(contactCollection, null);
            panel.Location = new Point(118, 103);
            addContactWindow.ShowDialog();

            //refresh listview
            refreshLiestView();
        }

        private void btnAddHistory_Click(object sender, EventArgs e)
        {
            if (lstvContactsView.SelectedIndices.Count > 0)
            {
                btnAddHistory.Enabled = true;
            }
            else
            {
                btnAddHistory.Enabled = false;
                return;
            }
            Contact tempContact = new Contact();
            //fetch data
            string fn = lstvContactsView.SelectedItems[0].SubItems[0].Text;
            string ln = lstvContactsView.SelectedItems[0].SubItems[1].Text;
            long phnumber = long.Parse(lstvContactsView.SelectedItems[0].SubItems[2].Text);

            //find cintact in linkedList
            foreach (var item in contactCollection)
            {
                if (item.FirstName == fn && item.LastName == ln && item.PhoneNumber == phnumber)
                {
                    tempContact = item;
                }
            }
            frmAddHistory addHistoryWindow = new frmAddHistory(contactCollection, tempContact);
            panel.Location = new Point(118, 103);
            addHistoryWindow.ShowDialog();
        }
        #endregion



        private void lstvContactsView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvContactsView.SelectedIndices.Count > 0)
            {
                btnAddHistory.Enabled = true;
                btnDeleteContact.Enabled = true;
            }
            else
            {
                btnAddHistory.Enabled = false;
                btnDeleteContact.Enabled = true;
            }
        }

        private void lstvContactsView_DoubleClick(object sender, EventArgs e)
        {
            //fetch data
            string fn = lstvContactsView.SelectedItems[0].SubItems[0].Text;
            string ln = lstvContactsView.SelectedItems[0].SubItems[1].Text;
            long phnumber = long.Parse(lstvContactsView.SelectedItems[0].SubItems[2].Text);

            //find cintact in linkedList
            foreach (var item in contactCollection)
            {
                if (item.FirstName == fn && item.LastName == ln && item.PhoneNumber == phnumber)
                {
                    frmAddContact editc = new frmAddContact(contactCollection, item);
                    editc.ShowDialog();
                    contactCollection.Remove(item);

                    refreshLiestView();

                    return;
                }
            }
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstvContactsView.SelectedIndices.Count > 0)
            {
                btnDeleteContact.Enabled = true;
            }
            else
            {
                btnDeleteContact.Enabled = false;
                return;
            }
            //fetch data
            string fn = lstvContactsView.SelectedItems[0].SubItems[0].Text;
            string ln = lstvContactsView.SelectedItems[0].SubItems[1].Text;
            long phnumber = long.Parse(lstvContactsView.SelectedItems[0].SubItems[2].Text);

            //find cintact in linkedList
            foreach (var item in contactCollection)
            {
                if (item.FirstName == fn && item.LastName == ln && item.PhoneNumber == phnumber)
                {
                    contactCollection.Remove(item);

                    refreshLiestView();

                    return;
                }
            }
            panel.Location = new Point(118, 103);

        }

        private void splashScreen() 
        {
            for (int i = 75; i <= 80; i++)
            {
                this.Opacity = i;
               // System.Threading.Thread.Sleep(50);
            }
        }


        private void glassButton2_Click(object sender, EventArgs e)
        {
            if (panel.Location.X < 217)
            {
                while (panel.Location.X < 217)
                {
                    panel.Location = new Point(panel.Location.X + 2, panel.Location.Y);
                    System.Threading.Thread.Sleep(1);
                    panel.Refresh();
                }
            }
            else if (panel.Location.X > 118)
            {
                while (panel.Location.X > 118)
                {
                    panel.Location = new Point(panel.Location.X - 1, panel.Location.Y);
                    System.Threading.Thread.Sleep(1);
                    lstvContactsView.Refresh();
                }

            }
            
        }

        private void glassButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void glsbTooltip_Click(object sender, EventArgs e)
        {
            toolTip.Active = !toolTip.Active;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path += "data.db";
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream st=File.OpenWrite(path);
            formatter.Serialize(st,contactCollection);
            st.Dispose();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path += "data.db";
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream st = File.OpenRead(path);
            st.Position = 0;
            contactCollection=(linked_list.linked_list<Contact>) formatter.Deserialize(st);
            st.Dispose();
            refreshLiestView();
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdialog = new SaveFileDialog();
            sdialog.Filter = "Phonebook files (*.VCF)|*.VCF|All files (*.*)|*.*";
            DialogResult result = sdialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string str = "";
                foreach (var item in contactCollection)
                {
                    str += "BEGIN:VCARD\nVERSION:3.0\nN:"
                        + item.LastName
                        + item.FirstName + ";"
                        + ";;;\nFN:"
                        + item.FirstName + " " + item.LastName;
                    switch (item.ContactGroup)
                    {
                        case ContactGroup.Home:
                            {
                                str += "TEL;TYPE=HOME:" + item.PhoneNumber.ToString();
                                break;
                            }
                        case ContactGroup.Work:
                            {
                                str += "TEL;TYPE=WORK:" + item.PhoneNumber.ToString();
                                break;
                            }
                        case ContactGroup.Mobile:
                            {
                                str += "TEL;TYPE=CELL:" + item.PhoneNumber.ToString();
                                break;
                            }
                        case ContactGroup.WorkFax:
                            {
                                str += "TEL;TYPE=WORK;TYPE=FAX:" + item.PhoneNumber.ToString();
                                break;
                            }
                        case ContactGroup.HomeFax:
                            {
                                str += "TEL;TYPE=HOME;TYPE=FAX:" + item.PhoneNumber.ToString();
                                break;
                            }
                        case ContactGroup.Pager:
                            {
                                str += "TEL;TYPE=PAGER:" + item.PhoneNumber.ToString();
                                break;
                            }
                        case ContactGroup.Other:
                            {
                                str += "TEL;TYPE=VOICE:" + item.PhoneNumber.ToString();
                                break;
                            }

                        default:
                            break;
                    }

                    str += "EMAIL;TYPE=WORK:" + item.Email
                        + "NOTE:" + item.Comment
                        + "BDAY:" + item.BirthDate.ToShortDateString()
                        + "END:VCARD";

                }

                System.IO.File.WriteAllText(sdialog.FileName, str);
                panel.Location = new Point(118, 103);

            }
        }

      




       


    }
}
