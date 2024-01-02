
/*

string[] firstNames = new string[10];


firstNames[0] = "Fox";
firstNames[1] = "Carl";
firstNames[2] = "Bob";
firstNames[3] = "Nathan";
firstNames[4] = "Jane";

foreach (string name in firstNames)
{
    if (name != null) 
        Console.WriteLine($"Hello {name}");
}



Console.WriteLine($"{firstNames.Length}");






string data = "patrick,cameron,jason,peter";

string[] dataSplitter = data.Split(',');



Console.WriteLine($"Array size: {dataSplitter.Length}");

Console.WriteLine("---------------------------");
Console.WriteLine("----------[forloop]--------");
Console.WriteLine("---------------------------");

for (var i = 0; i < dataSplitter.Length; i++){
    Console.WriteLine($"data: {dataSplitter[i]}");
}



Console.WriteLine("---------------------------");
Console.WriteLine("----------[foreach]--------");
Console.WriteLine("---------------------------");

foreach (string name in dataSplitter)
{
    Console.WriteLine($"data: {name}");
}




*/



string[] userNames = new string[] { "Pablo", "Javier", "Hugo", "Pedro", "Walter" };
int[] userAges = new int[] { 43, 32, 64, 99 };

Array[] arrays = new Array[] {userAges, userNames};


Console.WriteLine($"Array size: {userNames.Length}");

foreach (string userName in userNames)
{
    Console.WriteLine($"User: {userName}");
}

foreach (int age in userAges)
{
    Console.WriteLine($"userAge: {age}");
}


bool[] isUserMarried = new bool[] { true, false };


Console.WriteLine($"user is {(isUserMarried[1] ? "Married":"Not Married")}");



Console.WriteLine($"Array 1 {arrays[0].GetValue(1)}");