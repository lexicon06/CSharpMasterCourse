using System;

namespace ExtensionMethods
{
    public static class ConsoleHelper
    {
        public static string GetString(this string str)
        {
            Console.Write(str);
            string output = Console.ReadLine();

            return output;
        }

        public static void Print(this string WelcomeMsg)
        {
            Console.WriteLine(WelcomeMsg);
        }


        public static int GetInt(this string msg)
        {
            

            bool isValid = false;
            int age = 0;

            while(isValid == false)
            {
                Console.Write(msg);
                isValid = int.TryParse(Console.ReadLine(), out age);
               
            }

            
            return age;
        }
    }
}
