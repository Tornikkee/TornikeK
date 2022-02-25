using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public class MatrixMathOperation2x2
    {
        public int _element0_0;
        public int _element0_1;
        public int _element1_0;
        public int _element1_1;

        public MatrixMathOperation2x2(int element0_0, int element0_1, int element1_0, int element1_1)
        {
            _element0_0 = element0_0;
            _element0_1 = element0_1;
            _element1_0 = element1_0;
            _element1_1 = element1_1;
        }

        #region Operators
        public static MatrixMathOperation2x2 operator + (MatrixMathOperation2x2 m1, MatrixMathOperation2x2 m2)
        {
            return new MatrixMathOperation2x2(m1._element0_0 + m2._element0_0, m1._element0_1 + m2._element0_1, m1._element1_0 + m2._element1_0, m1._element1_1 + m2._element1_1);
        }

        public static MatrixMathOperation2x2 operator - (MatrixMathOperation2x2 m1, MatrixMathOperation2x2 m2)
        {
            return new MatrixMathOperation2x2(m1._element0_0 - m2._element0_0, m1._element0_1 - m2._element0_1, m1._element1_0 - m2._element1_0, m1._element1_1 - m2._element1_1);
        }

        public static MatrixMathOperation2x2 operator * (MatrixMathOperation2x2 m1, MatrixMathOperation2x2 m2)
        {
            return new MatrixMathOperation2x2((m1._element0_0 * m2._element0_0) + (m1._element0_1 * m2._element1_0), (m1._element0_0 * m2._element0_1) + (m1._element0_1 * m2._element1_1), (m1._element1_0 * m2._element0_0) + (m1._element1_1 * m2._element1_0), (m1._element1_0 * m2._element0_1) + (m1._element1_1 * m2._element1_1));
        }
        #endregion

        public override string ToString()
        {
            string m1 = $"{_element0_0} ";
            string m2 = $"{_element0_1} ";
            string m3 = $"{_element1_0} ";
            string m4 = $"{_element1_1} ";
            string matrix = m1 + m2 + "\n" + m3 + m4;

            return matrix;
        }
    }
}
