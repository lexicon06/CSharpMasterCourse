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
            //string firstName;
            //string lastName;
            //string emailAddress;

            //string firstName2;
            //string lastName2;
            //string emailAddress2;

            //List<string> firstNames = new List<string>();
            //List<string> lastNames = new List<string>();


            //PersonModel person = new PersonModel();

            //Console.Write("Please enter that name: ");


            //person.firstName = Console.ReadLine();


            //Console.WriteLine($"Hello {person.firstName}");

            //PersonModel person2 = new PersonModel();

            //person2.firstName = "Jacob";

            //Console.WriteLine($"Hello {person2.firstName}");


            //List<PersonModel> peopleGroup = new List<PersonModel>();

            //var guy = new PersonModel();

            //guy.firstName = "Pablo";

            //peopleGroup.Add(guy);


            //guy = new PersonModel();

            //guy.firstName = "Jack";


            //peopleGroup.Add(guy);


            //foreach (var person in peopleGroup)
            //{
            //    Console.WriteLine(person.firstName);
            //}

            //List<PersonModel> list = new List<PersonModel>();

            //list.Add(new PersonModel { FirstName = "Jojo", LastName = "Joestar" });
            //list.Add(new PersonModel { FirstName = "Pablo", LastName = "Santillan" });
            //list.Add(new PersonModel { FirstName = "Freddy", LastName = "Kruger" });
            //list.Add(new PersonModel { FirstName = "Goku", LastName = "Son" });
            //list.Add(new PersonModel { FirstName = "Steve", LastName = "Jobs" });


            //foreach (PersonModel model in list)
            //{
            //    Console.WriteLine(model.FirstName + " " + model.LastName);
            //}


            List<PersonModel> list = new List<PersonModel>();

            string userName, lastName;
            do
            {
                Console.Write("Type a name or exit to terminate: ");
                userName = Console.ReadLine();
                if (userName != "exit")
                {
                    Console.WriteLine("What is your last name?");
                    lastName = Console.ReadLine();
                    list.Add(new PersonModel
                    {
                        FirstName = userName,
                        LastName = lastName,
                    });
                }
            } while (userName != "exit");


            Console.WriteLine($"\nList of people ({list.Count}):\n");

            foreach (PersonModel model in list)
            {
                Console.WriteLine(model.FirstName + " " + model.LastName);
            }


            Console.ReadLine();
        }
    }
}
