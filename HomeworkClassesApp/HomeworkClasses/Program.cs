using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            UserAddress userAddress = new UserAddress();

            string adress, name, input;

            Dictionary<PersonModel, UserAddress> people = new Dictionary<PersonModel, UserAddress>();

            Console.WriteLine("Welcome to class homework app");
            do
            {
                Console.WriteLine("Please enter your name or exit to quit");

                input = Console.ReadLine();

                if (input != "exit")
                {
                    name = input;

                    Console.WriteLine("Please enter your adress");

                    adress = Console.ReadLine();

                    people.Add(new PersonModel { PersonName = name }, new UserAddress { Street = adress });

                }

            }
            while (input != "exit");


            foreach (var p in people)
            {
                Console.WriteLine(p.Key.PersonName + " " + p.Value.Street);
            }


            Console.ReadLine();

        }
    }
}
