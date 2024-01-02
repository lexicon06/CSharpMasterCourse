


//for (int i = 0; i < 20; i++)
//{
//    Console.WriteLine($"The value of i is {i}");
//}

//string data = "Bob,Grace,Jane,Chris";

//List<string> list = data.Split(',').ToList();

//for(int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine($"ID: {i} user {list[i]}");
//}



var charges = new List<decimal>();

charges.Add(250.40M);
charges.Add(25.52M);
charges.Add(38.85M);

decimal totalCharges = 0;

for (int i = 0; i < charges.Count; i++)
{
    totalCharges+= charges[i];
}

Console.WriteLine($"The total charge is: ${totalCharges}");
