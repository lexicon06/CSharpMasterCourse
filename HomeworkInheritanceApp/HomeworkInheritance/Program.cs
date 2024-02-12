using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }

        public class Vehicle
        {
            public string Color { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int KilometersPerHour { get; set; }
            public int Wheels { get; set; }
            public string Battery { get; set; }

        }
        public class Car : Vehicle
        {
            public string Terrain { get; set; }
            public int WheelType { get; set; }
            public List<string> fuel {get; set;}
        }

        public class Boat:Vehicle
        {
           public string EmergencyBag { get; set; }
        }

        public class Motorcycle:Vehicle
        {

            public string Helmet { get; set; }
            public string ChainLock { get; set; }

        }
    }
}
