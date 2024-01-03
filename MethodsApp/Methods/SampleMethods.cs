using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Methods
//{
//    internal static class SampleMethods
//    {
//        internal static void Main(string[] args)
//        {
//            Console.WriteLine("Hello buddy");
//        }
//    }
//}   the universal way in earlier versions





namespace Methods
{
    public static class ConsoleGreeting
    {
        public static void SayHi(string name)
        {
            Console.WriteLine($"Hi {name}");
        }

        public static void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}");
        }
    }
}