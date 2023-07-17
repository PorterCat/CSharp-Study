using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public abstract class Integrator
    {
        protected readonly Equation _equation;

        public Integrator(Equation equation) 
        {
            if (equation == null)
            {
                throw new ArgumentNullException();
            }
            _equation = equation;
        }

        protected void Check(double x1, double x2)
        {
            //проверяем допустимость параметров:
            if (x1 >= x2)
            {
                throw new ArgumentException("Правая граница интегирования должны быть больше левой!");
            }
        }

        public abstract double Integrate(double x1, double x2);

    }
}

/*private readonly Equation _equation;

       public Integrator(Equation equation)
       {
           if (equation == null)
           {
               throw new ArgumentNullException();
           }
           _equation = equation;
       }


       public double IntegrateTrapeze(double x1, double x2)
       {
           //проверяем допустимость параметров:
           if (x1 >= x2)
           {
               throw new ArgumentException("Правая граница интегирования должны быть больше левой!");
           }

           int N = 1000; //количество интервалов разбиения
           //определяем ширину интервала:
           double h = (x2 - x1) / N;

           double sum = (_equation.GetValue(x1) + _equation.GetValue(x2))/2; //"накопитель" для значения интеграла

           for (int i = 1; i < N-1; i++)
           {
               sum += _equation.GetValue(x1 + h * i);
           }
           return h * sum;
       }*/