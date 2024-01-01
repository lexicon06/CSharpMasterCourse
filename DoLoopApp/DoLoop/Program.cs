
bool isValidAge;
int userAge;


do
{
    Console.WriteLine("What is your age?:");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out userAge);

    if (!isValidAge)
    {
        Console.WriteLine("That was an invalid age.");
    }
} while (!isValidAge);



Console.WriteLine($"Your age is {userAge}");

Console.WriteLine("Lets calc together with a loop how much need to reach 100");

int counter = 0;
while(userAge++ < 100)
{
    counter++;
    Console.WriteLine($"user age is increasing {userAge}, {counter} times");
}