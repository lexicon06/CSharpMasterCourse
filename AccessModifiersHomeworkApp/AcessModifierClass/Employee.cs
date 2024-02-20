using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifierClass
{
        public class QueryToDB
        {
            protected internal void SearchUser(string name)
            {
                Console.WriteLine($"Hello {name}");
            }
        }

        public class Employee : QueryToDB
        {
            public string FirstName { get; set; }
            public string LastName { get; private set; }

            public void PerformSearch()
            {
                SearchUser("Fox"); // Now you can call the method
            }
       }
}
