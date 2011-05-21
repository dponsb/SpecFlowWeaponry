
namespace Weaponry.Model
{
    public abstract class Character
    {
        private WeaponBehaviour _weapon;

        public WeaponBehaviour CurrentWeapon
        {
            get
            {
                return _weapon;
            }
        }

        public void fight()
        {
            _weapon.UseWeapon();
        }

        public void SetWeapon(WeaponBehaviour weapon)
        {
            _weapon = weapon;
        }
    }
}
