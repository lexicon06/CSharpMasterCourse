using System;

namespace HeroGame
{
    public class Character
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public Weapon Wpn { get; set; }

        public Character(string name, int health, Weapon weapon)
        {
            Name = name;
            HP = health;
            Wpn = weapon;
        }

        public void Attack(Character target)
        {
            target.HP -= Wpn.Damage;
            target.HP = Math.Max(target.HP, 0);
            Console.WriteLine($"Character {Name} dealt {Wpn.Damage} damage to {target.Name} with {Wpn.Name}");
            CheckHealth();
        }

        public void CheckHealth()
        {
            if(HP == 0)
            {
                Console.WriteLine($"Player {Name} is dead, Game Over");
                Console.Read();
                Environment.Exit(0);
            }
        }
    }


    public class Hero : Character
    {
        public Hero(string name, int health, Weapon weapon) : base(name, health, weapon)
        {
        }

        Weapon defaultwpn = Weapon.fists;

        public void Equip(Weapon wpn)
        {
            Wpn = wpn;

            Console.WriteLine($"{Name} is now equiped with {Wpn.Name}");
        }

        public void Drop()
        {
            Console.WriteLine($"{Name} just dropped the weapon {Wpn.Name}");
            Wpn = defaultwpn;
            Console.WriteLine($"{Name} Now you have {Wpn.Name}");
        }
    }

    public class Enemy : Character
    {
        public Enemy(string name, int health, Weapon weapon) : base(name, health, weapon)
        {
        }
    }


}


