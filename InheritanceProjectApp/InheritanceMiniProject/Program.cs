using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IRentalble> rentables = new List<IRentalble>();
            List<IPurchasable> purchasables = new List<IPurchasable>();




            var vehicle = new VehiculeModel { DealerFee = 25, ProductName = "Kia Optima" };
            var book = new BookModel { ProductName = "Harry Potter", NumberOfPages = 1 };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };


            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(book);
            purchasables.Add(vehicle);


            Console.Write($"Do you want to rent or purchase something? (rent, purchase)");

            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"{item.ProductName}");
                    Console.WriteLine($"Do you want to rent this item? (yes/no)");

                    string pick = Console.ReadLine();

                    if (pick.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.WriteLine($"{item.ProductName}");
                    Console.WriteLine($"Do you want to return this item? (yes/no)");

                    pick = Console.ReadLine();

                    if (pick.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }

            }
            else if (rentalDecision.ToLower() == "purchase")
            {

                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item {item.ProductName}");
                    Console.WriteLine($"Do you want to purchase this product?");

                    string purchase = Console.ReadLine().ToLower();

                    if (purchase == "yes")
                    {
                        item.Purchase();
                    }

                }

            }


            Console.WriteLine("We are done.");

            Console.ReadLine();
        }
    }
}
