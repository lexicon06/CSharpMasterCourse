using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMethods
{
    public class ConsoleHomeworkMethod
    {
        public static string userWelcome()
        {
            string userName = String.Empty;

            do
            {
                Console.WriteLine("Hello, please enter your name");

                userName = Console.ReadLine();
            }
            while (userName == String.Empty);

            return userName;
        }

        public static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
