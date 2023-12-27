DateTime today = DateTime.Now;
DateOnly birthDay = DateOnly.Parse("13/04/1992");

Console.WriteLine(birthDay.Year+" "+birthDay.Day+" "+birthDay.Month);

Console.WriteLine(birthDay.ToString("y"));


Console.WriteLine($"""{birthDay.ToString("d")} and {today.ToString("d")}""");