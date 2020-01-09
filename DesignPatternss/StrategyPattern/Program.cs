using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Batman();

            hero.SetHeroStaff(new Fly());
            hero.DoheroStaff();

            hero.SetHeroStaff(new Attack());          

            hero.DoheroStaff();
        }
    }
    
}
