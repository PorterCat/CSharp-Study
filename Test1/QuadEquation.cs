using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class QuadEquation : Equation
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public QuadEquation(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public override double GetValue(double x)
        {
            return _a * x * x + _b * x + _c;
        }

        /*public void ShowEquation()
        {
            Console.WriteLine($"{_a}x^2 + {_b}x + {_c}");
        }*/
    }
}
