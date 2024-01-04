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
            int[] ages = new int[] { 1, 4, 5 };
            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sorry we had an error " + ex.Message);
                }
            }
            Console.WriteLine("hello from netcore app");
            Console.ReadLine();
        }
    }
}
