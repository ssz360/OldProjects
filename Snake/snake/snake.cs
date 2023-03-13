using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace snake
{
    public delegate void gmaeOver();
    public enum pressClicked
    {
        up,
        right,
        bottom,
        left,
        none
        
    }
    class info
	{
        Point point;
        int ttl;
        public info(Point p,int t)
        {
            point=p;
            ttl=t;
        }
        public int TTL { get{return ttl;} set{ttl=value;} }
        public Point Point { get{return point;} set{point=value;} }
	}
    class snake
    {
        public event gmaeOver gameOverEvent;
        ArrayList collection;
        pressClicked lastPressed;
        int ttl;
        Point food;
        Size paperSize;
        public snake(int paperX,int paperY)
        {
            Point p1 = new Point(265, 265);
            Point p2 = new Point(255, 265);
            info in1 = new info(p1, 1);
            info in2 = new info(p2, 2);
            collection = new ArrayList();
            collection.Add(in1);
            collection.Add(in2);
            ttl = 2;
            lastPressed = pressClicked.left;
            paperSize=new Size(paperX-10,paperY-10);
            Random rnd = new Random();
            food=new Point(rnd.Next(paperSize.Width),rnd.Next(paperSize.Height));

            
        }
        public void addPoint(pressClicked key)
        {

            if ((key == pressClicked.bottom&&lastPressed== pressClicked.up)||(key == pressClicked.up&&lastPressed== pressClicked.bottom)||
                (key == pressClicked.left && lastPressed == pressClicked.right) || (key == pressClicked.right && lastPressed == pressClicked.left))
            {
                GameOver();
                return;
            }
            info head = findHead(ttl);
            foreach (info item in collection.ToArray())
            {

         /*       if (((info)item).TTL == ttl)
                {
                    head = item;
                }
                */
                ((info)item).TTL--;

                if (item.TTL == 0)
                {
                    collection.Remove(item);
                }


                //if the snake go out of the screen it show in the other side
                if (item.Point.X>paperSize.Width)
                {
                    Point newPosition = new Point(item.Point.X - paperSize.Width, item.Point.Y);
                    item.Point = newPosition;
                }
                else if (item.Point.X<0)
                {
                    Point newPosition = new Point(item.Point.X + paperSize.Width, item.Point.Y);
                    item.Point = newPosition;
                }
                if (item.Point.Y>paperSize.Height)
                {
                    Point newPosition = new Point(item.Point.X, item.Point.Y-paperSize.Height);
                    item.Point = newPosition;
                }
                else if (item.Point.Y<0)
                {
                    Point newPosition = new Point(item.Point.X, item.Point.Y+paperSize.Height);
                    item.Point = newPosition;
                }

                if (item.TTL != head.TTL)
                {


                    if (ColisionDetection(new Rectangle(head.Point.X, head.Point.Y, 10, 10), new Rectangle(item.Point.X, item.Point.Y, 10, 10)))
                    {
                        GameOver();
                    }
                }

            }
            Point newPoint = new Point(); ;
            switch (key)
            {
                    
                case pressClicked.up:
                    newPoint = new Point(head.Point.X, head.Point.Y - 10);
                    break;
                case pressClicked.right:
                    newPoint = new Point(head.Point.X+10, head.Point.Y );

                    break;
                case pressClicked.bottom:
                    newPoint = new Point(head.Point.X, head.Point.Y + 10);

                    break;
                case pressClicked.left:
                    newPoint = new Point(head.Point.X-10, head.Point.Y );

                    break;
                case pressClicked.none:
                    switch (lastPressed)
                    {
                        case pressClicked.up:
                            newPoint = new Point(head.Point.X, head.Point.Y - 10);

                            break;
                        case pressClicked.right:
                            newPoint = new Point(head.Point.X+10, head.Point.Y);

                            break;
                        case pressClicked.bottom:
                            newPoint = new Point(head.Point.X, head.Point.Y + 10);

                            break;
                        case pressClicked.left:
                            newPoint = new Point(head.Point.X-10, head.Point.Y);

                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }


            if (key != pressClicked.none)
            {
                lastPressed = key;
            }

            /*if (food.X + 10 >= head.Point.X && food.X <= head.Point.X && food.Y + 10 >= head.Point.Y && food.Y <= head.Point.Y)*/
            if(ColisionDetection(new Rectangle(food,new Size(10,10)),new Rectangle(head.Point,new Size(10,10))))
            {
                addBody(head, key);
                Random rnd = new Random();
                food = new Point(rnd.Next(paperSize.Width), rnd.Next(paperSize.Height));
            }

            info info = new global::snake.info(newPoint, ttl);
            collection.Add(info);
        }

        private void GameOver()
        {
            if (gameOverEvent!=null)
            {
                gameOverEvent();
            }
        }

        public void draw(Graphics g)
        {
            Graphics graph = g;
            foreach (info item in collection)
            {
                Point p = item.Point;
                graph.FillRectangle(Brushes.Green, p.X, p.Y, 10, 10);
            }
            graph.FillRectangle(Brushes.Red, food.X, food.Y, 10, 10);

        }
        public void addBody(info head,pressClicked key)
        {
            ttl++;

            Point newPoint = new Point();
            switch (key)
            {
                case pressClicked.up:
                    newPoint = new Point(head.Point.X, head.Point.Y - 10);

                    break;
                case pressClicked.right:
                    newPoint = new Point(head.Point.X + 10, head.Point.Y);

                    break;
                case pressClicked.bottom:
                    newPoint = new Point(head.Point.X, head.Point.Y + 10);

                    break;
                case pressClicked.left:
                    newPoint = new Point(head.Point.X - 10, head.Point.Y);

                    break;
                default:
                    break;
            }
            info info = new global::snake.info(newPoint, ttl);
            collection.Add(info);
        }
        private bool ColisionDetection(Rectangle first, Rectangle second)
        {
            //split the area between tow rectangle
            Rectangle scope = Rectangle.Intersect(first,second);
            if (scope.Width!=0&&scope.Height!=0)
            {               

                return true;
            }
            return false;
        }
        private info findHead(int ttl)
        {
            info head = new info(Point.Empty, 0);
            foreach (info item in collection)
            {
                if (item.TTL==ttl)
                {
                    head = item;
                }
            }
            return head;
        }
    }
}
