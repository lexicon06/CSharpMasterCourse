

Console.WriteLine("What's your name?");
string? firstName = Console.ReadLine();
Console.WriteLine("What's your last name?");
string? lastName = Console.ReadLine();


if (firstName?.ToLower() == "pablo" && lastName?.ToLower() == "santillan")
{
    Console.WriteLine("----------------------------");
    Console.WriteLine($"Hello Mr.{lastName}");
    Console.WriteLine("----------------------------");
}
else if (firstName?.ToLower() == "pablo" || lastName?.ToLower() == "santillan")
{

    Console.WriteLine("----------------------------");
    Console.WriteLine($"Hello Fox");
    Console.WriteLine("----------------------------");
}
else
{
    Console.WriteLine("----------------------------");
    Console.WriteLine($"Hello {firstName}");
    Console.WriteLine("----------------------------");
}