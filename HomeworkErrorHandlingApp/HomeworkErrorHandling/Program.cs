using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Error handling App Demo");

            try
            {
                Bug();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Bug() ", ex);
            }



            Console.ReadLine();

            return;
        }


        private static void Bug()
        {
            int[] arr = new int[5];//empty arr

            for (int i = 0; i <= arr.Length; i++)
            {
                try
                {
                    Console.WriteLine(arr[i]);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong " + ex.Message);
                    throw new Exception("There was an error handling the array", ex);

                }
            }
        }
    }
}
