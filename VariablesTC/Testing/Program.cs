bool? isTrue = null;

Console.WriteLine(isTrue?.ToString() ?? "null");

isTrue = false;

Console.WriteLine(isTrue);

isTrue = true;

Console.WriteLine(isTrue);
