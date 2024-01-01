

Console.WriteLine("Welcome to homework app: do while loop");

string? userName = null;

while (userName == String.Empty || userName == null)
{

    Console.WriteLine("Please enter your name:");
    userName = Console.ReadLine();

}


string inputText = "";

do
{
    if (userName.ToLower() == "fox")
    {
        Console.WriteLine("Welcome professor Pablo");
    }
    else
    {
        Console.WriteLine("Welcome student");
    }

    Console.WriteLine("""Please type "exit" to terminate the program.""");

    inputText = Console.ReadLine();
} while (inputText != "exit");