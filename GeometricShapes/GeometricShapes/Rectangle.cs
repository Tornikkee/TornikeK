using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    public class Rectangle : Shape
    {
        public double _side1;
        public double _side2;

        public Rectangle(double side1, double side2)
        {
            this._side1 = side1;
            this._side2 = side2;
        }

        public override double Perimeter()
        {
            return 2 * _side1 + 2 * _side2;
        }

        public override double Area()
        {
            return _side1 * _side2;
        }
    }
}
