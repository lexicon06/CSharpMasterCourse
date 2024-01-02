


string[] userNames = new string[] { "Jacob", "Alan", "Gabriel" };

Console.WriteLine("Please select a number between 1 to 3");

int userNumber = 0;

while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1 || userNumber > 3)
{
    Console.WriteLine("Please enter a valid number between 1 and 3");
}

Console.WriteLine($"You have selected: {userNames[userNumber - 1]}");

Console.WriteLine("Good job!");

