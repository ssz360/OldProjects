using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            textBox1.Text = @"

                   Name: sayyed Sajjad Zahedi
                   Student Number: 90403013



sample:
          
          5*6+2

          (5*6+2+5-8)

          5*(5*6+2+5-8) = 5(5*6+2+5-8)

          5*6+2+5-8*4/8/9*6+5(5+7/9+5+6)



Note:

        -2 = +(-2)

        program check paranteces should be open and           close.
     
        operators overwrite ( if after 5+ press * key +                overwrite by * and the result is 5*) .";
            textBox1.Select(textBox1.Text.Length, 0);
        }
    }
}
