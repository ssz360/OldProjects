namespace PhoneBook_Project.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.btnExtract = new Glass.GlassButton();
            this.btnAddHistory = new Glass.GlassButton();
            this.btnDeleteContact = new Glass.GlassButton();
            this.btnAddGorup = new Glass.GlassButton();
            this.btnAddcontact = new Glass.GlassButton();
            this.lstvContactsView = new System.Windows.Forms.ListView();
            this.clmFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.glassButton2 = new Glass.GlassButton();
            this.glsbTooltip = new Glass.GlassButton();
            this.glsAbout = new Glass.GlassButton();
            this.glsbExit = new Glass.GlassButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnImport = new Glass.GlassButton();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtract.BackgroundImage = global::PhoneBook_Project.Properties.Resources.black;
            this.btnExtract.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.ForeColor = System.Drawing.Color.DarkGray;
            this.btnExtract.GlowColor = System.Drawing.Color.OrangeRed;
            this.btnExtract.Location = new System.Drawing.Point(20, 210);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnExtract.ShineColor = System.Drawing.Color.DimGray;
            this.btnExtract.Size = new System.Drawing.Size(58, 27);
            this.btnExtract.TabIndex = 23;
            this.btnExtract.Text = "Extract";
            this.btnExtract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.btnExtract, "Extract contacts");
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnAddHistory
            // 
            this.btnAddHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHistory.BackgroundImage = global::PhoneBook_Project.Properties.Resources.black;
            this.btnAddHistory.Enabled = false;
            this.btnAddHistory.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHistory.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAddHistory.GlowColor = System.Drawing.Color.OrangeRed;
            this.btnAddHistory.Location = new System.Drawing.Point(18, 164);
            this.btnAddHistory.Name = "btnAddHistory";
            this.btnAddHistory.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnAddHistory.ShineColor = System.Drawing.Color.DimGray;
            this.btnAddHistory.Size = new System.Drawing.Size(66, 27);
            this.btnAddHistory.TabIndex = 21;
            this.btnAddHistory.Text = "Add history";
            this.btnAddHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.btnAddHistory, "Add new history");
            this.btnAddHistory.Click += new System.EventHandler(this.btnAddHistory_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteContact.BackgroundImage = global::PhoneBook_Project.Properties.Resources.black;
            this.btnDeleteContact.Enabled = false;
            this.btnDeleteContact.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContact.ForeColor = System.Drawing.Color.DarkGray;
            this.btnDeleteContact.GlowColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteContact.Location = new System.Drawing.Point(17, 76);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteContact.ShineColor = System.Drawing.Color.DimGray;
            this.btnDeleteContact.Size = new System.Drawing.Size(74, 27);
            this.btnDeleteContact.TabIndex = 22;
            this.btnDeleteContact.Text = "Delete contact";
            this.btnDeleteContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.btnDeleteContact, "Delete selected contact");
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddGorup
            // 
            this.btnAddGorup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGorup.BackgroundImage = global::PhoneBook_Project.Properties.Resources.black;
            this.btnAddGorup.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGorup.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAddGorup.GlowColor = System.Drawing.Color.OrangeRed;
            this.btnAddGorup.Location = new System.Drawing.Point(19, 118);
            this.btnAddGorup.Name = "btnAddGorup";
            this.btnAddGorup.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnAddGorup.ShineColor = System.Drawing.Color.DimGray;
            this.btnAddGorup.Size = new System.Drawing.Size(58, 27);
            this.btnAddGorup.TabIndex = 20;
            this.btnAddGorup.Text = "Add group";
            this.btnAddGorup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.btnAddGorup, "Add new group");
            this.btnAddGorup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnAddcontact
            // 
            this.btnAddcontact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddcontact.BackgroundImage = global::PhoneBook_Project.Properties.Resources.black;
            this.btnAddcontact.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddcontact.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAddcontact.GlowColor = System.Drawing.Color.OrangeRed;
            this.btnAddcontact.Location = new System.Drawing.Point(19, 27);
            this.btnAddcontact.Name = "btnAddcontact";
            this.btnAddcontact.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnAddcontact.ShineColor = System.Drawing.Color.DimGray;
            this.btnAddcontact.Size = new System.Drawing.Size(66, 27);
            this.btnAddcontact.TabIndex = 19;
            this.btnAddcontact.Text = "Add contact";
            this.btnAddcontact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.btnAddcontact, "Add new contact");
            this.btnAddcontact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // lstvContactsView
            // 
            this.lstvContactsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFirstName,
            this.clmLastName,
            this.clmPhoneNumber,
            this.clmEmail,
            this.clmBirthDate,
            this.clmComment});
            this.lstvContactsView.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvContactsView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstvContactsView.Location = new System.Drawing.Point(219, 103);
            this.lstvContactsView.Name = "lstvContactsView";
            this.lstvContactsView.Size = new System.Drawing.Size(533, 321);
            this.lstvContactsView.TabIndex = 8;
            this.toolTip.SetToolTip(this.lstvContactsView, "Contacts viewer");
            this.lstvContactsView.UseCompatibleStateImageBehavior = false;
            this.lstvContactsView.View = System.Windows.Forms.View.Details;
            this.lstvContactsView.SelectedIndexChanged += new System.EventHandler(this.lstvContactsView_SelectedIndexChanged);
            this.lstvContactsView.DoubleClick += new System.EventHandler(this.lstvContactsView_DoubleClick);
            // 
            // clmFirstName
            // 
            this.clmFirstName.Text = "First Name";
            this.clmFirstName.Width = 65;
            // 
            // clmLastName
            // 
            this.clmLastName.Text = "Last Name";
            this.clmLastName.Width = 80;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.Text = "Phone Number";
            this.clmPhoneNumber.Width = 105;
            // 
            // clmEmail
            // 
            this.clmEmail.Text = "Email";
            this.clmEmail.Width = 100;
            // 
            // clmBirthDate
            // 
            this.clmBirthDate.Text = "Birth date";
            // 
            // clmComment
            // 
            this.clmComment.Text = "Comment";
            this.clmComment.Width = 117;
            // 
            // glassButton2
            // 
            this.glassButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glassButton2.BackgroundImage = global::PhoneBook_Project.Properties.Resources.proj22;
            this.glassButton2.ForeColor = System.Drawing.Color.Transparent;
            this.glassButton2.GlowColor = System.Drawing.Color.OliveDrab;
            this.glassButton2.Location = new System.Drawing.Point(154, 210);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.OuterBorderColor = System.Drawing.Color.Transparent;
            this.glassButton2.ShineColor = System.Drawing.Color.DimGray;
            this.glassButton2.Size = new System.Drawing.Size(38, 38);
            this.glassButton2.TabIndex = 12;
            this.glassButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.glassButton2, "Setting");
            this.glassButton2.Click += new System.EventHandler(this.glassButton2_Click);
            // 
            // glsbTooltip
            // 
            this.glsbTooltip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glsbTooltip.BackgroundImage = global::PhoneBook_Project.Properties.Resources.proj33;
            this.glsbTooltip.ForeColor = System.Drawing.Color.Transparent;
            this.glsbTooltip.GlowColor = System.Drawing.Color.LightSeaGreen;
            this.glsbTooltip.Location = new System.Drawing.Point(154, 285);
            this.glsbTooltip.Name = "glsbTooltip";
            this.glsbTooltip.OuterBorderColor = System.Drawing.Color.Transparent;
            this.glsbTooltip.ShineColor = System.Drawing.Color.DimGray;
            this.glsbTooltip.Size = new System.Drawing.Size(38, 38);
            this.glsbTooltip.TabIndex = 13;
            this.glsbTooltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.glsbTooltip, "Tooltip");
            this.glsbTooltip.Click += new System.EventHandler(this.glsbTooltip_Click);
            // 
            // glsAbout
            // 
            this.glsAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glsAbout.ForeColor = System.Drawing.Color.Transparent;
            this.glsAbout.GlowColor = System.Drawing.Color.Gold;
            this.glsAbout.Location = new System.Drawing.Point(154, 359);
            this.glsAbout.Name = "glsAbout";
            this.glsAbout.OuterBorderColor = System.Drawing.Color.Transparent;
            this.glsAbout.ShineColor = System.Drawing.Color.DimGray;
            this.glsAbout.Size = new System.Drawing.Size(38, 38);
            this.glsAbout.TabIndex = 14;
            this.glsAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.glsAbout, "About");
            // 
            // glsbExit
            // 
            this.glsbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glsbExit.BackgroundImage = global::PhoneBook_Project.Properties.Resources.proj11;
            this.glsbExit.ForeColor = System.Drawing.Color.Black;
            this.glsbExit.GlowColor = System.Drawing.Color.OrangeRed;
            this.glsbExit.Location = new System.Drawing.Point(154, 130);
            this.glsbExit.Name = "glsbExit";
            this.glsbExit.OuterBorderColor = System.Drawing.Color.Transparent;
            this.glsbExit.ShineColor = System.Drawing.Color.DimGray;
            this.glsbExit.Size = new System.Drawing.Size(38, 38);
            this.glsbExit.TabIndex = 15;
            this.glsbExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.glsbExit, "Exit");
            this.glsbExit.Click += new System.EventHandler(this.glassButton4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhoneBook_Project.Properties.Resources.LeftSide;
            this.pictureBox1.Location = new System.Drawing.Point(103, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 388);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackgroundImage = global::PhoneBook_Project.Properties.Resources.black;
            this.btnImport.Enabled = false;
            this.btnImport.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.DarkGray;
            this.btnImport.GlowColor = System.Drawing.Color.OrangeRed;
            this.btnImport.Location = new System.Drawing.Point(19, 256);
            this.btnImport.Name = "btnImport";
            this.btnImport.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnImport.ShineColor = System.Drawing.Color.DimGray;
            this.btnImport.Size = new System.Drawing.Size(58, 27);
            this.btnImport.TabIndex = 24;
            this.btnImport.Text = "Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.btnImport, "Import contact");
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.Controls.Add(this.btnImport);
            this.panel.Controls.Add(this.btnExtract);
            this.panel.Controls.Add(this.btnAddcontact);
            this.panel.Controls.Add(this.btnAddHistory);
            this.panel.Controls.Add(this.btnDeleteContact);
            this.panel.Controls.Add(this.btnAddGorup);
            this.panel.Location = new System.Drawing.Point(118, 103);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(100, 321);
            this.panel.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.BackgroundImage = global::PhoneBook_Project.Properties.Resources.Style;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.glsbExit);
            this.Controls.Add(this.glsAbout);
            this.Controls.Add(this.glsbTooltip);
            this.Controls.Add(this.glassButton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lstvContactsView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvContactsView;
        private System.Windows.Forms.ColumnHeader clmFirstName;
        private System.Windows.Forms.ColumnHeader clmLastName;
        private System.Windows.Forms.ColumnHeader clmPhoneNumber;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.ColumnHeader clmBirthDate;
        private System.Windows.Forms.ColumnHeader clmComment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Glass.GlassButton glassButton2;
        private Glass.GlassButton glsbTooltip;
        private Glass.GlassButton glsAbout;
        private Glass.GlassButton glsbExit;
        private System.Windows.Forms.ToolTip toolTip;
        private Glass.GlassButton btnAddHistory;
        private Glass.GlassButton btnDeleteContact;
        private Glass.GlassButton btnAddGorup;
        private Glass.GlassButton btnAddcontact;
        private Glass.GlassButton btnExtract;
        private System.Windows.Forms.Panel panel;
        private Glass.GlassButton btnImport;
    }
}