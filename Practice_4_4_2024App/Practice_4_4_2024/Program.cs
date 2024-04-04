using System;

namespace Practice_4_4_2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameUI.Intro();
            GameUI.Play = true;
            GameLogic game = new GameLogic();
            game.Start();
            Console.ReadLine();
        }
    }

public class GameUI
{
    public static bool Play;

    public static string[] Choices = { "rock", "paper", "scissors" };
    public static void Intro()
    {
        Console.WriteLine("Welcome to Rock Paper and Scissors Game");
    }
}

    public class GameLogic
    {
        public void Start()
        {
            while (GameUI.Play)
            {
                Console.WriteLine("Make your guess:");
                Console.WriteLine("1: Rock");
                Console.WriteLine("2: Paper");
                Console.WriteLine("3: Scissors");

                int select;
                string input = Console.ReadLine();
                while (!int.TryParse(input, out select) || select < 1 || select > 3)
                {
                    Console.WriteLine("Please select a valid option (1, 2, or 3)");
                    input = Console.ReadLine();
                }

                Random rnd = new Random();
                int cpuChoice = rnd.Next(0, 3);
                int usrChoice = select - 1;


                (bool p1, bool p2) isWinner = (PlayerWon(usrChoice, cpuChoice), PlayerWon(cpuChoice, usrChoice));

                string computerChoice = GameUI.Choices[cpuChoice];
                string userChoice = GameUI.Choices[usrChoice];

                if (isWinner.p1)
                {
                    Console.WriteLine($"User wins! CPU says {computerChoice}. You chose {userChoice}.");
                }
                else if (isWinner.p2)
                {
                    Console.WriteLine($"CPU wins! CPU says {computerChoice}. You chose {userChoice}.");
                }
                else
                {
                    Console.WriteLine($"It's a tie! Both chose {userChoice}.");
                }
            }
        }

        static bool PlayerWon(int playerChoice, int victimChoice)
        {
            return (playerChoice == 0 && victimChoice == 2) ||
                   (playerChoice == 1 && victimChoice == 0) ||
                   (playerChoice == 2 && victimChoice == 1);
        }
    }
}
