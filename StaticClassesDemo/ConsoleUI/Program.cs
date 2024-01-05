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

            string[] operationNames = new string[] { "Sum@+", "Subtraction@-", "Multiply@*", "Division@/" };

            string userName = UserMessages.GetUserName("What is your name?: ");
            UserMessages.Welcome(userName);



            int option = 0;

            double doubleOne, doubleTwo, total;

            do
            {
                Console.WriteLine("\n##############################\n");
                Console.WriteLine("Please select math operation:\n");
                Console.WriteLine("1: Add");
                Console.WriteLine("2: Subtract");
                Console.WriteLine("3: Multiply");
                Console.WriteLine("4: Divide");
                Console.WriteLine("\n##############################\n");

            } while (!int.TryParse(Console.ReadLine(), out option));



            string mathOperation = operationNames[option - 1].Split('@')[0];
            string mathSign = operationNames[option - 1].Split('@')[1];


            Console.WriteLine(mathOperation.ToUpper());

            Console.Write("Enter a Number: ");

            doubleOne = RequestData.GetDoubles(Console.ReadLine());

            Console.Write("Please enter another number: ");

            doubleTwo = RequestData.GetDoubles(Console.ReadLine());


            total = calcMethodMath(option, doubleOne, doubleTwo);


            Console.WriteLine($"The {mathOperation} of: {doubleOne} {mathSign} {doubleTwo} = {total}");

            Console.ReadLine();

        }

        //private static void IntroMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}

        internal static double calcMethodMath(int option, double doubleOne, double doubleTwo)
        {
            if (option == 1)
                return CalculateData.Addition(doubleOne, doubleTwo);
            else if (option == 2)
                return CalculateData.Subtract(doubleOne, doubleTwo);
            else if (option == 3)
                return CalculateData.Multiply(doubleOne, doubleTwo);

            return CalculateData.Division(doubleOne, doubleTwo);
        }
    }
}
