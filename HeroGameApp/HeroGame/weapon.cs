using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{
    public class Weapon
    {
        public string Name { get; set; }
        public string WeaponType { get; set; }

        public int Damage { get; set; }

        public int Value { get; set; }

        public Weapon(string name, string weapontype, int damage, int value)
        {
            Name = name;
            WeaponType = weapontype;
            Damage = damage;
            Value = value;
            
        }

        public static Weapon ironSword = new Weapon(name: "Iron Sword", weapontype: "Sharp", damage: 5, value: 10);
        public static Weapon shortBow = new Weapon(name: "Short Bow", weapontype: "Ranged", damage: 4, value: 8);
        public static Weapon fists = new Weapon( name: "Fists", weapontype: "Blunt", damage: 2, value: 0);

    }

    

}
