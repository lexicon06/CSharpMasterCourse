

using System.Globalization;

float version = 1.0f;

bool isProfessor = false;

string versionString = version.ToString("N1", CultureInfo.InvariantCulture);


Console.WriteLine($"Console HOMEWORK application v{versionString} for the course");

Console.WriteLine("Please enter your name:");

string? userName = Console.ReadLine();


while (userName == null || userName == "")
{
    Console.WriteLine("Please enter a valid name");
    userName = Console.ReadLine();
}

Console.WriteLine("Please enter your age:");

int userAge;

while (!int.TryParse(Console.ReadLine(), out userAge))
{
    Console.WriteLine("Please enter a valid Age");
}

if (userName.ToLower() == "bob" || userName.ToLower() == "sue")
{
    Console.WriteLine($"Welcome professor {userName}");
    isProfessor = true;
}

else
{
    Console.WriteLine($"Welcome user {userName}!");
}


switch (userAge)
{
    case < 21:
        Console.WriteLine($"Sorry {userName} we apologize, but it's recommended that you have at least 21yo, to participate in this class.");
        break;
    default:
        if (!isProfessor) { Console.WriteLine($"It's time for your class {userName}."); }
        else
        {
            Console.WriteLine($"Let's go professor {userName}.");
        }
        break;
}



