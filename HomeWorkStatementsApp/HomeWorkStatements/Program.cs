


Console.WriteLine("Please enter your first name:");


string? userName = Console.ReadLine();



while (userName == null || userName == "")
{
    Console.WriteLine("Please enter a valid name");
    userName = Console.ReadLine();
}

if (userName.ToLower() == "pablo")
{
    Console.WriteLine($"Welcome professor {userName}");
}
else
{
    Console.WriteLine($"Welcome student {userName}");
}