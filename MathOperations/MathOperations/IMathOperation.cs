using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public interface IMathOperation<T>
    {
        public T Addition(T type1, T type2);
        public T Substraction(T type1, T type2);
        public T Multiplication(T type1, T type2);
    }
}
