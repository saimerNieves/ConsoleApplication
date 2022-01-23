using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary
{
    public class BasicMathLibrary
    {


        /// <summary>
        /// This is a function that adds 2 numbers together adn returns a sum
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>

        public double AddNumbers(double num1, double num2)
        {

            //this adds 2 numbers together
            return num1 + num2;
        }


        /// <summary>
        /// This is a function that subtracts 2 numbers from one another and returns a difference
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }


        /// <summary>
        /// This is a function that Multiplies 2 numbers together and returns a product
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double MultiplyNumbers(double num1, double num2)
        {
            return num1 * num2;
        }



        /// <summary>
        /// This is a function that Multiplies 2 numbers together and returns a Quotient
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double DivideNumbers(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
