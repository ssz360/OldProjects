namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.btmStart = new System.Windows.Forms.Button();
            this.lblSorted = new System.Windows.Forms.Label();
            this.lblNotSorted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmStart
            // 
            this.btmStart.Location = new System.Drawing.Point(155, 32);
            this.btmStart.Name = "btmStart";
            this.btmStart.Size = new System.Drawing.Size(75, 23);
            this.btmStart.TabIndex = 0;
            this.btmStart.Text = "Start";
            this.btmStart.UseVisualStyleBackColor = true;
            this.btmStart.Click += new System.EventHandler(this.btmStart_Click);
            // 
            // lblSorted
            // 
            this.lblSorted.AutoSize = true;
            this.lblSorted.Location = new System.Drawing.Point(27, 82);
            this.lblSorted.Name = "lblSorted";
            this.lblSorted.Size = new System.Drawing.Size(41, 13);
            this.lblSorted.TabIndex = 1;
            this.lblSorted.Text = "Sorted:";
            // 
            // lblNotSorted
            // 
            this.lblNotSorted.AutoSize = true;
            this.lblNotSorted.Location = new System.Drawing.Point(289, 82);
            this.lblNotSorted.Name = "lblNotSorted";
            this.lblNotSorted.Size = new System.Drawing.Size(59, 13);
            this.lblNotSorted.TabIndex = 2;
            this.lblNotSorted.Text = "Not sorted:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 504);
            this.Controls.Add(this.lblNotSorted);
            this.Controls.Add(this.lblSorted);
            this.Controls.Add(this.btmStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmStart;
        private System.Windows.Forms.Label lblSorted;
        private System.Windows.Forms.Label lblNotSorted;
    }
}

