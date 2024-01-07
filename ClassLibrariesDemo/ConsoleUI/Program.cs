using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            person.FirstName = "Test";
            person.LastName = "Test2";
            Console.WriteLine($"Hello {person.FirstName}");
            Console.ReadLine();
        }
    }
}
