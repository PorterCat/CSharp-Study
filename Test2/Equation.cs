using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//_2. sin(a*x)/x;
//_6. a*x*| sin(x) |, здесь | | - модуль числа. 

namespace Test2
{
    public abstract class Equation
    {
        public abstract double GetValue(double x);
        public abstract void ShowEquation();
    }
}