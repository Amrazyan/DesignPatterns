namespace Decorator
{
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
   
}
