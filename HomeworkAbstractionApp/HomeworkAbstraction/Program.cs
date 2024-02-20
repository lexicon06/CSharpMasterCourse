using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAbstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            Tesla _tesla = new Tesla();

            Console.WriteLine(_tesla.Model); 
            Console.WriteLine(_tesla.Name);

            TeslaItem _teslaItem = new TeslaItem();

            Console.WriteLine(_teslaItem.Year);

            Console.ReadLine();
        }
    }

    public abstract class Inventory
    {
        string ProductType { get; set; }
        int PartNumber { get; set; }
    }

    public interface ICar
    {
        string Name { get; set; }
        string Model { get; set; }
        int Chasis_SN { get; set; }

    }

    public class Tesla : ICar
    {
        public string Name { get; set; } = "Electric Tesla";
        public string Model { get; set; } = "3401 Modulus";
        public int Chasis_SN { get; set; } = 240652;
        public string ProductType { get; set; }
        public int PartNumber { get; set; }
    }

    public class TeslaItem : Inventory
    {
        public int Year { get; set; } = 2024;
    }
}



