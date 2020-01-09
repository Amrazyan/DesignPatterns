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

            Console.WriteLine("Base Ak47 \n");
            Console.WriteLine(weapon.Damage());
            Console.WriteLine(weapon.Heavy());
            Console.WriteLine(weapon.Rpm());

            Console.WriteLine("-----------------\n");

            Console.WriteLine("Ak47 with Silencer\n");

            weapon = new Silencer(new Ak47());

            Console.WriteLine(weapon.Damage());
            Console.WriteLine(weapon.Heavy());
            Console.WriteLine(weapon.Rpm());

            Console.WriteLine("-----------------\n");

            Console.WriteLine("Ak47 with Silencer and HandTaker\n");

            weapon = new Silencer(new HandTaker(new Ak47()));

            Console.WriteLine(weapon.Damage());
            Console.WriteLine(weapon.Heavy());
            Console.WriteLine(weapon.Rpm());

        }
    }
}
