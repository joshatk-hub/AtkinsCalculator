using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtkinsCalculator
{
    internal class CalcFunctions
    {
        private double storedValue = 0; //value as a double so arithmetic operations can take place
        private string currentOperator = "";    //operator as a string
        private string currentInput = "0";      //input as a string so it can be displayed
        private bool newInput = true;   // newInput is true at the start of the code run and after an operation takes place
        public string Display => currentInput; // i think i called this the consignment operator for some reason in the video, it's actually an expression bodied
                                                //assignment so the value is constantly updated and displayed

        public void InputDigit(string digit)
        {
            if (newInput)
            {
                currentInput = digit;
                newInput = false;
            }
            else
            {
                currentInput += digit;
            }
        }
        public void DecimalPoint()
        {
            if (newInput)
            {
                currentInput = "0.";
                newInput = false;
            }
            else if (!currentInput.Contains(".")) 
            {
                currentInput += ".";
            }
        }
        public void Clear() // sets the app to the original run state basically
        {
            storedValue = 0;
            currentOperator = "";
            currentInput = "0";
            newInput = true;
        }
        public void Backspace()
        {
            if (newInput)
                return;
            else if (currentInput.Length >1)
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
            }
            else
            {
                currentInput = "0";
                newInput = true;
            }
        }
        public double Operations(double value1, double value2, string op) // used a switch-case statement, seemed the easiest with my setup 
        {
            switch (op)
            {
                case "+":
                    return value1 + value2;
                case "-":
                    return value1 - value2;

                case "*":
                    return value1 * value2;
                case "/":
                    if (value2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero."); // couldn't figure out try-catch statement, this works well though. 
                        Clear();                                        //the try catch statement took me out of the app and crashed it
                        return 0;
                    }
                    else
                        return value1 / value2;
                default:
                    throw new InvalidOperationException("Invalid operator.");
            }
        }
        
        public void Calculate()
        {
            if(string.IsNullOrEmpty(currentOperator))
            {
                storedValue = double.Parse(currentInput);
            }
            else
            {
                double currentValue = double.Parse(currentInput);
                storedValue = Operations(storedValue, currentValue, currentOperator);
                currentInput = storedValue.ToString();
                currentOperator = "";
                newInput = true;
            }
        }

        public void SetOperator(string op)
        {
            if (!string.IsNullOrEmpty(currentOperator))
            {
                Calculate();
            }
            else
            {
                storedValue = double.Parse(currentInput);
            }
            currentOperator = op;
            newInput = true;
        }
        
        public void ChangeSign()
        {
            if (currentInput != "0")
            {
                if (currentInput.StartsWith("-"))
                {
                    currentInput = currentInput.Substring(1);
                }
                else
                {
                    currentInput = "-" + currentInput;
                }
            }
        }
        public void SquareRoot()
        {
            double currentValue = double.Parse(currentInput);
            if (currentValue < 0)
            {
                throw new InvalidOperationException("cannot calculate square root of a negative number."); // this exception and the one below also crash the app,
            }                                                                                              //  not sure how to avoid
            currentInput = Math.Sqrt(currentValue).ToString();
            newInput = true;
        }
        
        public void Reciprocal()
        {
            double currentValue = double.Parse(currentInput);
            if (currentValue == 0)
            {
                throw new InvalidOperationException("cannot calculate reciprocal of zero.");
            }
            currentInput = (1 / currentValue).ToString();
            newInput = true;
        }
    }
}
