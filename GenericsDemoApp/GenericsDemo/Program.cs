using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Welcome to my game");

            List<int> vals = new List<int> { 1, 2, 3, 4, 5, 6 };

            foreach (int val in vals)
            {
                Console.WriteLine(val);
            }

            Player p1 = new Player();

            Console.WriteLine("P1 Please enter your name");

            p1.Name = Console.ReadLine();

            Player p2 = new Player();

            Console.WriteLine("P2 Please enter your name");

            p2.Name = Console.ReadLine();


            GameLogic game = new GameLogic();

            game.Play(p1, p2);




            Console.WriteLine();
        }

        public static void SayHi()
        {
            Console.WriteLine("hello");
        }
    }

    public class GameLogic
    {
        public bool move { get; set; } = true;
        public static bool gameOver { get; set; } = false;
        public void Play(Player p1, Player p2)
        {
            while (gameOver == false)
            {
                if (move)
                {
                    Console.WriteLine($"P1 {p1.Name} - HP \U0001f7e2 {p1.HP}");
                    Console.WriteLine($"@Player 1 make your movement");
                    Console.WriteLine($"current victim hp = 💊{p2.HP}");
                    p2.Hit(2);
                    Console.ReadLine();
                    move = !move;
                }
                else
                {
                    Console.WriteLine($"P2 {p2.Name} - HP \U0001f7e2 {p2.HP}");
                    Console.WriteLine($"@Player 2 make your movement");
                    Console.WriteLine($"current victim hp = 💊{p1.HP}");
                    p1.Hit(2);
                    Console.ReadLine();
                    move = !move;
                }
            }
        }
    }


    public class Player
    {
        public string Name { get; set; }

        public int HP { get; set; } = 100;

        public int Speed { get; set; } = 10;

        public void Hit(int damage = 1)
        {
            HP -= damage;

            if (HP <= 0)
            {
                Console.WriteLine($"Game over, you won");
                GameLogic.gameOver = true;
            }

        }

        public void Heal()
        {
            HP += 1;
        }
    }
}
