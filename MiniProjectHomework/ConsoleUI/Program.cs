﻿using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<GuestModel> guests = new List<GuestModel>();
            string userInput = "";
            do
            {
                Console.WriteLine("Please enter a guest family or type 'close' to quit");
                userInput = Console.ReadLine();

                if (userInput.ToLower() != "close")
                {
                    string firstName = userInput;
                    Console.WriteLine("Please enter last name");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter message to host");
                    string msgToHost = Console.ReadLine();

                    guests.Add(new GuestModel { FirstName = firstName, LastName = lastName, MessageToHost = msgToHost });

                    Console.WriteLine("Successfully added to the list!");

                }

            } while (userInput.ToLower() != "close");

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

            Console.ReadLine();
        }
    }
}
