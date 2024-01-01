//string? password = "abc544648@€&$";


//Console.WriteLine("Please enter your name");
//string? userName = Console.ReadLine();

int ageNumber;

Console.WriteLine("Hey, enter your age:");


while (!int.TryParse(Console.ReadLine(), out ageNumber))
{
    Console.WriteLine("Please enter a valid number");
}


switch (ageNumber)
{
    case > 12 and < 20:
        Console.WriteLine("You are a teenager");
        break;
    case >= 20:
        Console.WriteLine("You are an adult");
        break;
    default:
        Console.WriteLine("You are a baby");
        break;
}


/*

switch (userName?.ToLower())
{
    case "fox":
    case "pablo" or "santillan":
        {
            Console.WriteLine($"Hey Fox, your password is {password}");
            break;
        }
       

    default:
        {
            Console.WriteLine($"Welcome {userName}");
            break;
        }
       
}

 */