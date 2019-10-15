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

    public class WeaponAccessoriesDecorator : IWeapon
    {
        private IWeapon weapon;
        public WeaponAccessoriesDecorator(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public virtual int Damage()
        {
            return this.weapon.Damage();
        }

        public virtual int Heavy()
        {
            return this.weapon.Heavy();
        }

        public virtual int Rpm()
        {
            return this.weapon.Rpm();
        }
    }

    public class HandTaker: WeaponAccessoriesDecorator
    {
        public HandTaker(IWeapon weapon) : base(weapon)
        {

        }
        public override int Damage()
        {
            return base.Damage();
        }

        public override int Heavy()
        {
            return base.Heavy() + 1;
        }

        public override int Rpm()
        {
            return base.Rpm() + 520;
        }

    }
    public class Silencer : WeaponAccessoriesDecorator
    {

        public Silencer(IWeapon weapon) : base(weapon)
        {
        }
        
        public override int Damage()
        {
            return (base.Damage() + 3);
        }

        public override int Heavy()
        {
            return base.Heavy() + 1;
        }

        public override int Rpm()
        {
            return base.Rpm() + 0;
        }
    }
   
}
