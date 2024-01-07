using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
    public class UserModel
    {
        public string UserName { private get; set; }
        //public string Password { get; set; }
        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length > 6)
                {
                    _password = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Sorry, but you have to enter a pasword with more than 6 characters");
                }

            }
        }

        public string Email { get; set; }
        public int UserAge { get; set; }

        public void GreetUser()
        {
            Console.Write("Login Granted!");
            Console.ReadLine();
            Console.WriteLine($"Welcome {UserName}");
        }
    }
}
