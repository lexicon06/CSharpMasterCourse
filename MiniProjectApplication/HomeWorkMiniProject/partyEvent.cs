﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMiniProject
{
    public class partyEvent
    {
        public static Dictionary<string, int> peopleInvited = new Dictionary<string, int>();
        public static void WelcomeApp()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("Welcome to Party Event Application");
            Console.WriteLine("**********************************");
        }

        internal static bool keepCollecting()
        {
            Console.WriteLine("Is there more to add yes/no");
            bool userInput = Console.ReadLine() == "yes";
            return userInput;
        }


        public static void CollectPeople()
        {
            do
            {
                Console.WriteLine("Who is the family?: ");
                string familyName = Console.ReadLine();
                Console.WriteLine("How many members?: ");
                int familyUsers = 0;
                while (!int.TryParse(Console.ReadLine(), out familyUsers))
                {
                    Console.WriteLine("Please enter a valid number");
                }
                if (peopleInvited.ContainsKey(familyName))
                {
                    Console.WriteLine("Sorry, the family already is in the List");
                }
                else
                {
                    peopleInvited.Add(familyName, familyUsers);
                }
            }
            while (keepCollecting());
        }

        public static void DisplayCollection()
        {
            Console.WriteLine("\n######################");
            Console.WriteLine("#####GUEST LIST#######");
            Console.WriteLine("######################\n");

            int membersCount = peopleInvited.Values.Sum();

            foreach (var person in peopleInvited.Keys)
            {
                Console.WriteLine($"Family: {person} - Members: {peopleInvited[person]}");
            }

            Console.WriteLine($"Total guest: {peopleInvited.Values.Sum()}");

        }
    }
}
