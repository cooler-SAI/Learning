using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_Pattern.Strategies;

namespace Strategy_Pattern
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
            Console.WriteLine(">>>>>>>");

            if (_weapon is null)
            {
                Console.WriteLine($"{_name} can't attack! You need to use weapons");
                return;
            }

            Console.WriteLine($"{_name} trying to use weapons.");

            Console.Write($"{_name} ");

            _weapon.Shoot();

            Console.WriteLine($"{_name} used weapon and get a cover!");
        }
    }
}