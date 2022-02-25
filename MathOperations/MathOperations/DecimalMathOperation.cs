using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public class DecimalMathOperation : IMathOperation<double>
    {
        public double Addition(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Substraction(double number1, double number2)
        {
            return number1 - number2;
        }
    }
}
