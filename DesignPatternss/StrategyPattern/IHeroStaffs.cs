using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface IHeroStaffs
    {
        void DoStaff();

    }

    class Fly : IHeroStaffs
    {
        public void DoStaff()
        {
            Console.WriteLine("Fly");
        }
    }

    class Attack : IHeroStaffs
    {
        public void DoStaff()
        {
            Console.WriteLine("Attack");
        }
    }
}
