


string? personName;
int personAge;
bool personIsAlive;
string personPhoneNumber;
char valueYesNo = 'y';

Console.WriteLine("Assignament task for C# MasterCourse");
Console.WriteLine("------------------------------------");

Console.WriteLine("Person ID:");
Console.WriteLine("Please enter your name:");
personName = Console.ReadLine();

Console.WriteLine("Please enter your age:");
while (!int.TryParse(Console.ReadLine(), out personAge))
{
    Console.WriteLine("Invalid input. Please enter a valid age:");
}

Console.WriteLine("Please enter your phone number:");
personPhoneNumber = Console.ReadLine();

Console.WriteLine("Alive? Y/N:");
while (!char.TryParse(Console.ReadLine(), out valueYesNo) || (valueYesNo != 'y' && valueYesNo != 'n'))
{
    Console.WriteLine("Invalid input. Please enter 'Y' or 'N':");
}
personIsAlive = valueYesNo == 'y';

Console.WriteLine("\nData is complete\n");

Console.WriteLine($"----[{(personIsAlive ? "ALIVE" : "DEAD")}]----");
Console.WriteLine("Person ID:");
Console.WriteLine($"Name: {personName}");
Console.WriteLine($"Age: {personAge}");
Console.WriteLine($"PhoneNumber: {personPhoneNumber}");
