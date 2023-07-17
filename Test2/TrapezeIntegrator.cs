using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2;

namespace Test2
{
    internal class TrapezeIntergrator : Integrator
    {
        public TrapezeIntergrator(Equation equation) : base(equation)
        {

        }

        public override double Integrate(double x1, double x2)
        {
            base.Check(x1, x2); //проверяем допустимость параметров:
            int N = 1000; //количество интервалов разбиения
                          //определяем ширину интервала:
            double h = (x2 - x1) / N;

            double sum = (_equation.GetValue(x1) + _equation.GetValue(x2)) / 2; //"накопитель" для значения интеграла

            for (int i = 1; i < N - 1; i++)
            {
                sum += _equation.GetValue(x1 + h * i);
            }

            sum *= h;

            Console.WriteLine($"The result: {sum}. Counted by Trapeze method");
            return sum;
        }
    }
}

