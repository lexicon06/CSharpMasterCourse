using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomePlayers();

            do
            {
                try
                {
                    string Spot = SpotInput("Please enter your spot");
                    Console.WriteLine($"You just have entered {Spot}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (WannaPlay());
            Console.ReadLine();
        }

        public static string SpotInput(string inputMsg)
        {
            Console.WriteLine(inputMsg);
            string output = Console.ReadLine();

            if (output.Length != 2)
            {
                throw new ArgumentException("Invalid input, make sure you enter a valid position such as b2");
            }
            else if (!char.IsLetter(output[0]) || !char.IsDigit(output[1]))
            {
                throw new ArgumentException("Invalid position, make sure your pos is correct");
            }

            return output;
        }

        private static void WelcomePlayers()
        {
            Console.WriteLine("Battleship game v1.0 Console Game");
        }

        private static void DisplayGrid()
        {
            //grid here
        }

        private static bool WannaPlay()
        {
            Console.WriteLine("Wanna play? yes/no");
            return Console.ReadLine().ToLower() == "yes";
        }
    }
}
