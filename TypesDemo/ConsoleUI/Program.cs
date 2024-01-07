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
            Console.WriteLine("Welcome to class app");

            Console.WriteLine("Please enter your name");

            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your SSN");

            string SocialNumber = Console.ReadLine();

            try
            {
                PersonModel person = new PersonModel { FirstName = name, Age = age, SSN = SocialNumber };

                Console.WriteLine($"Name: {person.FullName}, Age: {person.Age}, SSN {person.SSN}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
