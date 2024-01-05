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
            double firstDouble = RequestData.GetDoubles(Console.ReadLine());

            Console.Write("Please enter another number: ");
            double secondDouble = RequestData.GetDoubles(Console.ReadLine());

            double totalDouble = CalculateData.Calc(firstDouble, secondDouble);

            Console.WriteLine($"The sum of: {firstDouble} & {secondDouble} is equal to {totalDouble}");
            Console.ReadLine();
        }

        private static void IntroMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
