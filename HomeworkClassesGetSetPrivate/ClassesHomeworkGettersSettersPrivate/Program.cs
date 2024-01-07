using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomeworkGettersSettersPrivate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to homework app classes, getters, setters, private, full props");

            Console.WriteLine("");

            try
            {
                AddressModel Location = new AddressModel("Github 123123") { City = "Mar de Plata", State = "Buenos Aires", ZipCode = 7600 };

                Console.WriteLine($"Living in {Location.FullAddress}, City {Location.City}, {Location.State}, ZipCode: {Location.ZipCode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }
    }
}
