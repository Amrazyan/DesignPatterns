using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IWeapon
    {
        int Damage();
        int Heavy();
        int Rpm();

    }
    public class Ak47 : IWeapon
    {
        public int Damage()
        {
            return 32;
        }

        public int Heavy()
        {
            return 2;
        }

        public int Rpm()
        {
            return 1200;
        }
    }
   
}
