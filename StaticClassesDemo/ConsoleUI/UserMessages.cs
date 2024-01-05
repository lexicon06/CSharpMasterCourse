using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class UserMessages
    {
        public static void Welcome(string userName)
        {

            Console.Clear();

            int time = DateTime.Now.Hour;

            if (time < 12)
            {
                GoodMorning(userName);
            }
            else if (time < 19)
            {
                GoodAfternoon(userName);
            }
            else
            {
                GoodEvening(userName);
            }

        }
        internal static void GoodMorning(string userName)
        {
            Console.WriteLine($"Good morning {userName}");
        }
        internal static void GoodEvening(string userName)
        {
            Console.WriteLine($"Good evening {userName}");
        }

        internal static void GoodAfternoon(string userName)
        {
            Console.WriteLine($"Good afternoon {userName}");
        }

        public static string GetUserName(string msgWelcome)
        {

            Console.Write(msgWelcome);

            string name = Console.ReadLine();

            while (name == "")
            {

                Console.Write("Please enter a valid name: ");
                name = Console.ReadLine();
            }

            return name;
        }
    }
}
