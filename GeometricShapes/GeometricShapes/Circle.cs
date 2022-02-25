using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    public class Circle : Shape
    {
        public double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
