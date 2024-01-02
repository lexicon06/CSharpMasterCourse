

//Dictionaries homework


var employeeIds = new Dictionary<int, string>();

employeeIds.Add(1, "Paul");
employeeIds.Add(2, "Jack");
employeeIds.Add(3, "Bill");
employeeIds.Add(4, "Marty");
employeeIds.Add(5, "Michael");


Console.WriteLine($"Please enter your employee ID its between 1/{employeeIds.Count}");

int userIdInput = 0;

while (!int.TryParse(Console.ReadLine(), out userIdInput) || userIdInput < 1 || userIdInput > employeeIds.Count)
{
    Console.WriteLine("Please enter a valid ID!!!");
}

Console.WriteLine($"Welcome back {employeeIds[userIdInput]}");