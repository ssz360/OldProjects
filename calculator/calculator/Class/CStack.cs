using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Class
{
    //generic stack
    public class cstack<t>
    {
        t[] data;
        int face;
        public cstack(int lenght)
        {
            data = new t[lenght];
            face = 0;
        }
        public void push(t input)
        {
            if (IsFull)
            {
                throw new Exception();
            }
            data[face] = input;
            face++;
        }
        public t pop()
        {
            if (IsEmpty)
            {
                throw new Exception();
            }
            face--;
            return data[face];
        }
        public bool IsFull { get { return face == data.Length; } }
        public bool IsEmpty { get { return face == 0; } }
        public int count { get { return face; } }


    }
}
