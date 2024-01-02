

var dictionaryEmployee = new Dictionary<int, string>();

dictionaryEmployee.Add(1, "Lucas");
dictionaryEmployee.Add(2, "Patrick");
dictionaryEmployee[4] = "Ricardo";


Console.WriteLine($"User {dictionaryEmployee[4]}");

var dictionaryMovies = new Dictionary<string, string>();

dictionaryMovies.Add("galaxy", "Galaxy movie is about aliens and space");
dictionaryMovies.Add("gnome", "Gnome movie is about gnomes and zombies");

Console.WriteLine($"Movie is {dictionaryMovies["gnome"]}");