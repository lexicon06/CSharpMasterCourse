using Methods;

//Console.WriteLine("----WELCOME----");
//ConsoleGreeting.SayHi("Pablo");
//Console.WriteLine("--------");
//ConsoleGreeting.SayHi("Fox");
//Console.WriteLine("----GOODBYE----");
//ConsoleGreeting.SayGoodbye("Pablo");
//Console.WriteLine("--------");
//ConsoleGreeting.SayGoodbye("Fox");


//mathShortcuts.Add(1, 1);

//double[] numbers = new double[] { 2, 2, 2 };

//mathShortcuts.addAll(numbers);


//Console.WriteLine($"Welcome {mathShortcuts.GetUsersName()}");


//tuples usage

//_ is discard character

//only on dotnet core projects

//(string, string) fullName = ConsoleGreeting.GetFullName();


(string firstName, _)= ConsoleGreeting.GetFullName();

Console.WriteLine($"Hola {firstName}");

