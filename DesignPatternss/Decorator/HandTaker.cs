namespace Decorator
{
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
   
}
