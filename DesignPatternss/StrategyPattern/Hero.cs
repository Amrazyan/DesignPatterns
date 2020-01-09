namespace StrategyPattern
{
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
