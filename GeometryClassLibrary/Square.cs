using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLibrary
{
    public class Square : IShape
    {
        private readonly double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public double CalculateArea()
        {
            return sideLength * sideLength;
        }

        public double CalculatePerimeter()
        {
            return 4 * sideLength;
        }
    }
}
