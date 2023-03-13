using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        snake s;
        public Form1()
        {
            InitializeComponent();
            restart();
        }

        private void restart()
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            s = new snake(panel.Width, panel.Height);
            timer.Start();
            s.gameOverEvent += s_gameOverEvent;
        }

        void s_gameOverEvent()
        {
            timer.Stop();
            Graphics g = panel.CreateGraphics();
            g.DrawString("GAME OVER", new Font(FontFamily.GenericSerif, 50), Brushes.DarkRed, new PointF(panel.Height / 2 - 200, panel.Width / 2 - 80));
            this.Text += "-Press F2 to reset";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            panel.Refresh();
            s.addPoint(pressClicked.none);
            s.draw(panel.CreateGraphics());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    s.addPoint(pressClicked.bottom);
                    break;
                case Keys.Left:
                    s.addPoint(pressClicked.left);
                    break;
                case Keys.Right:
                    s.addPoint(pressClicked.right);
                    break;
                case Keys.Up:
                    s.addPoint(pressClicked.up);
                    break;
                case Keys.F2:
                    restart();
                    break;

                default:
                    break;
            }
        }

    }
}
