using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero(name: "Hero", health: 100, weapon: Weapon.fists);

            Enemy enemy = new Enemy(name: "Enemy", health: 100, weapon: Weapon.shortBow);

            while (true)
            {
                hero.Attack(enemy);
                enemy.Attack(hero);

                Console.WriteLine($"Health of {hero.Name}: {hero.HP}");
                Console.WriteLine($"Health of {enemy.Name}: {enemy.HP}");

                if (hero.Wpn != Weapon.ironSword)
                {
                    hero.Equip(Weapon.ironSword);
                }
                else
                {
                    hero.Drop();
                }

                Console.ReadLine();
            }
        }
    }

}


