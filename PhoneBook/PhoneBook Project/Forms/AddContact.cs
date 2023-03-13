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
using PhoneBook_Project.Enums;
using System.Collections;

namespace PhoneBook_Project.Forms
{
    public partial class frmAddContact : Form
    {
        public linked_list.linked_list<Contact> contactCollection = new linked_list.linked_list<Contact>();
        public ArrayList groupCollection;



        public frmAddContact(linked_list.linked_list<Contact> inputCollection,Contact input)
        {
            InitializeComponent();


            contactCollection = inputCollection;
            groupCollection = frmMain.groupCollection;


            //add to comboBox
            for (int i = 0; i < groupCollection.Count; i++)
            {
                combGroup.Items.Add(groupCollection[i]);
            }

            //see http://stackoverflow.com/questions/906899/binding-an-enum-to-a-winforms-combo-box-and-then-setting-it

            cmbPhoneNumberGroup.DataSource = Enum.GetValues(typeof(ContactGroup));

            //if form should edit contact
            if (input!=null)
            {
                
                txtBbComment.Text = input.Comment;
                txtbEmail.Text = input.Email;
                txtbFirstName.Text = input.FirstName;
                txtbLastName.Text = input.LastName;
                txtbPhoneNumber.Text = input.PhoneNumber.ToString();
                dateTimePicker.Value = input.BirthDate;
                cmbPhoneNumberGroup.SelectedIndex = (int)input.ContactGroup;
                picbAvatar.Image = input.ContactPicture;
                glsbExit.Enabled = false;

                for (int i = 0; i < combGroup.Items.Count; i++)
                {
                    if ((string)combGroup.Items[i]==input.PersonGroup)
                    {
                        combGroup.SelectedIndex = i;
                    }
                }

                btnAdd.Text = "Ok";
            }
        }



        #region Methods
        private void btnAddNewGroup_Click(object sender, EventArgs e)
        {
            frmAddGroup addGroup = new frmAddGroup();
            addGroup.ShowDialog();

            combGroup.Items.Clear();
            for (int i = 0; i < groupCollection.Count; i++)
            {
                combGroup.Items.Add(groupCollection[i]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contact newContact;

            string fn = txtbFirstName.Text;
            string ln = txtbLastName.Text;
            string email = txtbEmail.Text;
            long number;

            //for checking input character is number
            try
            {
                number = long.Parse(txtbPhoneNumber.Text);
            }
            catch (Exception)
            {
                txtbPhoneNumber.BackColor = Color.LightSalmon;
                return;
            }


            string comment = txtBbComment.Text;
            DateTime bdate = dateTimePicker.Value;
            Image img = picbAvatar.Image;
            string groupname = (string)combGroup.SelectedItem;

            //see http://stackoverflow.com/questions/906899/binding-an-enum-to-a-winforms-combo-box-and-then-setting-it
            ContactGroup contactGroup = new ContactGroup();
            Enum.TryParse<ContactGroup>(cmbPhoneNumberGroup.SelectedValue.ToString(), out contactGroup);

            //checking right email format 
            if (!(string.IsNullOrWhiteSpace(txtbEmail.Text)) && (!txtbEmail.Text.Contains('@') || !txtbEmail.Text.Contains('.')))
            {
                txtbEmail.BackColor = Color.LightSalmon;
                MessageBox.Show("Please Enter Correct Email");
                return;

            }
            else
            {
                txtbEmail.BackColor = Color.White;
            }

            newContact = new Contact(fn, ln, bdate, groupname, number, contactGroup, email, comment, img);


            contactCollection.AddLast(newContact);



            this.Close();
        }





        private void txtbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check input should be number
            char inp =e.KeyChar;
            if (!(char.IsNumber(inp)||char.IsControl(inp)))
            {
                e.Handled=true;
                txtbPhoneNumber.BackColor = Color.LightSalmon;
            }
            else
            {
                txtbPhoneNumber.BackColor = Color.White;
            }
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opend = new OpenFileDialog();
            opend.Filter = "JPEG files (*.jpg)|*.jpg";
            DialogResult result = opend.ShowDialog();
            if (result==DialogResult.OK)
            {
                picbAvatar.Image = Image.FromFile(opend.FileName);
            }
        }
        #endregion

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
