using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class PersonModel
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Stack { get; set; }


        public PersonModel(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
    }
}
