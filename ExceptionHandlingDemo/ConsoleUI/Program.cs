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

            try
            {
                BadCall();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry error has ocurred "+ex.Message);
                throw;
            }
            Console.WriteLine("hello from netcore app");
            Console.ReadLine();
        }

        private static void BadCall()
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
                   // Console.WriteLine("Sorry we had an error " + ex.Message);

                    throw new Exception("There was an error handling the array", ex);

                }
            }
        }
    }
}
