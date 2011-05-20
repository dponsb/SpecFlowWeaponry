using System;

namespace Weaponry.Model
{
    public class SwordBehaviour : WeaponBehaviour
    {
        #region WeaponBehaviour Members

        public void UseWeapon()
        {
            Console.WriteLine("Swish!");
        }

        #endregion
    }
}
