using System;

namespace Weaponry.Model
{
    public class Hammer : WeaponBehaviour
    {
        #region WeaponBehaviour Members

        public void UseWeapon()
        {
            Console.WriteLine("Bash!");
        }

        #endregion
    }
}
