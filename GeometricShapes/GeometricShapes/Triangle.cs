using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    public class Triangle : Shape
    {
        public double _side1;
        public double _side2;
        public double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if(ValidateTriangle(side1, side2, side3) == true)
            {
                this._side1 = side1;
                this._side2 = side2;
                this._side3 = side3;
            }
            else
            {
                throw new InvalidTriangleException("Given numbers can not create triangle");
            }
        }

        public bool ValidateTriangle(double side1, double side2, double side3)
        {
            if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2)
                return true;
            else
                return false;
        }

        public override double Perimeter()
        {
            return _side1 + _side2 + _side3;
        }

        public override double Area()
        {
            double semiP = Perimeter() / 2;
            double area = Math.Sqrt(semiP * (semiP - _side1) * (semiP - _side2) * (semiP - _side3));

            return area;
        }
    }
}
