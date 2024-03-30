using System;

namespace ExtensionMethodsOwn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello extension methods");
            ATMBankModel model = new ATMBankModel();
            model.PersonFirstName = "Please enter your first name".GetString();
            model.PersonLastName = "Please enter your last name".GetString();

            model.Deposit(50.55M);

            model.AccBalanceTicket();

            model.WithDraw(20.55M);

            model.AccBalanceTicket();

            Console.WriteLine();
        }
    }
}
