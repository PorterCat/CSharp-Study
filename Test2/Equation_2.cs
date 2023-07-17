using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2;

namespace Test2
{
    internal class Equation_2 : Equation
    {
        private readonly double _a;

        public Equation_2 (double a)
        {
            _a = a;
        }
        public override double GetValue(double x)
        {
            return Math.Sin(_a * x)/x;
        }

        public override void ShowEquation()
        {
            Console.WriteLine($"sin({_a}x)/x");
        }
    }
}
