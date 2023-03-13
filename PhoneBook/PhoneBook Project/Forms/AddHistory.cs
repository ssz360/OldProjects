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
using PhoneBook_Project.Enums;

namespace PhoneBook_Project.Forms
{
    public partial class frmAddHistory : Form
    {
        Contact dialedContact;
        Contact contact;
        linked_list.linked_list<Contact> conCollection;


        public frmAddHistory(linked_list.linked_list<Contact> ContactCollection,Contact inputData)
        {
            InitializeComponent();
            contact = inputData;
            conCollection = ContactCollection;

            //add data from enums to comboBox
            cmbResiveOrDialed.DataSource = Enum.GetValues(typeof(HistoryResiveOrDialed));
            cmbSmsOrCall.DataSource=Enum.GetValues(typeof(HistoryCallOrSms));

            //add from linklist to comboBox
            foreach (var item in ContactCollection)
            {
                combDistination.Items.Add(item.FirstName + " " + item.LastName);
                dialedContact = item;
            }
            combDistination.SelectedIndex = 0;

            RefreshListViewer(inputData);

        }


        #region Methods


        private void RefreshListViewer(Contact inputData)
        {
            lstvHistory.Items.Clear();
            if (inputData.History != null)
            {
                ArrayList historyList = inputData.History;

                foreach (var item in historyList)
                {
                    History newHistory = (History)item;
                    ListViewItem listItem = new ListViewItem(new[] { newHistory.DialedContact.FirstName, newHistory.DialedContact.LastName, newHistory.CallDuration.ToString() });

                    if (newHistory.ResiveOrDialed == HistoryResiveOrDialed.Dialed)
                    {
                        listItem.BackColor = Color.LightSalmon ;
                    }
                    else
                    {
                        listItem.BackColor = Color.Chartreuse;
                    }

                    lstvHistory.Items.Add(listItem);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            History newHistory;
            HistoryCallOrSms callOrSms;
            Enum.TryParse<HistoryCallOrSms>(cmbSmsOrCall.SelectedItem.ToString(),out callOrSms);
            HistoryResiveOrDialed dialedOrResive;
            Enum.TryParse<HistoryResiveOrDialed>(cmbResiveOrDialed.SelectedItem.ToString(),out dialedOrResive);
            TimeSpan time;
            try
            {
                time = TimeSpan.Parse(txtbCallTime.Text);
            }
            catch (Exception)
            {

                txtbCallTime.BackColor=Color.Red;
                return;
            }
            DateTime date = dtp.Value;
            newHistory=new History(callOrSms,dialedOrResive,time,date,dialedContact);
            contact.AddHistory(newHistory);
            RefreshListViewer(contact);
            this.Close();
        }

        private void glsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void glsbTooltip_Click(object sender, EventArgs e)
        {
            toolTip.Active = !toolTip.Active;
        }


    }
}
