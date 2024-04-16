using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKeys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("F");
            Console.WriteLine("Please enter a key:");
            var keyPressed = Console.ReadKey(true);
            Console.WriteLine($"You have pressed {keyPressed.Key}");
            Console.ReadLine();
        }
    }
}
