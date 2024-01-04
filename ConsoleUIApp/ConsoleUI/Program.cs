


namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"The value of i is {i}");
            for(int j = 0; j < 20; j++)//the bug was i++
            {
                Console.WriteLine($"The value of j is {j}");
            }
        }
    }
}