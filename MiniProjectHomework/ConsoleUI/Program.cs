using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleUI
{
    public class Program
    {
        //List<GuestModel> guests = new List<GuestModel>(); this will live as long the app is on
        static void Main(string[] args)
        {

            List<GuestModel> guests = new List<GuestModel>();

            GetUserInfo(guests);

            DisplayGuestList(guests);

            Console.ReadLine();
        }

        public static void DisplayGuestList(List<GuestModel> guests)
        {
            if (guests.Count != 0)
            {

                Console.WriteLine("Guest List:");
            }
            else
            {
                Console.WriteLine("Empty list");
            }

            foreach (GuestModel gue in guests)
            {
                Console.WriteLine($"{gue.FirstName} {gue.LastName}, {gue.MessageToHost}");
            }
        }

        public static void GetUserInfo(List<GuestModel> guests)
        {
            string userInput = "";
            do
            {

                userInput = GetUserInput("Please enter a guest family or type 'close' to quit");

                if (userInput.ToLower() != "close")
                {
                    string firstName = userInput;
                    string lastName = GetUserInput("Please enter last name");
                    string msgToHost = GetUserInput("Enter message to host");

                    guests.Add(new GuestModel { FirstName = firstName, LastName = lastName, MessageToHost = msgToHost });

                    Console.WriteLine("Successfully added to the list!");

                }

            } while (userInput.ToLower() != "close");
        }

        private static string GetUserInput(string Message)
        {
            string output = "";
            Console.WriteLine(Message);
            output = Console.ReadLine();
            return output;
        }
    }
}
