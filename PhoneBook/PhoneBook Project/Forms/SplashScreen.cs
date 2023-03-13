using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PhoneBook_Project.Forms
{
    public partial class frmSplashScreen : Form
    {

        // The splashscreen animation idea was adopt from :
        //http://codepen.io/MyXoToD/full/zbgAm


        Point[] points = new[] { new Point(-60, -60), new Point(60, -60), new Point(60, 60), new Point(-60, 60) };
        Point[] pointsMode = new[] { new Point(-10, -10), new Point(10, -10), new Point(10, 10), new Point(-10, 10) };
        Point[] pointsMode2 = new[] { new Point(-60, -60), new Point(60, -60), new Point(60, 60), new Point(-60, 60) };
        Point[] pointsMode1 = new[] { new Point(-20, -20), new Point(20, -20), new Point(20, 20), new Point(-20, 20) };

        bool expand = true;
        float i = 0.0f;

        bool shouldStop = false;

        System.Threading.Thread thread;

        public frmSplashScreen()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer|ControlStyles.UserPaint|ControlStyles.AllPaintingInWmPaint, true);

        }



        public void drawing(Graphics G)
        {
            Bitmap paper=new Bitmap(400,400);
            Graphics Graphic = Graphics.FromImage(paper); ;
            int pnlw = 200;
            int pnlh = 200;
            int trans1 = 65;
            Point[] modefyPoints;

            Graphic.TranslateTransform(pnlw, pnlh);


            float Rotate = 0;
            int p = 1;
            while (!shouldStop)
            {
                Rotate++;

                Graphic.Clear(Color.DarkGray);


                if (expand)
                {
                    pointsMode = pointsMode1;
                    i += 0.017f;
                }
                else
                {
                    pointsMode = pointsMode2;
                    i -= 0.017f;

                }

                if (points[0].X!=pointsMode[0].X)
                {
                    if (points[0].X>pointsMode[0].X)
                    {
                        p = -1;
                    }
                    else
                    {
                        p = 1;
                    }
                    points[0].X += p ;
                }
                if (points[1].X != pointsMode[1].X)
                {
                    if (points[1].X > pointsMode[1].X)
                    {
                        p = -1;
                    }
                    else
                    {
                        p = 1;
                    }
                    points[1].X += p;
                }
                if (points[2].X != pointsMode[2].X)
                {
                    if (points[2].X > pointsMode[2].X)
                    {
                        p = -1;
                    }
                    else
                    {
                        p = 1;
                    }
                    points[2].X += p;
                }
                if (points[3].X != pointsMode[3].X)
                {
                    if (points[3].X > pointsMode[3].X)
                    {
                        p = -1;
                    }
                    else
                    {
                        p = 1;
                    }
                    points[3].X += p;
                }


                if (points[0].Y != pointsMode[0].Y)
                {
                    if (points[0].Y > pointsMode[0].Y)
                    {
                        p = -1;
                    }
                    else
                    {
                        p = 1;
                    }
                    points[0].Y += p;
                }
                if (points[1].Y != pointsMode[1].Y)
                {
                    if (points[1].Y > pointsMode[1].Y)
                    {
                        p = -1;
                    }
                    else
                    {
                        p = 1;
                    }
                    points[1].Y += p;
                }
                if (points[2].Y != pointsMode[2].Y)
                {
                    if (points[2].Y > pointsMode[2].Y)
                    {
                        p = -1;
                    }
                    else
                    {
                        p = 1;
                    }
                    points[2].Y += p;
                }
                if (points[3].Y != pointsMode[3].Y)
                {
                    if (points[3].Y > pointsMode[3].Y)
                    {
                        p = -1;
                    }
                    else
                    {
                        p = 1;
                    }
                    points[3].Y+=p;
                }

                if (points[0].X==pointsMode1[0].X)
                {
                    expand = false;
                }
                else if (points[0].X==pointsMode2[0].X)
                {
                    expand = true;
                }

                SolidBrush brush1 = new SolidBrush(Color.FromArgb(200, 170, 230, 115));
                SolidBrush brush2 = new SolidBrush(Color.FromArgb(255, 210, 100, 135));


                Graphic.RotateTransform(1f);

                Graphic.RotateTransform(-Rotate);
                Graphic.TranslateTransform(-50, -8);
                Graphic.DrawString("LOADING...",new System.Drawing.Font("Arial",15), new SolidBrush(Color.LawnGreen), PointF.Empty);
                Graphic.TranslateTransform(+50, +8);
                Graphic.RotateTransform(+Rotate);

                modefyPoints = maniplutePoints(points, -trans1, -trans1);
                Graphic.FillClosedCurve(brush2, modefyPoints,System.Drawing.Drawing2D.FillMode.Alternate,i);
                Graphic.DrawClosedCurve(new Pen(Color.Gray), modefyPoints, i, System.Drawing.Drawing2D.FillMode.Alternate);


                modefyPoints = maniplutePoints(points, -trans1, trans1);
                Graphic.FillClosedCurve(brush2, modefyPoints, System.Drawing.Drawing2D.FillMode.Alternate, i);
                Graphic.DrawClosedCurve(new Pen(Color.Gray), modefyPoints, i, System.Drawing.Drawing2D.FillMode.Alternate);



                modefyPoints = maniplutePoints(points, trans1, -trans1);
                Graphic.FillClosedCurve(brush2, modefyPoints, System.Drawing.Drawing2D.FillMode.Alternate, i);
                Graphic.DrawClosedCurve(new Pen(Color.Gray), modefyPoints, i, System.Drawing.Drawing2D.FillMode.Alternate);




                modefyPoints = maniplutePoints(points, trans1, trans1);
                Graphic.FillClosedCurve(brush2, modefyPoints, System.Drawing.Drawing2D.FillMode.Alternate, i);
                Graphic.DrawClosedCurve(new Pen(Color.Gray), modefyPoints, i, System.Drawing.Drawing2D.FillMode.Alternate);




                Graphic.RotateTransform(+45);
  
                modefyPoints = maniplutePoints(points, -trans1, -trans1);
                Graphic.FillClosedCurve(brush1, modefyPoints, System.Drawing.Drawing2D.FillMode.Alternate, i);
                Graphic.DrawClosedCurve(new Pen(Color.Gray), modefyPoints, i, System.Drawing.Drawing2D.FillMode.Alternate);



                modefyPoints = maniplutePoints(points, -trans1, trans1);
                Graphic.FillClosedCurve(brush1, modefyPoints, System.Drawing.Drawing2D.FillMode.Alternate, i);
                Graphic.DrawClosedCurve(new Pen(Color.Gray), modefyPoints, i, System.Drawing.Drawing2D.FillMode.Alternate);



                modefyPoints = maniplutePoints(points, trans1, -trans1);
                Graphic.FillClosedCurve(brush1, modefyPoints, System.Drawing.Drawing2D.FillMode.Alternate, i);
                Graphic.DrawClosedCurve(new Pen(Color.Gray), modefyPoints, i, System.Drawing.Drawing2D.FillMode.Alternate);


                modefyPoints = maniplutePoints(points, trans1, trans1);
                Graphic.FillClosedCurve(brush1, modefyPoints, System.Drawing.Drawing2D.FillMode.Alternate, i);
                Graphic.DrawClosedCurve(new Pen(Color.Gray), modefyPoints, i, System.Drawing.Drawing2D.FillMode.Alternate);



                Graphic.RotateTransform(-45);

                G.DrawImage(paper,new Rectangle((this.Width/2)-200,(this.Height/2)-200,400,400));

                System.Threading.Thread.Sleep(50);
                if (Rotate==130)
                {
                    shouldStop = true;                  
                }
            }
            Invoke(new Action(() => this.Close()));

        }

        public Point[] maniplutePoints(Point[] input,int Xchange,int Ychange)
        {
            Point[] changePoints = new Point[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                changePoints[i].X = points[i].X + Xchange;
                changePoints[i].Y = points[i].Y + Ychange;
            }
            return changePoints;
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            thread = new System.Threading.Thread(() => drawing(this.CreateGraphics()));
            thread.Start();

        }


    }
}
