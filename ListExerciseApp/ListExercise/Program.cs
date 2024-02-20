using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list = new List<string>();
            list.Add("1 Hola");
            list.Add("2 Adios");
            list.Add("3 Hello");
            list.Add("4 Goodbye");

            var random = new Random();

            List<string> nuevaLista = list.OrderBy(x => random.Next()).ToList();

            foreach(var item in nuevaLista)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine(); 
        }
    }
}
