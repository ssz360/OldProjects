using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmStart_Click(object sender, EventArgs e)
        {
            //random array
            int[] NotSortArray = new int[30];
            LinkedList<int> sort =new LinkedList<int>();
            //mid array
            int[] temp = new int[100];
            Random rnd = new Random();
            lblSorted.Text = "Sorted:";
            lblNotSorted.Text = "Not sorted:";
            //creat random numbers for sorting
            for (int i = 0; i < NotSortArray.Length; i++)
            {
                NotSortArray[i] = rnd.Next(100);
                lblNotSorted.Text += "\n" + NotSortArray[i];
            }
            //provide mid array
            for (int i = 0; i < NotSortArray.Length; i++)
            {
                temp[NotSortArray[i]]++;
            }
            //sort by use of mid array
            for (int i = 0; i < temp.Length; i++)
            {
                while (temp[i]!=0)
                {
                    sort.AddLast(i);
                    --temp[i];
                }
            }
            //print
            for (int i = 0; i < sort.Count ; i++)
			{
                lblSorted.Text +="\n"+sort.ElementAt<int>(i);
			 
			}
        }
    }
}
