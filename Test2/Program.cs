using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Xml.Linq;

namespace Test2
{
    internal class Program
    {
        static void Main()
        {
            Equation e = new QuadEquation(0, 2, 0);
            Console.WriteLine("Equation: ");
            e.ShowEquation();

            Integrator i1 = new RectangleIntergrator(e);
            i1.Integrate(0, 5);
        }
    }
}
