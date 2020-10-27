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
using calculator.Class;

namespace calculator
{
    public partial class pnlCalculator : Form
    {
        //graphic for tracing stack
        Graphics gr;
        //stacks for tracing
        drawStack dsOperators;
        drawStack dsNumbers;
        //bitmap for gr graphic
        Bitmap btm;
        //position of drawing
        int counterX;
        int counterY;

        public pnlCalculator()
        {
            InitializeComponent();
            btm = new Bitmap(pnlPaper.Width, 5000);
            gr = Graphics.FromImage(btm);
            dsNumbers = new drawStack();
            dsOperators = new drawStack();
            //specify first cell of stack  a name
            dsOperators.push("operators");
            dsNumbers.push("numbers");
        }





        //method for calculating expretions
        public float CalculateString(string inputString)
        {
            //initialize stacks
            cstack<char> operators = new cstack<char>(100);
            cstack<float> numbers = new cstack<float>(100);
            // store last operator
            char lastOperator = 'a';
            //convert expretion to char array
            char[] storeage = inputString.ToCharArray();
            //explore all of the expretion
            for (int i = 0; i < storeage.Length; i++)
            {
                //if the cell of char array is number
                if (char.IsNumber(storeage[i]))
                {
                    //store numbers
                    float temp = 0;
                    //for dot in 55.66 (store number of digits before and after dot)
                    int beforDot = 0;
                    int lenghtOfNumber = 0;
                    //read number to end of it
                    for (; i < storeage.Length && char.IsNumber(storeage[i]); i++)
                    {
                        //create numbers from string
                        temp = (temp * 10) + (Convert.ToInt32(storeage[i]) - 48);

                        //specify the position of "." in the number
                        if (i < storeage.Length-1 && storeage[i+1] == '.')
                        {
                            beforDot++;
                            i++;
                        }
                        lenghtOfNumber++;
                    }

                    if (lastOperator == '-')
                    {
                        //convert (- 5) to negative five 
                        temp = temp * (-1);
                        //delete - from operators
                        operators.pop();
                        log("popOperators", "", "pop Operators stack");

                        if (!operators.IsEmpty)
                        {
                            //store last operator befor -
                            char operatorTemp = operators.pop();
                            log("popOperators", operatorTemp.ToString(), "pop" + operatorTemp + " to Operators stack");
                            //modefiy negative in 5*(-5+) to negative number
                            if (storeage[i - 1] == '(')
                            {
                                //push ( => (-5) to (negative number)
                                operators.push(operatorTemp);
                                log("pushOperators", operatorTemp.ToString(), "push" + operatorTemp + " to Operators stack");
                            }
                            else
                            {
                                //push ( and => 5-3 to 5+(negative number)
                                operators.push(operatorTemp);
                                log("pushOperators", operatorTemp.ToString(), "push" + operatorTemp + " to Operators stack");

                                operators.push('+');
                                log("pushOperators", "+", "push" + '+' + " to Operators stack");

                            }
                        }
                        else
                        {
                            //push + instead of - (5-6 => 5+(-6))
                            operators.push('+');
                            log("pushOperators", "+", "push" + '+' + " to Operators stack");

                        }
                    }
                    if (beforDot > 0)
                    {
                        //creat float number by devide by 10 ((lenghtOfNumber - beforDot) is the position of ".")
                        temp /= (float)Math.Pow(10, lenghtOfNumber - beforDot);

                    }
                    //push number to stack
                    numbers.push(temp);
                    log("pushNumbers", temp.ToString(), "push" + temp + " to Numbers stack");

                }
                //check if after number is a operator
                if (i < storeage.Length)
                {
                    //check the sequantion of operators (+ shouldnt stay upper than * in the stack
                    if ((storeage[i] == '+' || storeage[i] == '-') && (lastOperator == '*' || lastOperator == '/'))
                    {
                        //calculate
                        while (!operators.IsEmpty)
                        {
                            char operatoR = operators.pop();
                            log("popOperators", operatoR.ToString(), "pop" + operatoR + " to Operators stack");
                            if (operatoR == '(')
                            {
                                operators.push('(');
                                log("pushOperators", "(", "push" + '(' + " to Operators stack");

                                break;
                            }
                            float num2 = numbers.pop();
                            log("popNumbers", num2.ToString(), "pop" + num2 + " to Numbers stack");
                            float num1 = numbers.pop();
                            log("popNumbers", num1.ToString(), "pop" + num1 + " to Numbers stack");

                            float result = operation(operatoR, num1, num2);
                            numbers.push(result);
                            log("pushNumbers", result.ToString(), "push" + num1 + operatoR + num2 + "(" + result + ")" + " to Numbers stack");

                        }
                    }

                    //push operator if should
                    if ((storeage[i] == '+' || storeage[i] == '-' || storeage[i] == '*' || storeage[i] == '/'))
                    {
                        lastOperator = storeage[i];
                        operators.push(storeage[i]);
                        log("pushOperators", storeage[i].ToString(), "push" + storeage[i] + " to Operators stack");

                    }

                    else if (storeage[i] == '(')
                    {
                        //5(3-2) to 5*(3-2);
                        if (i > 0 && !(storeage[i - 1] == '+' || storeage[i - 1] == '-' || storeage[i - 1] == '*' || storeage[i - 1] == '/'))
                        {
                            operators.push('*');
                            log("pushOperators", "*", "push" + '*' + " to Operators stack");

                        }
                        operators.push(storeage[i]);
                        log("pushOperators", storeage[i].ToString(), "push" + storeage[i] + " to Operators stack");

                        lastOperator = storeage[i];
                    }
                        //calculate expretions in ( and ) when arrive )
                    else if (storeage[i] == ')')
                    {
                        char ctemp = 'a';
                        while ((ctemp = operators.pop()) != '(')
                        {
                            log("popOperators", ctemp.ToString(), "pop" + ctemp + " to Operstors stack");
                            float num2 = numbers.pop();
                            log("popNumbers", num2.ToString(), "pop" + num2 + " to Numbers stack");
                            float num1 = numbers.pop();
                            log("popNumbers", num1.ToString(), "pop" + num1 + " to Numbers stack");
                            float result = operation(ctemp, num1, num2);
                            numbers.push(result);
                            log("pushNumbers", result.ToString(), "push" + num1 + ctemp + num2 + "(" + result + ")" + " to Numbers stack");

                        }
                        //(5-6)6 to (5-6)*6
                        if (i < storeage.Length - 1 && !(storeage[i + 1] == '+' || storeage[i + 1] == '-' || storeage[i + 1] == '*' || storeage[i + 1] == '/'))
                        {
                            operators.push('*');
                            log("pushOperators", "*", "push" + '*' + " to Operators stack");

                        }
                        lastOperator = 'a';
                    }

                }


            }
            //calculate last result
            while (!operators.IsEmpty)
            {
                float num2 = numbers.pop();
                log("popNumbers", num2.ToString(), "pop" + num2 + " to Numbers stack");
                float num1 = numbers.pop();
                log("popNumbers", num1.ToString(), "pop" + num1 + " to Numbers stack");
                char operatoR = operators.pop();
                log("popOperators", operatoR.ToString(), "pop" + operatoR + " to Operators stack");
                float result = operation(operatoR, num1, num2);
                numbers.push(result);
                log("pushNumbers", result.ToString(), "push" + num1 + operatoR + num2 + "(" + result + ")" + " to Numbers stack");
            }
            //pop last number in the stack as result
            float res = numbers.pop();
            log("popNumbers", res.ToString(), "pop" + res + " to Numbers stack");
            return res;
        }




