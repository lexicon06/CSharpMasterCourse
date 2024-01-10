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
            try
            {
                string Spot = SpotInput("Please enter your spot");
                Console.WriteLine($"You just have entered {Spot}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            else if (!int.TryParse(output.Substring(1), out int gridPosX) || !char.TryParse(output.Substring(0, 1), out char gridPosY))
            {
                throw new ArgumentException("Invalid position, make sure your pos is correct");
            }

            return output;
        }

        public static void DisplayGrid()
        {
            //grid here
        }
    }
}
