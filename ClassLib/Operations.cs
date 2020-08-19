using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Operations : IOperations
    {
        /// <summary>
        /// Functionalities like addition, subtraction, Multiplication and Division which the class must have is written here.
        /// It takes parameters like first number and second number
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        /// 
        //It takes two number in as parameters first number and second number 
        //Add first number to the second number
        public string Addition(string firstNumber, string secondNumber)
        {
            double result = double.Parse(firstNumber) + double.Parse(secondNumber);
            return result.ToString();
        }

        //It takes two number in as parameters first number and second number 
        //Divide the second number by the first number
        public string Division(string firstNumber, string secondNumber)
        {
            if (secondNumber == "0") return "Error!!!";
            double result = double.Parse(firstNumber) / double.Parse(secondNumber);
            return result.ToString();
        }

        //It takes in two number in as parameters.
        //It multiple the first number by the second number.
        public string Multiplication(string firstNumber, string secondNumber)
        {
            double result = double.Parse(firstNumber) * double.Parse(secondNumber);
            return result.ToString();
        }

        //It takes in two number in as parameters.
        //It subtract the second number from the first number.
        public string Subtraction(string firstNumber, string secondNumber)
        {
            double result = double.Parse(firstNumber) - double.Parse(secondNumber);
            return result.ToString();
        }
       
        /// <summary>
        /// The calculate has an operation performed which dictates which of the operation to be carried out
        /// </summary It takes in three parameters first number, second number and operation to be carried out.
        /// It uses a switch statement to determine the operation to be carried out.
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        /// 
        public string Calculate(string firstNumber, string secondNumber, string operation)
        {
            string result = "";
            switch (operation)
            {

                case "+":
                    result += Addition(firstNumber, secondNumber);
                    break;
                case "-":
                    result += Subtraction(firstNumber, secondNumber);
                    break;
                case "*":
                    result += Multiplication(firstNumber, secondNumber);
                    break;
                case "/":
                    result += Division(firstNumber, secondNumber);
                    break;

            }
            return result;
        }
    }
}
