using HomeWorkMiniProject;


partyEvent.WelcomeApp();
partyEvent.CollectPeople();
partyEvent.DisplayCollection();





//Dictionary<string, int> guestMembers = new Dictionary<string, int>();
//int total = 0;

//bool loopContinue = true;
//do
//{
//    Console.WriteLine("Continue true or false?");
//    while (!bool.TryParse(Console.ReadLine(), out loopContinue))
//    {
//        Console.WriteLine("Please enter a valid boolean value");
//    }

//    Console.WriteLine($"Great, your statement is {loopContinue}");

//    if (!loopContinue) return;


//    {
//        (string userName, int members) = partyEvent.GuestBook();

//        if (!guestMembers.ContainsKey(userName))
//            guestMembers.Add(userName, members);
//        else Console.WriteLine($"Sorry, but {userName} already exists");


//        Console.WriteLine("Press the 'Esc' key to display results, 'Enter' to continue, to clear list 'SPACE'.");

//        if (Console.ReadKey(true).Key == ConsoleKey.Escape && guestMembers.Count > 0)
//        {
//            Console.WriteLine("########################");
//            Console.WriteLine("MEMBERS LIST");
//            Console.WriteLine("########################\n");
//            foreach (var member in guestMembers.Keys)
//            {
//                total = partyEvent.guestList(member, guestMembers[member]);
//                //Console.WriteLine($"{member}, {guestMembers[member]}");
//            }

//            partyEvent.resetList();

//            Console.WriteLine("");

//            Console.WriteLine($"Members: {total}");
//            total = 0;


//        }

//        if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
//        {
//            guestMembers.Clear();
//            total = 0;
//            Console.WriteLine("The guest list has been cleared succesfully!");
//        }


//    }
//}
//while (loopContinue);