        //execute operation (calculate)
        public float operation(char operatoR, float input1, float input2)
        {
            if (operatoR == '+')
            {
                return input1 + input2;
            }
            else if (operatoR == '-')
            {
                return input1 - input2;
            }
            else if (operatoR == '*')
            {
                return input1 * input2;
            }
            else if (operatoR == '/')
            {
                return input1 / input2;
            }
            return 0;

        }





        //log proc for tracing
        private void log(string command, string value, string log)
        {
            lblTrace.Text += "\r\n" + log;
            if (!(value == ""))
            {


                if (command == "popNumbers")
                {
                    dsNumbers.pop();
                    //draw
                    dsNumbers.drew(gr, new Point(20 + counterX, counterY + 20), Brushes.LightGray);
                    counterX += 60;
                }
                if (command == "pushNumbers")
                {
                    dsNumbers.push(value);
                    dsNumbers.drew(gr, new Point(20 + counterX, counterY + 20), Brushes.LightGray);
                    counterX += 60;
                }
                if (command == "popOperators")
                {
                    dsOperators.pop();
                    dsOperators.drew(gr, new Point(20 + counterX, counterY + 20), Brushes.LightGreen);
                    counterX += 60;
                }
                if (command == "pushOperators")
                {
                    dsOperators.push(value);
                    dsOperators.drew(gr, new Point(20 + counterX, counterY + 20), Brushes.LightGreen);
                    counterX += 60;
                }

                //check if the drow goiing out of the papaer
                if (counterX + 70 > pnlPaper.Size.Width)
                {
                    counterY += 200;
                    counterX = 0;

                    //increase the size of paper
                    pnlPaper.Size = new System.Drawing.Size(pnlPaper.Size.Width, counterY + 200);

                    gr.DrawLine(Pens.Black, new Point(0, counterY + 15), new Point(this.Size.Width, counterY + 15));
                }
            }

        }




