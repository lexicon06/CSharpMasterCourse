using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMethodOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Name = "Will";
            PersonBase p2 = new PersonBase();
            p2.Name = "Richard";

            p1.Cook();
            p2.Cook();

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Cook()
        {
            Console.WriteLine($"{Name} makes pasta");
        }
    }

    public class PersonBase : Person
    {
        public override void Cook()
        {
            //base.Cook();

            Console.WriteLine($"{Name} makes salad");
        }
    }
}
