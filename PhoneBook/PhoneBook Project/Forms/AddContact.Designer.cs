namespace PhoneBook_Project.Forms
{
    partial class frmAddContact
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPhoneNumberGroup = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.picbAvatar = new System.Windows.Forms.PictureBox();
            this.combGroup = new System.Windows.Forms.ComboBox();
            this.btnAddNewGroup = new System.Windows.Forms.Button();
            this.txtBbComment = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.glsbExit = new Glass.GlassButton();
            this.glsAbout = new Glass.GlassButton();
            this.glsbTooltip = new Glass.GlassButton();
            this.glassButton2 = new Glass.GlassButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cmbPhoneNumberGroup);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.txtbPhoneNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.combGroup);
            this.groupBox1.Controls.Add(this.btnAddNewGroup);
            this.groupBox1.Controls.Add(this.txtBbComment);
            this.groupBox1.Controls.Add(this.txtbEmail);
            this.groupBox1.Controls.Add(this.txtbLastName);
            this.groupBox1.Controls.Add(this.txtbFirstName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(217, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Contact";
            // 
            // cmbPhoneNumberGroup
            // 
            this.cmbPhoneNumberGroup.FormattingEnabled = true;
            this.cmbPhoneNumberGroup.Location = new System.Drawing.Point(206, 177);
            this.cmbPhoneNumberGroup.Name = "cmbPhoneNumberGroup";
            this.cmbPhoneNumberGroup.Size = new System.Drawing.Size(67, 21);
            this.cmbPhoneNumberGroup.TabIndex = 24;
            this.toolTip.SetToolTip(this.cmbPhoneNumberGroup, "Choose type");
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(103, 204);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker.TabIndex = 22;
            this.toolTip.SetToolTip(this.dateTimePicker, "Choose birthday");
            // 
            // txtbPhoneNumber
            // 
            this.txtbPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtbPhoneNumber.Location = new System.Drawing.Point(103, 177);
            this.txtbPhoneNumber.Name = "txtbPhoneNumber";
            this.txtbPhoneNumber.Size = new System.Drawing.Size(95, 20);
            this.txtbPhoneNumber.TabIndex = 21;
            this.toolTip.SetToolTip(this.txtbPhoneNumber, "Enter number");
            this.txtbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPhoneNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Birth date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddPicture);
            this.groupBox2.Controls.Add(this.picbAvatar);
            this.groupBox2.Location = new System.Drawing.Point(300, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 254);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture:";
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(71, 223);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(75, 23);
            this.btnAddPicture.TabIndex = 17;
            this.btnAddPicture.Text = "Add";
            this.toolTip.SetToolTip(this.btnAddPicture, "Add picture");
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // picbAvatar
            // 
            this.picbAvatar.Location = new System.Drawing.Point(6, 17);
            this.picbAvatar.Name = "picbAvatar";
            this.picbAvatar.Size = new System.Drawing.Size(200, 200);
            this.picbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbAvatar.TabIndex = 16;
            this.picbAvatar.TabStop = false;
            this.toolTip.SetToolTip(this.picbAvatar, "Picture");
            // 
            // combGroup
            // 
            this.combGroup.FormattingEnabled = true;
            this.combGroup.Location = new System.Drawing.Point(103, 40);
            this.combGroup.Name = "combGroup";
            this.combGroup.Size = new System.Drawing.Size(141, 21);
            this.combGroup.TabIndex = 15;
            this.toolTip.SetToolTip(this.combGroup, "Choose group");
            // 
            // btnAddNewGroup
            // 
            this.btnAddNewGroup.Location = new System.Drawing.Point(250, 40);
            this.btnAddNewGroup.Name = "btnAddNewGroup";
            this.btnAddNewGroup.Size = new System.Drawing.Size(23, 21);
            this.btnAddNewGroup.TabIndex = 14;
            this.btnAddNewGroup.Text = "+";
            this.toolTip.SetToolTip(this.btnAddNewGroup, "Add group");
            this.btnAddNewGroup.UseVisualStyleBackColor = true;
            this.btnAddNewGroup.Click += new System.EventHandler(this.btnAddNewGroup_Click);
            // 
            // txtBbComment
            // 
            this.txtBbComment.Location = new System.Drawing.Point(103, 144);
            this.txtBbComment.Name = "txtBbComment";
            this.txtBbComment.Size = new System.Drawing.Size(170, 20);
            this.txtBbComment.TabIndex = 12;
            this.toolTip.SetToolTip(this.txtBbComment, "Write comment");
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(103, 118);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(170, 20);
            this.txtbEmail.TabIndex = 11;
            this.toolTip.SetToolTip(this.txtbEmail, "Enter email");
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(103, 92);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(170, 20);
            this.txtbLastName.TabIndex = 10;
            this.toolTip.SetToolTip(this.txtbLastName, "Enter last name");
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.Location = new System.Drawing.Point(103, 66);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(170, 20);
            this.txtbFirstName.TabIndex = 9;
            this.toolTip.SetToolTip(this.txtbFirstName, "Enter first name");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comment:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(146, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.toolTip.SetToolTip(this.btnAdd, "Add contact");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.glsbExit.TabIndex = 19;
            this.glsbExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.glsbExit, "Cancle");
            this.glsbExit.Click += new System.EventHandler(this.glsbExit_Click);
            // 
            // glsAbout
            // 
            this.glsAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glsAbout.ForeColor = System.Drawing.Color.Transparent;
            this.glsAbout.GlowColor = System.Drawing.Color.OliveDrab;
            this.glsAbout.Location = new System.Drawing.Point(154, 359);
            this.glsAbout.Name = "glsAbout";
            this.glsAbout.OuterBorderColor = System.Drawing.Color.Transparent;
            this.glsAbout.ShineColor = System.Drawing.Color.DimGray;
            this.glsAbout.Size = new System.Drawing.Size(38, 38);
            this.glsAbout.TabIndex = 18;
            this.glsAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.glsAbout, "About");
            // 
            // glsbTooltip
            // 
            this.glsbTooltip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glsbTooltip.BackgroundImage = global::PhoneBook_Project.Properties.Resources.proj33;
            this.glsbTooltip.ForeColor = System.Drawing.Color.Transparent;
            this.glsbTooltip.GlowColor = System.Drawing.Color.OliveDrab;
            this.glsbTooltip.Location = new System.Drawing.Point(154, 285);
            this.glsbTooltip.Name = "glsbTooltip";
            this.glsbTooltip.OuterBorderColor = System.Drawing.Color.Transparent;
            this.glsbTooltip.ShineColor = System.Drawing.Color.DimGray;
            this.glsbTooltip.Size = new System.Drawing.Size(38, 38);
            this.glsbTooltip.TabIndex = 17;
            this.glsbTooltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.glsbTooltip, "Tooltip");
            this.glsbTooltip.Click += new System.EventHandler(this.glsbTooltip_Click);
            // 
            // glassButton2
            // 
            this.glassButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glassButton2.BackgroundImage = global::PhoneBook_Project.Properties.Resources.proj22;
            this.glassButton2.Enabled = false;
            this.glassButton2.ForeColor = System.Drawing.Color.Transparent;
            this.glassButton2.GlowColor = System.Drawing.Color.OliveDrab;
            this.glassButton2.Location = new System.Drawing.Point(154, 210);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.OuterBorderColor = System.Drawing.Color.Transparent;
            this.glassButton2.ShineColor = System.Drawing.Color.DimGray;
            this.glassButton2.Size = new System.Drawing.Size(38, 38);
            this.glassButton2.TabIndex = 16;
            this.glassButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.glassButton2, "Setting");
            // 
            // toolTip
            // 
            this.toolTip.Active = false;
            // 
            // frmAddContact
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
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Contact";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combGroup;
        private System.Windows.Forms.Button btnAddNewGroup;
        private System.Windows.Forms.TextBox txtBbComment;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.PictureBox picbAvatar;
        private System.Windows.Forms.MaskedTextBox txtbPhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cmbPhoneNumberGroup;
        private Glass.GlassButton glsbExit;
        private Glass.GlassButton glsAbout;
        private Glass.GlassButton glsbTooltip;
        private Glass.GlassButton glassButton2;
        private System.Windows.Forms.ToolTip toolTip;
    }
}