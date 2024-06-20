using System;

namespace GameDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create players
            Survivor survivor = new Survivor();
            survivor.Name = "Pablo";
            survivor.Weapon = "Katana";
            survivor.HP = 200;

            Infected infected = new Infected();
            infected.Name = "Tank";
            infected.Weapon = "Claws";
            infected.Power = 20;
            infected.HP = 150;

            // Initialize game
            GamePlay game = new GamePlay();
            game.StartCombat(survivor, infected);

            Console.ReadLine();
        }

        public class Player
        {
            public int HP { get; set; }
            public string Name { get; set; }
            public string Weapon { get; set; }
        }

        public class Survivor : Player
        {
            public string Melee { get; set; }
            public string Armor { get; set; }
        }

        public class Infected : Player
        {
            public int Power { get; set; }
        }

        public class GamePlay
        {
            public void StartCombat(Player player1, Player player2)
            {
                bool player1Turn = true;

                while (player1.HP > 0 && player2.HP > 0)
                {
                    if (player1Turn)
                    {
                        Console.WriteLine($"{player1.Name}'s turn!");
                        Attack(player1, player2);
                    }
                    else
                    {
                        Console.WriteLine($"{player2.Name}'s turn!");
                        Attack(player2, player1);
                    }

                    player1Turn = !player1Turn;
                }

                if (player1.HP > 0)
                    Console.WriteLine($"Player {player2.Name} has been defeated!");
                else
                    Console.WriteLine($"Player {player1.Name} has been defeated!");
            }

            private void Attack(Player attacker, Player target)
            {
                int damage = attacker is Survivor ? 10 : 15; // Adjust damage based on player type
                target.HP -= damage;
                Console.WriteLine($"{attacker.Name} attacks {target.Name} for {damage} damage. {target.Name} HP: {target.HP}");
                Console.ReadLine();
            }
        }
    }
}
