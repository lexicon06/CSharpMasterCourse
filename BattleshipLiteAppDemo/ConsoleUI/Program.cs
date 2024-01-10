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
            bool PlayIt = WannaPlay();

            if (PlayIt)
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
            }
            else
            {
                Console.WriteLine("Goodbye.");
            }
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
            else if (!int.TryParse(output.Substring(1), out int _) || 
                !char.TryParse(output.Substring(0, 1), out _) ||
                int.TryParse(output.Substring(0,1), out _))
            {
                throw new ArgumentException("Invalid position, make sure your pos is correct");
            }

            return output;
        }

        public static void DisplayGrid()
        {
            //grid here
        }

        public static bool WannaPlay()
        {
            Console.WriteLine("Welcome to BattleShip game wanna play? yes/no");
            return Console.ReadLine().ToLower() == "yes";
        }
    }
}
