using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees ppl = new Employees();

            Console.ReadLine();
        }
    }

    public class Employees
    {
        private int EmployeeAge { get; set; }
        private int EmployeeID { get; set; }
        private string EmployeeName { get; set; }
        public Employees()
        {
            int age;
            Console.WriteLine("please enter your age");
            if (int.TryParse(Console.ReadLine(), out age))
            {

                EmployeeAge = age;

            }else
            {
                EmployeeAge = 0;
            }



            Console.WriteLine($"Employee is {EmployeeAge} yo");

        }

        public Employees(int age)
        {
            EmployeeAge = age;
            Console.WriteLine($"Employee is {EmployeeAge} yo");
        }
    }
}
