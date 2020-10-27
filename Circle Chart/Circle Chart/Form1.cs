using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace Circle_Chart
{
    public partial class Form1 : Form
    {
        ArrayList data = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }


        public ArrayList ConvertInputToArray(string inputString)
        {
            ArrayList resultData=new ArrayList();
            Regex regex = new Regex("\\d.+");
            MatchCollection match = regex.Matches(inputString);
            foreach (var item in regex.Matches(inputString))
            {
                resultData.Add(item);
                
            }
            return resultData;
        }


        public float[] ConvertDataToRadian(ArrayList inputData)
        {
            float sum=0;
            float[] result = new float[inputData.Count];
            foreach (var item in inputData)
            {
                sum += float.Parse(item.ToString());
            }
            for (int i = 0; i < inputData.Count; i++)
            {
                result[i] = ((float.Parse(inputData[i].ToString()) / sum) * 360);
            }
            return result;
        }


        public void DrawCircleChart(float[] inputData)
        {
            float dgreeSum=0;
            Graphics graphic = pnlDraw.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphic.Clear(this.BackColor);
            for (int i = 0; i < inputData.Length; i++)
			{
                int counter = 0;
                Random rnd = new Random();
                SolidBrush brush = new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
                Pen pen = new Pen(Color.Black);
                while (counter<inputData[i])
                {
                    graphic.FillPie(brush, 0, 0, 200, 200, dgreeSum - 90, counter);
                    graphic.DrawPie(pen, 0, 0, 200, 200, dgreeSum - 90, counter);
                    System.Threading.Thread.Sleep(1);
                    counter += 1;
                }
                graphic.FillPie(brush, 0, 0, 200, 200, dgreeSum - 90, inputData[i]);
                graphic.DrawPie(pen, 0, 0, 200, 200, dgreeSum - 90, inputData[i]);
                dgreeSum += inputData[i];
 
			}      
 
        }

        private void btmDraw_Click(object sender, EventArgs e)
        {
            ArrayList list;
            float[] dataArray;
            list = ConvertInputToArray(txtbInput.Text);
            dataArray = ConvertDataToRadian(list);
            DrawCircleChart(dataArray);
        }
    }
}
