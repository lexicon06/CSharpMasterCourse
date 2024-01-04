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
            string userName = String.Empty;
            Console.WriteLine("Error Handling Advanced App\n");
            try
            {
                Console.WriteLine("What is your Name?");
                userName = Console.ReadLine();
                ComplexMethod(userName);
                DifferentMethod();
                SimpleMethod();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("You're not the boss");
                Console.WriteLine(ex.Message);
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("You forgot to finish your code");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("You shouldn't be doing this");
                Console.WriteLine(ex.Message);
            }
            //catch (NotImplementedException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (Exception ex) when (userName == String.Empty)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Got here");//i always run

                //useful to close a db or delete close imgs or any handle that needs to be closed
            }
            Console.ReadLine();
        }


        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling this method");
        }

        private static void DifferentMethod()
        {
            throw new NotImplementedException("This is not implemented");
        }

        private static void ComplexMethod(string name)
        {
            if (name.ToLower() == "fox")
            {
                Console.WriteLine("Welcome on board Pablo");
            }
            else
            {
                throw new ArgumentException("The argumment is not the expected");
            }
        }
    }
}
