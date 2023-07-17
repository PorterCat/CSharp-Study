using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Calculator
    {
        public double GetTriangleSquare(double ab, double ac, double bc)
        {
            double p = (ab + ac + bc) / 2;
            return Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc));
        }

        public double GetTriangleSquare(double b, double h) => 0.5 * b * h;

        public double GetTriangleSquare(double ab, double ac, int alpha) => 0.5 * ab * ac * Math.Sin(alpha);
        
    }
}
