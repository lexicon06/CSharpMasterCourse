using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class mathShortcuts
    {
        public static void Add(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine($"The value of x + y is equals = {sum}");
        }

        public static void addAll(double[] values)
        {
            double result = 0;

            foreach (double value in values)
            {
                result += value;
            }

            Console.WriteLine($"The result of adding all is {result}");
        }

        public static string GetUsersName()
        {

            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            return name;
        }
    }
}
