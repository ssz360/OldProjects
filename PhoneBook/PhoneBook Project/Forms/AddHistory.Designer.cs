namespace PhoneBook_Project.Forms
{
    partial class frmAddHistory
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
            this.glsbExit = new Glass.GlassButton();
            this.glsAbout = new Glass.GlassButton();
            this.glsbTooltip = new Glass.GlassButton();
            this.glassButton2 = new Glass.GlassButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.combDistination = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbCallTime = new System.Windows.Forms.MaskedTextBox();
            this.cmbSmsOrCall = new System.Windows.Forms.ComboBox();
            this.cmbResiveOrDialed = new System.Windows.Forms.ComboBox();
            this.lstvHistory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolTip.SetToolTip(this.glsbTooltip, "tooltip");
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
            // combDistination
            // 
            this.combDistination.FormattingEnabled = true;
            this.combDistination.Location = new System.Drawing.Point(89, 101);
            this.combDistination.Name = "combDistination";
            this.combDistination.Size = new System.Drawing.Size(140, 21);
            this.combDistination.TabIndex = 3;
            this.toolTip.SetToolTip(this.combDistination, "Choose contact");
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(89, 175);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(99, 20);
            this.dtp.TabIndex = 5;
            this.toolTip.SetToolTip(this.dtp, "Enter date");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(89, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.toolTip.SetToolTip(this.btnAdd, "Add history");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbCallTime
            // 
            this.txtbCallTime.Location = new System.Drawing.Point(89, 138);
            this.txtbCallTime.Mask = "00:00:00";
            this.txtbCallTime.Name = "txtbCallTime";
            this.txtbCallTime.Size = new System.Drawing.Size(48, 20);
            this.txtbCallTime.TabIndex = 8;
            this.txtbCallTime.Text = "000000";
            this.toolTip.SetToolTip(this.txtbCallTime, "Enter call time");
            // 
            // cmbSmsOrCall
            // 
            this.cmbSmsOrCall.FormattingEnabled = true;
            this.cmbSmsOrCall.Location = new System.Drawing.Point(27, 60);
            this.cmbSmsOrCall.Name = "cmbSmsOrCall";
            this.cmbSmsOrCall.Size = new System.Drawing.Size(69, 21);
            this.cmbSmsOrCall.TabIndex = 10;
            this.toolTip.SetToolTip(this.cmbSmsOrCall, "SMS or Call");
            // 
            // cmbResiveOrDialed
            // 
            this.cmbResiveOrDialed.FormattingEnabled = true;
            this.cmbResiveOrDialed.Location = new System.Drawing.Point(102, 60);
            this.cmbResiveOrDialed.Name = "cmbResiveOrDialed";
            this.cmbResiveOrDialed.Size = new System.Drawing.Size(128, 21);
            this.cmbResiveOrDialed.TabIndex = 9;
            this.toolTip.SetToolTip(this.cmbResiveOrDialed, "Resive or Dialed");
            // 
            // lstvHistory
            // 
            this.lstvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvHistory.Location = new System.Drawing.Point(257, 38);
            this.lstvHistory.Name = "lstvHistory";
            this.lstvHistory.Size = new System.Drawing.Size(262, 262);
            this.lstvHistory.TabIndex = 12;
            this.toolTip.SetToolTip(this.lstvHistory, "History collection");
            this.lstvHistory.UseCompatibleStateImageBehavior = false;
            this.lstvHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "First name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last name";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Call duration";
            this.columnHeader3.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lstvHistory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbResiveOrDialed);
            this.groupBox1.Controls.Add(this.cmbSmsOrCall);
            this.groupBox1.Controls.Add(this.txtbCallTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combDistination);
            this.groupBox1.Location = new System.Drawing.Point(215, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 320);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add History:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Please Choose:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dictination:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Call Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // frmAddHistory
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
            this.Name = "frmAddHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add History";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Glass.GlassButton glsbExit;
        private Glass.GlassButton glsAbout;
        private Glass.GlassButton glsbTooltip;
        private Glass.GlassButton glassButton2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstvHistory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbResiveOrDialed;
        private System.Windows.Forms.ComboBox cmbSmsOrCall;
        private System.Windows.Forms.MaskedTextBox txtbCallTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combDistination;
    }
}