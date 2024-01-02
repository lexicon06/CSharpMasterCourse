

string firstName = "";

bool isComplete = false;

var userNames = new List<string>();

bool isValidName(string name)
{
    if (name.Length >= 3 && name.ToLower() != "exit")
    {
        return true;
    }
    return false;
}

do
{
    Console.WriteLine("Please enter your first name (type exit to quit)");
    firstName = Console.ReadLine();
    if (isValidName(firstName))
    {
        userNames.Add(firstName);
    }
    else if (firstName.ToLower() == "exit")
    {
        isComplete = true;
    }

    if (userNames.Count > 0)
    {
        foreach (string name in userNames)
        {
            Console.WriteLine($"Hello {name}");
        }
    }

}
while (!isComplete);



Console.WriteLine("Goodbye!");