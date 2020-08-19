using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public interface IOperations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        string Addition(string firstNumber, string secondNumber);

        string Subtraction(string firstNumber, string secondNumber);

        string Multiplication(string firstNumber, string secondNumber);

        string Division(string firstNumber, string secondNumber);

        string Calculate(string firstNumber, string secondNumber, string operation);
    }
}
