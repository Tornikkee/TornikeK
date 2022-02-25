using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public class VectorMathOperation
    {
        double[] vector = new double[2];

        public VectorMathOperation(double a, double b)
        {
            vector[0] = a;
            vector[1] = b;
        }

        public static VectorMathOperation operator +(VectorMathOperation v1, VectorMathOperation v2)
        {
            return new VectorMathOperation(v1.vector[0] + v2.vector[0], v1.vector[1] + v2.vector[1]);
        }

        public static VectorMathOperation operator -(VectorMathOperation v1, VectorMathOperation v2)
        {
            return new VectorMathOperation(v1.vector[0] - v2.vector[0], v1.vector[1] - v2.vector[1]);
        }

        public static VectorMathOperation operator *(VectorMathOperation v1, VectorMathOperation v2)
        {
            return new VectorMathOperation(v1.vector[0] * v2.vector[0], v1.vector[1] * v2.vector[1]);
        }

        

        public override string ToString()
        {
            string v = vector[0] + "\n" + vector[1];
            return v;
        }
    }
}
