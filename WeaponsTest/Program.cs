using System;
using Weaponry.Model;

namespace WeaponsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.fight();

            knight.SetWeapon(new Hammer());
            knight.fight();

            Console.ReadLine();
        }
    }
}
