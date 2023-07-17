using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2;

namespace Test2
{
    internal class RectangleIntergrator : Integrator
    {
        public RectangleIntergrator(Equation equation) : base(equation)
        {

        }

        public override double Integrate(double x1, double x2)
        {
            base.Check(x1, x2); //проверяем допустимость параметров:
            int N = 1000; //количество интервалов разбиения
            //определяем ширину интервала:
            double h = (x2 - x1) / N;
            double sum = 0; //"накопитель" для значения интеграла

            for (int i = 0; i < N; i++)
            {
                sum = sum + base._equation.GetValue(x1 + i * h) * h;
            }
            Console.WriteLine($"The result: {sum}. Counted by Triangle method");
            return sum;
        }
    }
}
