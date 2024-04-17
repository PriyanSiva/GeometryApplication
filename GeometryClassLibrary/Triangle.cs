using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLibrary
{
    public class Triangle : IShape
    {
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

       
        
        public double CalculateArea()
        {
            // Calculate the semi-perimeter
            double semiperimeter = (side1 + side2 + side3) / 2;

            // Calculate the area using Heron's formula
            double area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            return area;
        }

        public double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }

        public double CalculateSemiPerimeter()
        {
            return (side1 + side2 + side3) / 2;
        }
    }
}
