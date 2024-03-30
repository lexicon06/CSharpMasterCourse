using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Models;

namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();
 
            Balance bank = new Balance(ID: 3, name: userName, desc: "A senior programmer");
            bank.DisplayBalance();
            Console.WriteLine();
            bank.UpdateBalance(5.99);
            bank.About();
            bank.WithDraw(80.5);
            Console.ReadLine();
        }
    }
}
