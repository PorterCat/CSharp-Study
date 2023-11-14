using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacker.Strategy
{
    internal class Plunger : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Attack with plunger");
        }
    }
}
