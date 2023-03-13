namespace PhoneBook_Project.Forms
{
    partial class frmKey
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
            this.glsbAbout = new Glass.GlassButton();
            this.glsbTooltip = new Glass.GlassButton();
            this.glassButton2 = new Glass.GlassButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.btnAddKey = new System.Windows.Forms.Button();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.toolTip.SetToolTip(this.glsbExit, "Exit");
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
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(394, 246);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(184, 20);
            this.txtbEmail.TabIndex = 21;
            this.toolTip.SetToolTip(this.txtbEmail, "Enter your email");
            // 
            // btnAddKey
            // 
            this.btnAddKey.Location = new System.Drawing.Point(451, 299);
            this.btnAddKey.Name = "btnAddKey";
            this.btnAddKey.Size = new System.Drawing.Size(75, 23);
            this.btnAddKey.TabIndex = 20;
            this.btnAddKey.Text = "Add key";
            this.toolTip.SetToolTip(this.btnAddKey, "Add key binary file");
            this.btnAddKey.UseVisualStyleBackColor = true;
            this.btnAddKey.Click += new System.EventHandler(this.btnAddKey_Click);
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(394, 208);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(184, 20);
            this.txtbName.TabIndex = 22;
            this.toolTip.SetToolTip(this.txtbName, "Enter your name");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(325, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(325, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name:";
            // 
            // frmKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.BackgroundImage = global::PhoneBook_Project.Properties.Resources.Style;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.glsbExit);
            this.Controls.Add(this.glsbAbout);
            this.Controls.Add(this.glsbTooltip);
            this.Controls.Add(this.glassButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKey";
            this.Text = "frmKey";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Glass.GlassButton glsbExit;
        private Glass.GlassButton glsbAbout;
        private Glass.GlassButton glsbTooltip;
        private Glass.GlassButton glassButton2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbName;
    }
}