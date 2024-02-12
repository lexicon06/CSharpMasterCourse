using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>(); 
            phones.Add(new Cellphone());
            phones.Add(new Smartphone());

            foreach (Phone phone in phones) {
               if(phone is Smartphone smartphone)
                {
                    smartphone.apps = new List<string>();
                    smartphone.apps.Add("c#");
                }
               if(phone is Cellphone cell)
                {
                    cell.Carrier = "Verizon";
                }
            }

            Console.ReadLine();
        }
    }

    public class Hotspot
    {


    }

    public class LandLine:Phone
    {

    }
    public class Smartphone : Cellphone
    {
        public List<String> apps { get; set; }
        public void ConnectToInternet()
        {

        }
    }

    public class Cellphone:Phone
    {

        public string Carrier { get; set; }


    }

    public class Phone
    {
        public void PlaceCall()
        {

        }

        public void EndCall()
        {

        }
    }

    public class WalkieTalkie
    {

    }
}
