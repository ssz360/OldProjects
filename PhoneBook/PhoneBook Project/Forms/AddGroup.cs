using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook_Project.Forms;
using System.Collections;

namespace PhoneBook_Project.Forms
{
    
    public partial class frmAddGroup : Form
    {
        ArrayList groupCollection;
        public frmAddGroup()
        {
            groupCollection = frmMain.groupCollection ;
            InitializeComponent();
            for (int i = 0; i < groupCollection.Count; i++)
            {
                lstbGroup.Items.Add(groupCollection[i]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbGroupName.Text))
            {
                groupCollection.Add(txtbGroupName.Text);
                lstbGroup.Items.Add(txtbGroupName.Text);
                
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            groupCollection.Remove(lstbGroup.SelectedItem);
            lstbGroup.Items.Remove(lstbGroup.SelectedItem);

            btnEdit.Enabled = false;
            btnRemove.Enabled = false   ;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnRemove_Click(this, e);
            btnAdd_Click(this, e);

            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
        }



        private void lstbGroup_Click(object sender, EventArgs e)
        {
            txtbGroupName.Text = (string)lstbGroup.SelectedItem;

            btnEdit.Enabled = true;
            btnRemove.Enabled = true;
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
