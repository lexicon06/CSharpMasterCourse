using System;

namespace ExtensionMethodsOwn
{
    public static class ConsoleHelper
    {
        public static string GetString(this string msg)
        {
            Console.WriteLine(msg);
            string output = Console.ReadLine();
            return output;
        }

        public static ATMBankModel AccBalanceTicket(this ATMBankModel p)
        {
            Console.WriteLine($"Current balance is {p.Balance:C}");
            Console.ReadLine();
            return p;
        }
    }
}
