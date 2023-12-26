

Console.WriteLine("------------------------------------");
Console.WriteLine("Assignament task for C# MasterCourse");
Console.WriteLine("------------------------------------");

string assignamentTask = File.ReadAllText($@"C:\Users\Foxhound\source\repos\VariablesTC\TP\Homework Variables.txt");


Console.WriteLine(assignamentTask);


string? personName;
int? personAge;
bool? personIsAlive;
string personPhoneNumber;
char valueYesNo = 'y';


Console.WriteLine("Person ID:");
Console.WriteLine("Please Enter your name");
personName = Console.ReadLine();
Console.WriteLine("Please Enter your age");
personAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your phone number:");
personPhoneNumber = Console.ReadLine();
Console.WriteLine("Alive? Y/N");
valueYesNo = Convert.ToChar(Console.ReadLine());
personIsAlive = valueYesNo.ToString().ToLower() == "y";



Console.WriteLine("\nData is complete\n");

Console.WriteLine($"----[{(personIsAlive == true ? "ALIVE" : "DEAD")}]----");

Console.WriteLine("Person ID:");
Console.WriteLine($"Name: {personName}");
Console.WriteLine($"Age: {personAge}");
Console.WriteLine($"PhoneNumber: {personPhoneNumber}");


Console.WriteLine("");
