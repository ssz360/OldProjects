namespace calculator
{
    partial class pnlCalculator
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
            this.txtbInput = new System.Windows.Forms.TextBox();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblTrace = new System.Windows.Forms.Label();
            this.pnlPaper = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDvide = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btncp = new System.Windows.Forms.Button();
            this.btnop = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Calculator = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.Calculator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbInput
            // 
            this.txtbInput.Location = new System.Drawing.Point(6, 32);
            this.txtbInput.Name = "txtbInput";
            this.txtbInput.Size = new System.Drawing.Size(294, 20);
            this.txtbInput.TabIndex = 0;
            this.txtbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbInput_KeyPress);
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(3, 16);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(0, 13);
            this.lblStore.TabIndex = 2;
            // 
            // lblTrace
            // 
            this.lblTrace.AutoSize = true;
            this.lblTrace.Location = new System.Drawing.Point(-2, 2);
            this.lblTrace.Name = "lblTrace";
            this.lblTrace.Size = new System.Drawing.Size(0, 13);
            this.lblTrace.TabIndex = 3;
            // 
            // pnlPaper
            // 
            this.pnlPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlPaper.Location = new System.Drawing.Point(2, 1);
            this.pnlPaper.Name = "pnlPaper";
            this.pnlPaper.Size = new System.Drawing.Size(579, 280);
            this.pnlPaper.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pnlPaper);
            this.panel1.Location = new System.Drawing.Point(6, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 281);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.lblTrace);
            this.panel2.Location = new System.Drawing.Point(3, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 153);
            this.panel2.TabIndex = 5;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 116);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(44, 23);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(106, 87);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(44, 23);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(106, 116);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(44, 23);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(56, 87);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(44, 23);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(106, 58);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(44, 23);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 87);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(44, 23);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn0
            // 
            this.btn0.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn0.Location = new System.Drawing.Point(6, 145);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(94, 23);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn2.Location = new System.Drawing.Point(56, 58);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(44, 23);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(56, 116);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(44, 23);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn1
            // 
            this.btn1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn1.Location = new System.Drawing.Point(6, 58);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(44, 23);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(156, 87);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(44, 23);
            this.btnMul.TabIndex = 15;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDvide
            // 
            this.btnDvide.Location = new System.Drawing.Point(156, 58);
            this.btnDvide.Name = "btnDvide";
            this.btnDvide.Size = new System.Drawing.Size(44, 23);
            this.btnDvide.TabIndex = 16;
            this.btnDvide.Text = "/";
            this.btnDvide.UseVisualStyleBackColor = true;
            this.btnDvide.Click += new System.EventHandler(this.btnDvide_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(156, 145);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(44, 23);
            this.btnPlus.TabIndex = 17;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(106, 145);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(44, 23);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(156, 116);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(44, 23);
            this.btnNegative.TabIndex = 19;
            this.btnNegative.Text = "-";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(206, 87);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(44, 81);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(206, 58);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(44, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "clr";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btncp
            // 
            this.btncp.Location = new System.Drawing.Point(256, 87);
            this.btncp.Name = "btncp";
            this.btncp.Size = new System.Drawing.Size(44, 23);
            this.btncp.TabIndex = 22;
            this.btncp.Text = ")";
            this.btncp.UseVisualStyleBackColor = true;
            this.btncp.Click += new System.EventHandler(this.btncp_Click);
            // 
            // btnop
            // 
            this.btnop.Location = new System.Drawing.Point(256, 58);
            this.btnop.Name = "btnop";
            this.btnop.Size = new System.Drawing.Size(44, 23);
            this.btnop.TabIndex = 23;
            this.btnop.Text = "(";
            this.btnop.UseVisualStyleBackColor = true;
            this.btnop.Click += new System.EventHandler(this.btnop_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Calculator
            // 
            this.Calculator.Controls.Add(this.button1);
            this.Calculator.Controls.Add(this.btnMul);
            this.Calculator.Controls.Add(this.btnop);
            this.Calculator.Controls.Add(this.lblStore);
            this.Calculator.Controls.Add(this.txtbInput);
            this.Calculator.Controls.Add(this.btncp);
            this.Calculator.Controls.Add(this.btn1);
            this.Calculator.Controls.Add(this.btnClear);
            this.Calculator.Controls.Add(this.btn8);
            this.Calculator.Controls.Add(this.btnEqual);
            this.Calculator.Controls.Add(this.btn2);
            this.Calculator.Controls.Add(this.btnNegative);
            this.Calculator.Controls.Add(this.btn0);
            this.Calculator.Controls.Add(this.btnDot);
            this.Calculator.Controls.Add(this.btn4);
            this.Calculator.Controls.Add(this.btnPlus);
            this.Calculator.Controls.Add(this.btn3);
            this.Calculator.Controls.Add(this.btnDvide);
            this.Calculator.Controls.Add(this.btn5);
            this.Calculator.Controls.Add(this.btn9);
            this.Calculator.Controls.Add(this.btn7);
            this.Calculator.Controls.Add(this.btn6);
            this.Calculator.Location = new System.Drawing.Point(12, 12);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(316, 178);
            this.Calculator.TabIndex = 24;
            this.Calculator.TabStop = false;
            this.Calculator.Text = "Calculator";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 52);
            this.button1.TabIndex = 24;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(334, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 168);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trace Stack:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 296);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trace Stack Graphically:";
            // 
            // pnlCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Calculator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pnlCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.Calculator.ResumeLayout(false);
            this.Calculator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbInput;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblTrace;
        private System.Windows.Forms.Panel pnlPaper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDvide;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btncp;
        private System.Windows.Forms.Button btnop;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox Calculator;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}

