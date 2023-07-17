using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Integrator
    {
        private readonly Equation _equation;

        public Integrator(Equation equation)
        {
            if (equation == null)
            {
                throw new ArgumentNullException();
            }
            _equation = equation;
        }

        public double Integrate(double x1, double x2)
        {
            //проверяем допустимость параметров:
            if (x1 >= x2)
            {
                throw new ArgumentException("Правая граница интегирования должны быть больше левой!");
            }

            int N = 100; //количество интервалов разбиения
            //определяем ширину интервала:
            double h = (x2 - x1) / N;
            double sum = 0; //"накопитель" для значения интеграла

            for (int i = 0; i < N; i++)
            {
                sum = sum + _equation.GetValue(x1 + i * h) * h;
            }
            return sum;
        }

    }
}
