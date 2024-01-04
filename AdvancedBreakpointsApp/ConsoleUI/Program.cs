﻿using System;
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
            Console.WriteLine("Advanced Breakpoints app");
            RunsALot();
            Console.ReadLine();
        }

        private static void RunsALot()
        {
            long total = 0;
            int test = 0;
            for (int i = -1000; i < 1000; i++)
            {
                total += i;
                try
                {
                    test = 5 / i;
                }
                catch
                {

                    Console.WriteLine("There was an exception");
                }
            }
            Console.WriteLine($"The total is {test}");
        }
    }
}
