using System;

namespace Weaponry.Model
{
    public class AxeBehaviour : WeaponBehaviour
    {
        #region WeaponBehaviour Members

        public void UseWeapon()
        {
            Console.WriteLine("Chop!");
        }

        #endregion
    }
}
