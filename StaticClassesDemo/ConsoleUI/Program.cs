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
            IntroMessage("#####ClassAPP####");
            Console.Write("What is your name: ");
            string userName = Console.ReadLine();
            UserMessages.Welcome(userName);
            Console.ReadLine();
        }

        private static void IntroMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
