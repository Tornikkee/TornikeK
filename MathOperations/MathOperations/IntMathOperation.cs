using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public class IntMathOperation : IMathOperation<int>
    {
        public int Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Substraction(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
