using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear error messages (if any)
            ClearErrorMessages();

            string operand1 = operand1TextBox.Text;
            string op = operatorTextBox.Text;
            string operand2 = operand2TextBox.Text;

            if (IsValidData(operand1, op, operand2) == true) 
            {
                double operand1Num = Convert.ToDouble(operand1);
                double operand2Num = Convert.ToDouble(operand2);

                //If user divides by zero
                if (op == "/" && operand1Num == 0 || op == "/" && operand2Num == 0)
                {
                    resultError.Text = "Cannot divide by 0";
                    resultError.ForeColor = Color.Red;
                }
                else
                {
                    Calculate(operand1Num, operand2Num, op);
                }
            }
        }

        /// <summary>
        /// Checks for all types of user input, and displays the correct error message
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="op"></param>
        /// <param name="operand2"></param>
        /// <returns></returns>
        private bool IsValidData(string operand1, string op, string operand2)
        {
            return
                //Checks for text in textbox
                IsPresent(operand1, "Operand 1", operand1Error) &&
                IsPresent(op, "Operator", operatorError) &&
                IsPresent(operand2, "Operand 2", operand2Error) &&

                //Checks if number input is valid
                IsDecimal(operand1, operand1Error) && IsDecimal(operand2, operand2Error) &&

                //Checks if number input is within range
                IsWithinRange(operand1, operand1Error) &&
                IsWithinRange(operand2, operand2Error) &&

                //Checks for valid operator
                IsOperator(op, operatorError);
        }

        /// <summary>
        /// Clears any error messages displayed in the form, if there are any
        /// </summary>
        private void ClearErrorMessages()
        {
            operand1Error.Text = string.Empty;
            operand2Error.Text = string.Empty;
            operatorError.Text = string.Empty;
            resultError.Text = string.Empty;
        }

        /// <summary>
        /// Checks if user provided any input and displays an error if user provides no input
        /// </summary>
        /// <param name="userInput">Textbox input</param>
        /// <param name="name">Name of the textbox</param>
        /// <returns></returns>
        private bool IsPresent(string userInput, string name, Label errMsg) 
        {
            if (userInput == "" || userInput == null) 
            {
                errMsg.Text = $"{name} is required!";
                errMsg.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if user provides a valid integer or decimal, and displays error if it isn't
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        private bool IsDecimal(string userInput, Label errMsg) 
        {
            double numInput;

            if (!double.TryParse(userInput, out numInput)) //If input is not a decimal number, display error
            {
                errMsg.Text = "Must be a valid integer or decimal";
                errMsg.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if user provides a number that is within range
        /// </summary>
        /// <returns></returns>
        private bool IsWithinRange(string userInput, Label errMsg) 
        {
            //Convert user's string input to a number
            double num = Convert.ToDouble(userInput);

            if (num < 0 || num > 1000000) 
            {
                errMsg.Text = "Must be between 0 and 1,000,000";
                errMsg.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if user provides a valid +, -, *, / operator, and displays error
        /// if it's not any of those
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        private bool IsOperator(string userInput, Label errMsg) 
        {
            if (userInput == "+" || userInput == "-" || userInput == "*" || userInput == "/") 
            {
                return true;
            }
            errMsg.Text = "Must be a +,  -,  *,  or  /";
            errMsg.ForeColor = Color.Red;
            return false;
        }

        /// <summary>
        /// Once all input is valid, the calculation is finally perfomed
        /// </summary>
        private void Calculate(double operand1, double operand2, string operatorInput) 
        {
            //Initialize result
            double result = 0;

            if (operatorInput == "+") 
            {
                result = operand1 + operand2;
            }
            else if (operatorInput == "-")
            {
                result = operand1 - operand2;
            }
            else if (operatorInput == "*")
            {
                result = operand1 * operand2;
            }
            else if (operatorInput == "/")
            {
                result = operand1 / operand2;
            }

            //Round result to 4 decimal places
            result = Math.Round(result, 4);

            //Print out the calculation result in the textbox
            resultBox.Text = result.ToString();
        }

        /// <summary>
        /// Exits the form when user clicks the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Clears out the result's display box, if user changes the value 
        /// of the text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputChange_TextChanged(object sender, EventArgs e)
        {
            resultBox.Text = "";
        }
    }
}
