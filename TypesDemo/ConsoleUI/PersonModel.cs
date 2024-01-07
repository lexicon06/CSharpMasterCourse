using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public int Age { get; set; }
        //we use propfull below

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age should be more than 0 and less than 126.");
                }
            }
        }

        //public string SSN { get; set; } //Social Security Number  123-02-2312

        private string _ssn;

        public string SSN
        {
            get
            {

                //string output = "***-**-" + _ssn.Substring(_ssn.Length - 5);
                string output = string.Empty;
                if (_ssn.Split('-').Length > 1) { 
                output = "***-**-"+_ssn.Split('-')[2];
                }
                else
                {
                    throw new InvalidOperationException("Sorry but you must provide a valid social security number with -");
                }
                return output;
            }
            set { _ssn = value; }
        }



    }
}