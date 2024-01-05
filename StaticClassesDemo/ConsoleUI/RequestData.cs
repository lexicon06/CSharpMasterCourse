using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class RequestData
    {
        public static double GetDoubles(string message)
        {

            double finalDouble;

            while (!double.TryParse(message, out finalDouble))
            {
                Console.WriteLine("Please enter a valid number");
                message = Console.ReadLine();
            }

            return finalDouble;
        }
    }
}