        //check wich keys press
        private void txtbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblStore.Text = "";
            //clear errors
            errorProvider1.Clear();
            char chr = e.KeyChar;

            if (char.IsLetter(chr))
            {
                errorProvider1.SetError(txtbInput, "Please insert correct charactor!");
            }

            if (!char.IsControl(chr))
            {
                e.Handled = true;
               
            }
            switch (chr)
            {
                case '0':
                    {
                        btn0_Click(sender, e);
                        break;
                    }
                case '1':
                    {
                        btn1_Click(sender, e);
                        break;
                    }
                case '2':
                    {
                        btn2_Click(sender, e);

                        break;
                    }
                case '3':
                    {
                        btn3_Click(sender, e);

                        break;
                    }
                case '4':
                    {
                        btn4_Click(sender, e);

                        break;
                    }
                case '5':
                    {
                        btn5_Click(sender, e);

                        break;
                    }
                case '6':
                    {
                        btn6_Click(sender, e);

                        break;
                    }
                case '7':
                    {
                        btn7_Click(sender, e);

                        break;
                    }
                case '8':
                    {
                        btn8_Click(sender, e);

                        break;
                    }
                case '9':
                    {
                        btn9_Click(sender, e);

                        break;
                    }
                case '+':
                    {
                        btnPlus_Click(sender, e);
                        break;
                    }
                case '-':
                    {
                        btnNegative_Click(sender, e);
                        break;
                    }
                case '*':
                    {
                        btnMul_Click(sender, e);
                        break;
                    }
                case '/':
                    {
                        btnDvide_Click(sender, e);
                        break;
                    }
                case '(':
                    {
                        btnop_Click(sender, e);
                        break;
                    }
                case ')':
                    {
                        btncp_Click(sender, e);
                        break;
                    }
                case '.':
                    {
                        btnDot_Click(sender, e);
                        break;
                    }
                case (char)Keys.Enter:
                    {
                        btnEqual_Click(sender, e);
                        break;
                    }
                    

                default:
                    break;
            }
            //beacuse the keyboard curser should be in the end of the text
            txtbInput.SelectionStart = txtbInput.TextLength;

        }




        private void btn1_Click(object sender, EventArgs e)
        {
            txtbInput.Text += "1";
        }




        private void btn2_Click(object sender, EventArgs e)
        {
            txtbInput.Text += "2";
        }





        private void btn3_Click(object sender, EventArgs e)
        {
            txtbInput.Text += "3";
        }





        //convert 5*/6 to 5/6 delete last opetator and put new opetator
        private void btnDvide_Click(object sender, EventArgs e)
        {
            char[] chr = txtbInput.Text.ToCharArray();
            string operatoR = "*+-/";
            if (chr.Length>0 && (char.IsNumber(chr[chr.Length-1])||operatoR.Contains(chr[chr.Length-1])))
            {
                if (operatoR.Contains(chr[chr.Length - 1]))
                {
                    chr[chr.Length - 1] = '/';
                    txtbInput.Text = new string(chr);
                }
                else
                {
                    txtbInput.Text += "/";

                }  
            }
        }





