


using System;

List<string> students = new List<string>();


string typed = "";

do
{
    Console.WriteLine("Please enter the new student name:");
    typed = Console.ReadLine();
    if (typed != "done" && typed != "")
    {
        students.Add(typed);
        Console.WriteLine("====================");
        Console.WriteLine("Students List:");
        foreach (string s in students)
        {
            Console.WriteLine($"Name: {s}");
        }

        Console.WriteLine("\nType 'done' to exit the program.\n");
    }
    else if (typed == "done")
    {
        return;
    }
}
while (typed != "done");