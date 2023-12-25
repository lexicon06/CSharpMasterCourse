
Console.WriteLine("---------------------------");
Console.WriteLine("Welcome Application C#");
Console.WriteLine("Created by Pablo Santillan");
Console.WriteLine("---------------------------");
Console.WriteLine("Please enter your first name:");

string? firstName = Console.ReadLine();
while (firstName == null || firstName == "" || firstName.Contains(" "))
{
    Console.WriteLine("Error occured please enter your name:");
    firstName = Console.ReadLine();
}
Console.WriteLine("\nExcellent!\n");
Console.WriteLine($"Welcome to C# {firstName}");