

int personAge;

Console.WriteLine("Please enter your age: ");
while (!int.TryParse(Console.ReadLine(), out personAge))
{
    Console.WriteLine("Please enter a valid number");
}

Console.WriteLine($"In 25 years you'll be {personAge+25} years old");

Console.WriteLine($"25 years before you had only {personAge-25} years old");