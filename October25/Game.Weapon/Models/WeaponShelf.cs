using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Weapon.Models
{
    public class WeaponShelf
    {
        public Weapon[] Weapons = new Weapon[0];

        public WeaponShelf(Weapon[] weapons)
        {
            Weapons = weapons;
        }


        public void AddWeapon(Weapon weapon)
        {
            Array.Resize(ref Weapons, Weapons.Length + 1);
            Weapons[Weapons.Length - 1] = weapon;
        }

        public void PrintWeapons()
        {
            for (int i = 0; i < Weapons.Length; i++)
            {
                Console.WriteLine($"{i} => {Weapons[i].GetFullInfo()} \n");
            }
        }

        public SearchResult GetWeapon(int index)
        {
            if (index >= Weapons.Length || index < 0)
            {
                Console.WriteLine("Invalid Weapon Index");
                return new SearchResult { IsValidSearch = false };
            }
            return new SearchResult { Weapon = Weapons[index], IsValidSearch = true };
        }
    }
}
