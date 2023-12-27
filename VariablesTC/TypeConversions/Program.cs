int personAge;

Console.WriteLine("What Age is it?");
string? ageText = Console.ReadLine();

while(!int.TryParse(ageText, out personAge))
{
    Console.WriteLine("Please enter a valid age!");
    ageText = Console.ReadLine();
}


Console.WriteLine($"Person is {personAge} Years Old");


double testDouble = personAge;

decimal testDecimal = (decimal)testDouble;//casting conversion

Console.WriteLine($"{testDouble} vs {testDecimal}");