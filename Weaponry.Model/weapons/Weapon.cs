
using System;
namespace Weaponry.Model
{
    public abstract class Weapon : WeaponBehaviour
    {
        public string Effect { get;  protected set; }

        #region WeaponBehaviour Members

        public void UseWeapon()
        {
            Console.WriteLine(Effect);
        }

        #endregion
    }
}
