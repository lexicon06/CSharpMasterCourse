using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PersonModel dev = new PersonModel("Fox");

            dev.Stack = "JS, PHP, C#, NODEJS, REACT";

            dev.Name = "Pablo";

            dev.Bio = "A passionate programmer who likes code, music, games and i love my gf";

            Console.WriteLine($"Great {dev.Name}");
            Console.WriteLine($"{dev.Stack}, great tech stack");
            Console.WriteLine($"{dev.Bio}, good work!");

            Console.ReadLine();


        }
    }
}
