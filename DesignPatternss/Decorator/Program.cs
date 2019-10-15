using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            IWeapon weapon = new Ak47();

            Console.WriteLine(weapon.Damage());
            Console.WriteLine(weapon.Heavy());
            Console.WriteLine(weapon.Rpm());

            Console.WriteLine();

            weapon = new Silencer(new Ak47());

            Console.WriteLine(weapon.Damage());
            Console.WriteLine(weapon.Heavy());
            Console.WriteLine(weapon.Rpm());

            Console.WriteLine();

            weapon = new Silencer(new HandTaker(new Ak47()));

            Console.WriteLine(weapon.Damage());
            Console.WriteLine(weapon.Heavy());
            Console.WriteLine(weapon.Rpm());

        }
    }
}
