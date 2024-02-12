using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPhone> phones = new List<IPhone>();
            Alpha123 phone = new Alpha123();
            Beta123 phone2 = new Beta123();

            phones.Add(phone);
            phones.Add(phone2);

            foreach(var cel in phones) { 
            
                if(cel is Alpha123 wtf)
                {
                    Console.WriteLine(wtf.model);
                }

                if(cel is Beta123 newphone)
                {
                    Console.WriteLine(newphone.Number);
                }

            }


            Console.ReadLine();
        }
    }
    public class Alpha123 : IPhone, IDisposable
    {
        public virtual string model { get; set; } = "Alpha";
        public int serialNumber { get; set; }

        public void Dispose()
        {
        }
    }

    public class Beta123 : Alpha123
    {
        public override string model { get; set; } = "Beta";
        public int Number { get; set; } = 1234556;
    }

    public interface IPhone
    {
        string model { get; set; }
        int serialNumber { get; set; }
    }


}
