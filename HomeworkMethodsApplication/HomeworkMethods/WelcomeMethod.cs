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
            Console.WriteLine("Hello, please enter your name");

            string userName = Console.ReadLine();

            return userName;
        }

        public static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
