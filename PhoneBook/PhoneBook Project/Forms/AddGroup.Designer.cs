namespace PhoneBook_Project.Forms
{
    partial class frmAddGroup
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbGroupName = new System.Windows.Forms.TextBox();
            this.lstbGroup = new System.Windows.Forms.ListBox();
            this.glsbExit = new Glass.GlassButton();
            this.glsbAbout = new Glass.GlassButton();
            this.glsbTooltip = new Glass.GlassButton();
            this.glassButton2 = new Glass.GlassButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbGroupName);
            this.groupBox1.Controls.Add(this.lstbGroup);
            this.groupBox1.Location = new System.Drawing.Point(217, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 319);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add group:";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(49, 238);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.toolTip.SetToolTip(this.btnEdit, "Edit selected group");
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(49, 190);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.toolTip.SetToolTip(this.btnRemove, "Remove selected group");
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.toolTip.SetToolTip(this.btnAdd, "Add group");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Group name:";
            // 
            // txtbGroupName
            // 
            this.txtbGroupName.Location = new System.Drawing.Point(25, 77);
            this.txtbGroupName.Name = "txtbGroupName";
            this.txtbGroupName.Size = new System.Drawing.Size(118, 20);
            this.txtbGroupName.TabIndex = 8;
            this.toolTip.SetToolTip(this.txtbGroupName, "Enter group name");
            // 
            // lstbGroup
            // 
            this.lstbGroup.FormattingEnabled = true;
            this.lstbGroup.Location = new System.Drawing.Point(190, 49);
            this.lstbGroup.Name = "lstbGroup";
            this.lstbGroup.Size = new System.Drawing.Size(306, 238);
            this.lstbGroup.TabIndex = 6;
            this.toolTip.SetToolTip(this.lstbGroup, "Group collection");
            this.lstbGroup.Click += new System.EventHandler(this.lstbGroup_Click);
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
            this.toolTip.SetToolTip(this.glsbExit, "Cancel");
            this.glsbExit.Click += new System.EventHandler(this.glsbExit_Click);
            // 
            // glsbAbout
            // 
            this.glsbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.glsbAbout.ForeColor = System.Drawing.Color.Transparent;
            this.glsbAbout.GlowColor = System.Drawing.Color.OliveDrab;
            this.glsbAbout.Location = new System.Drawing.Point(154, 359);
            this.glsbAbout.Name = "glsbAbout";
            this.glsbAbout.OuterBorderColor = System.Drawing.Color.Transparent;
            this.glsbAbout.ShineColor = System.Drawing.Color.DimGray;
            this.glsbAbout.Size = new System.Drawing.Size(38, 38);
            this.glsbAbout.TabIndex = 18;
            this.glsbAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.glsbAbout, "About");
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
            // frmAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.BackgroundImage = global::PhoneBook_Project.Properties.Resources.Style;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.glsbExit);
            this.Controls.Add(this.glsbAbout);
            this.Controls.Add(this.glsbTooltip);
            this.Controls.Add(this.glassButton2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Group";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstbGroup;
        private Glass.GlassButton glsbExit;
        private Glass.GlassButton glsbAbout;
        private Glass.GlassButton glsbTooltip;
        private Glass.GlassButton glassButton2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbGroupName;
    }
}