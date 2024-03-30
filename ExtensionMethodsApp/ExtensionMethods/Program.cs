using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.SetDefaultAge().PrintInfo();

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string PersonName { get; set; }
        public int PersonAge { get; set; }
    }


    public static class PersonHandler {
        public static Person SetDefaultAge(this Person p)
        {
            p.PersonAge = 31;
            return p;
        }


        public static Person PrintInfo(this Person p)
        {
            Console.WriteLine($"The person has {p.PersonAge} yo");

            return p;
        }
    }

}
