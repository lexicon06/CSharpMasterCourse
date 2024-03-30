using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PersonModel person = new PersonModel();
            person.FirstName = "Enter your first name: ".GetString();
            person.LastName = "Please enter your last name: ".GetString();
            $"Welcome home {person.FirstName} {person.LastName}".Print();
            person.Age = "Please enter your age: ".GetInt();
            Console.ReadLine();
        }
       
    }
}
