

using System.Linq;

List<string> firstNames = new List<string>();

firstNames.Add("Pablo");
firstNames.Add("Gavin");
firstNames.Add("Tim");
firstNames.Add("Carl");
firstNames.Add("Frank");


foreach (string name in firstNames)
{
    Console.WriteLine($"Welcome {firstNames[firstNames.Count-1]}");
}


string data = "Smith,Jonas,Bobo";

//same as last time we did but with arrays this time we use ToList to perform the conversion

//before

/*

string[] names = data.Split(",");

*/

List<string> lastNames = data.Split(",").ToList();//now we use List which is nicer



foreach (string name in lastNames)
{
    Console.WriteLine($"Found: {name}");
}