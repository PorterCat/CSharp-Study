using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2;

namespace Test2
{
    internal class Equation_6 : Equation
    {
        private readonly double _a;

        public Equation_6 (double a)
        {
            _a = a;
        }
        public override double GetValue(double x)
        {
            return _a * x * Math.Abs(Math.Sin(x));
        }

        public override void ShowEquation()
        {
            Console.WriteLine($"{_a}*x|sin(x)|");
        }
    }
}
