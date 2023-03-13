using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskbar_information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        System.Diagnostics.PerformanceCounter cpu = new System.Diagnostics.PerformanceCounter("Processor", "% Processor Time", "_Total");

        Microsoft.VisualBasic.Devices.ComputerInfo ci = new Microsoft.VisualBasic.Devices.ComputerInfo();
        private void uodateTimer_Tick(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);
            float c = cpu.NextValue();
            float m = (100 - ((float)(ci.AvailablePhysicalMemory) / (float)(ci.TotalPhysicalMemory) * 100));
            string cpuUseage = c.ToString("#0.0");
            string memroryUseage = m.ToString("#0.0");


            Graphics g = Graphics.FromHwnd(IntPtr.Zero);

            int x = 0;
            int y = Screen.PrimaryScreen.Bounds.Height-40;
            int width = 8;
            int height = 40;

       
            g.FillRectangle(new SolidBrush(Color.FromArgb(100,127,158)), x+0,y+ 0, width*2, height);



            Rectangle[] rec1 = new Rectangle[2];
            rec1[0] = new Rectangle(x+0, y+40 - (int)(m * height / 100), width, (int)(m * height / 100));
            rec1[1] = new Rectangle(x+width, y+40 - (int)(c * height / 100) , width, (int)(c * height / 100));
            g.FillRectangles(Brushes.Red, rec1);


            Rectangle[] rec = new Rectangle[2];
            rec[0] = new Rectangle(x+0, y+0, width, height);
            rec[1] = new Rectangle(x+width, y+0, width, height);
            g.DrawRectangles(new Pen(Color.Black), rec);


            g.RotateTransform(90);


            Font font = new System.Drawing.Font(new FontFamily("Arial"), 5, FontStyle.Bold);
            g.DrawString(memroryUseage, font, Brushes.White, new RectangleF(y + (int)(height / 4), -8, height, width));
            g.DrawString(cpuUseage, font, Brushes.White, new RectangleF(y + (int)(height / 4), -16, height, width));



            g.Flush();
            g.Dispose();


        }

        bool start = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (start)
            {
                uodateTimer.Stop();
                button1.Text = "Start";
                start=false;
            }
            else
            {
                uodateTimer.Start();
                button1.Text = "Stop";
                start=true;
            }
        }
    }
}
