namespace Circle_Chart
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
            this.btmDraw = new System.Windows.Forms.Button();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.txtbInput = new System.Windows.Forms.TextBox();
            this.lblPleaseInterData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmDraw
            // 
            this.btmDraw.Location = new System.Drawing.Point(185, 15);
            this.btmDraw.Name = "btmDraw";
            this.btmDraw.Size = new System.Drawing.Size(75, 23);
            this.btmDraw.TabIndex = 0;
            this.btmDraw.Text = "DrawChart";
            this.btmDraw.UseVisualStyleBackColor = true;
            this.btmDraw.Click += new System.EventHandler(this.btmDraw_Click);
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDraw.Location = new System.Drawing.Point(120, 70);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(201, 201);
            this.pnlDraw.TabIndex = 1;
            // 
            // txtbInput
            // 
            this.txtbInput.Location = new System.Drawing.Point(12, 36);
            this.txtbInput.Multiline = true;
            this.txtbInput.Name = "txtbInput";
            this.txtbInput.Size = new System.Drawing.Size(100, 235);
            this.txtbInput.TabIndex = 0;
            // 
            // lblPleaseInterData
            // 
            this.lblPleaseInterData.AutoSize = true;
            this.lblPleaseInterData.Location = new System.Drawing.Point(12, 15);
            this.lblPleaseInterData.Name = "lblPleaseInterData";
            this.lblPleaseInterData.Size = new System.Drawing.Size(89, 13);
            this.lblPleaseInterData.TabIndex = 2;
            this.lblPleaseInterData.Text = "Please inter data:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 283);
            this.Controls.Add(this.lblPleaseInterData);
            this.Controls.Add(this.txtbInput);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.btmDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmDraw;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.TextBox txtbInput;
        private System.Windows.Forms.Label lblPleaseInterData;
    }
}

