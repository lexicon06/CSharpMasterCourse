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

            string userName = UserMessages.GetUserName("What is your name?: ");
            UserMessages.Welcome(userName);
            Console.Write("Please enter your number: ");
            double exitDouble = RequestData.GetDoubles(Console.ReadLine());

            Console.WriteLine($"Got it: {exitDouble}");
            Console.ReadLine();
        }

        private static void IntroMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