        private void btn4_Click(object sender, EventArgs e)
        {
            txtbInput.Text += "4";
        }





        private void btn5_Click(object sender, EventArgs e)
        {
            txtbInput.Text += "5";
        }





        private void btn6_Click(object sender, EventArgs e)
        {
            txtbInput.Text += "6";
        }





        //convert 6+*5 to 6*5
        private void btnMul_Click(object sender, EventArgs e)
        {
            char[] chr = txtbInput.Text.ToCharArray();
            string operatoR = "*+-/";
            if (chr.Length > 0 && (char.IsNumber(chr[chr.Length - 1]) || operatoR.Contains(chr[chr.Length - 1])))
            {
                if (operatoR.Contains(chr[chr.Length - 1]))
                {
                    chr[chr.Length - 1] = '*';
                    txtbInput.Text = new string(chr);
                }
                else
                {
                    txtbInput.Text += "*";

                }
            }
        }





        private void btn7_Click(object sender, EventArgs e)
        {
            txtbInput.Text += "7";
        }





        private void btn8_Click(object sender, EventArgs e)
        {
            txtbInput.Text += "8";
        }





        private void btn9_Click(object sender, EventArgs e)
        {
            txtbInput.Text += "9";
        }




        //convert 5+-6 to 5-6
        private void btnNegative_Click(object sender, EventArgs e)
        {
            char[] chr = txtbInput.Text.ToCharArray();
            string operatoR = "*+-/";
            if (chr.Length > 0 && operatoR.Contains(chr[chr.Length - 1]))
            {

                chr[chr.Length - 1] = '-';
                txtbInput.Text = new string(chr);

            }
            else
            {
                txtbInput.Text += "-";

            }

                
            
        }





        private void btn0_Click(object sender, EventArgs e)
        {
            txtbInput.Text += "0";
        }





        // convert .5 to 0.5 if nessesery
        private void btnDot_Click(object sender, EventArgs e)
        {
            char[] chr = txtbInput.Text.ToCharArray();
            string operatoR = "*+-/";
            if (chr.Length==0||operatoR.Contains(chr[chr.Length-1]))
            {
                txtbInput.Text += "0";
                txtbInput.Text += ".";

            }
            else
            {
                txtbInput.Text += ".";

            }
        }





        //convert 8*+6 to 8+6 
        private void btnPlus_Click(object sender, EventArgs e)
        {
            char[] chr = txtbInput.Text.ToCharArray();
            string operatoR = "*+-/";
            if (chr.Length > 0 && (char.IsNumber(chr[chr.Length - 1]) || operatoR.Contains(chr[chr.Length - 1])))
            {
                if (operatoR.Contains(chr[chr.Length - 1]))
                {
                    chr[chr.Length - 1] = '+';
                    txtbInput.Text = new string(chr);
                }
                else
                {
                    txtbInput.Text += "+";

                }
            }
        }





        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbInput.Text = "";
        }




        private void btnEqual_Click(object sender, EventArgs e)
        {
            //check that number of ( and ) should be equal 
            int op = 0;
            int cp = 0;
            foreach (var item in txtbInput.Text)
            {
                if (item=='(')
                {
                    op++;
                }
                else if (item==')')
                {
                    cp++;
                }
            }
            //error apear if the number of ( and ) is not equal
            if (!(op==cp))
            {
                errorProvider1.SetError(txtbInput, "please use the same number of ( and )!");
                return;
            }
            //clear paper
            gr.Clear(this.BackColor);
            //reset the position of drawing
            counterX = 0;
            counterY = 0;

            lblTrace.Text = "";
            lblStore.Text = txtbInput.Text+" :";

            txtbInput.Text = CalculateString(txtbInput.Text).ToString();
            //set the bitmap file that we drowing on it as the panel background
            pnlPaper.BackgroundImage = btm;
            
        }





        private void btnop_Click(object sender, EventArgs e)
        {
            txtbInput.Text += "(";
        }





        private void btncp_Click(object sender, EventArgs e)
        {
            txtbInput.Text += ")";
        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }


    }
}
