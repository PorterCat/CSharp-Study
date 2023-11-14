using Atacker.Strategy;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacker
{
    internal class Hero
    {
        private readonly string _name;

        private IWeapon? _weapon;

        public Hero(string name)
        {
            _name = name;
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine(">>>");

            if(_weapon == null)
            {
                Console.WriteLine($"{_name} can't attack. Set a weapon");
                return;
            }

            Console.WriteLine($"{_name} stands menacingly");

            _weapon.Attack();

            Console.WriteLine($"{_name} don't stand menacingly");
        }
    }
}
