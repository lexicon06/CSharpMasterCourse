

/*

bool isComplete = true;

if (isComplete)
{
    Console.WriteLine($"Statement is {isComplete}");
}
else
{
    Console.WriteLine($"Statement is {isComplete}");
}

Console.WriteLine("The program has been completed");
*/



Console.WriteLine("Please enter your name:");


string? userName = Console.ReadLine();

while (userName == null || userName == String.Empty)
{
    Console.WriteLine("Please enter a valid name:");
    userName = Console.ReadLine();
}

if (userName.ToLower() == "fox")
{
    Console.WriteLine("Hello Pablo");
}
else
{
    Console.WriteLine("Hello User");
}


/*
switch (userName)
{
    case "Fox":
        {
            Console.WriteLine("Hello Pablo");
        }

        break;


    default:
        {
            Console.WriteLine("Hello User");
        }

        break;
}
*/

