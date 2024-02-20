using System;
using DemoLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

namespace AccersModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Pablo";

            person.SavePerson();
            person.SayHello();
            Console.ReadLine();
        }
    }
    public class ModifiedDataAccess : DataAccess { 
    public void GetUnsecuredConnection()
        {
            GetConnectionString();
        }

    }
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            ModifiedDataAccess dataAccess = new ModifiedDataAccess();
            dataAccess.GetUnsecuredConnection();

            formerLastName = "Kenny";
        }
    }
}
