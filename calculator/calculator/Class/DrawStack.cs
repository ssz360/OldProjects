using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace calculator.Class
{
    // create a sambolic stack for tracing main stack graphically
    public class drawStack
    {
        ArrayList elements = new ArrayList();

        public void push(string element)
        {
            elements.Add(element);
        }
        public void pop()
        {
            elements.RemoveAt(elements.Count - 1);
        }
        //drowing method
        public void drew(Graphics gr, Point position, Brush color)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                Rectangle recrec = new Rectangle(new Point(position.X, (position.Y + (i * 15))), new Size(50, 15));
                Rectangle recstring = new Rectangle(new Point(position.X, (position.Y + (i * 15) + 1)), new Size(50, 15));
                gr.FillRectangle(color, recrec);
                gr.DrawRectangle(new Pen(Brushes.Black), recrec);
                gr.DrawString((string)elements[i], new Font("Arial", 8), Brushes.DarkBlue, recstring);

            }
        }
        public void clear()
        {
            elements.Clear();
        }
        public int count()
        {
            return elements.Count;
        }
    }
}
