
//TODO add more checks

string names = "";
var usersList = new List<string>();
do
{
    Console.WriteLine("Please enter users list separated with a comma and no space");
    Console.WriteLine("jake,patrick,louis,mario,gero");
    names = Console.ReadLine();
} while (names == "" || names.Length == 0 || !names.Contains(",") && names.Contains(" "));

usersList = names.Split(",").ToList();


foreach(string user in usersList)
{
    Console.WriteLine($"Welcome {user}");
}