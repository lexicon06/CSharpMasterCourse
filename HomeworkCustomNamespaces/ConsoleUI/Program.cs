using ConsoleUI.Models;
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
            UserModel person = new UserModel();
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            person.UserName = userName;
            int userAge;
            do
            {
                Console.WriteLine("Please enter your age");
            }
            while (!int.TryParse(Console.ReadLine(), out userAge));

            Console.WriteLine("Please enter your password");
            try
            {
                string userPassword = Console.ReadLine();
                person.Password = userPassword;
                person.GreetUser();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

            Console.ReadLine();
        }
    }
}
