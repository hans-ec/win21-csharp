using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TDD.SharedLibrary.Models
{
    public class Calculator
    {
        /// <summary>
        /// Will add two numbers together and return the result
        /// </summary>
        /// <param name="firstNumber">First number to add</param>
        /// <param name="secondNumber">Second number to add</param>
        /// <returns>The sumerized value of the two numbers</returns>
        public decimal Add(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public decimal Sub(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public decimal Div(decimal number, decimal divideBy)
        {
            return number / divideBy;
        }

        public decimal Mul(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
