

//using System.Globalization;

//DateTime today = DateTime.Now;//local time

DateTime today = DateTime.UtcNow;

//DateTime birthDay = DateTime.Parse("13/04/1992");

//DateTime birthDay = DateTime.ParseExact("14/04/1992", "d/M/yyyy", CultureInfo.InvariantCulture);


//CultureInfo.InvariantCulture ignore the culture and represent as we specified

//Console.WriteLine(birthDay);


Console.WriteLine(today.ToString("MMMM yyyy ddddd d hh:mm tt"));



Console.WriteLine(today);
Console.WriteLine(today.ToString("d"));//we use ToString() too we use d as day
Console.WriteLine(today.ToString("y"));//month and year
Console.WriteLine(today.ToString("t"));//time only as 00:00
Console.WriteLine(today.ToString("m"));//day number and month only
