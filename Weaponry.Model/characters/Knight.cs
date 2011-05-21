using Weaponry.Model;

namespace Weaponry.Model
{
    public class Knight : Character
    {
        public Knight()
        {
            this.SetWeapon(new Sword());
        }
    }
}
