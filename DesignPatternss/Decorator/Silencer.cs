namespace Decorator
{
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
