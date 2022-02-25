using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException(string text) : base(string.Format("It is impossible to create triangle by given side numbers"))
        {

        }
    }
}
