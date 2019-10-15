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
    abstract class Hero
    {
        private IHeroStaffs _heroStaffs;
        public void SetHeroStaff(IHeroStaffs heroStaffs)
        {
            this._heroStaffs = heroStaffs;
        }
        public void DoheroStaff()
        {
            _heroStaffs.DoStaff();
        }

    }
    class Batman : Hero
    {
    }
    class Superman : Hero
    {
    }
}
