using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMiniProject
{
    public class partyEvent
    {
        public static int totalGuest = 0;
        public static (string, int) GuestBook()
        {
            Console.WriteLine("Please enter your guest name");
            string guestName = Console.ReadLine();

            int guestFamily = 0;

            Console.WriteLine("Enter how many for this family:");

            while (!int.TryParse(Console.ReadLine(), out guestFamily) || guestFamily == 0)
            {
                Console.WriteLine("Please enter a valid number of members");
            }

            return (guestName, guestFamily);
        }

        public static int guestList(string familyName, int howMany)
        {
            totalGuest += howMany;

            Console.WriteLine($"Family: {familyName} | Members: {howMany}");

            return totalGuest;
        }


        public static void resetList()
        {
            totalGuest = 0;
        }
    }
}
