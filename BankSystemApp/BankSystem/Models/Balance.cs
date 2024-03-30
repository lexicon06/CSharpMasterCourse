using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    public class Balance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static double Money { get; set; } = 25;

        public Balance(int ID = 0, string name = "", string desc = "")
        {
            Id = ID;
            Name = name;
            Description = desc;
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"acc balance is {Money}");
        }

        public void UpdateBalance(double cash)
        {
            Money += cash;
            Console.WriteLine($"acc balance is now {Money}");
        }

        public void About()
        {
            Console.WriteLine($"About {Name} - {Description}");
        }

        public void WithDraw(double cash)
        {
            Console.WriteLine($"Withdraw {cash}");
            if (Money >= cash) {
                Money -= cash;
                if (cash == Money)
                {
                    Console.WriteLine("Success withdraw all founds!!!");
                }
                else
                {
                    Console.WriteLine($"Withdraw succcessfully ${cash} balance is now {Money}");
                }
            }
            else 
            {
                Console.WriteLine($"Sorry cannot continue, you have ${Money}");
            }
        }
    }
}
