using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Song = Console.ReadLine();

            do
            {
                Song = new Spotify().Song;
                Console.WriteLine(Song);
                Song = Console.ReadLine();
            } while (Song == "");



            Console.ReadLine();
        }
    }
}
