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
            int i = W(0);
            Console.WriteLine(i);
            Console.ReadLine();
        }

        private static int W(int e)
        {
            int n = 1;
            n = J(e) + 4;
            return n;
        }

        private static int P(int y)
        {
            int o = 0;
            o = F(y) + 2;
            return 0;
        }

        private static int F(int x)
        {
            int y = 0;
            y = x / 5;
            return y;
        }

        private static int J(int a)
        {
            int c = 0;
            a = a - 1;
            c = R(a);
            c = P(c) / 3;
            return c;
        }

        private static int R(int v)
        {
            int z = 5;
            z = 3 / v;
            return v;
        }
    }
}
