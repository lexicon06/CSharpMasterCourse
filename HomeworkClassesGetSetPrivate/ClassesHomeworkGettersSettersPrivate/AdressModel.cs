using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomeworkGettersSettersPrivate
{
    public class AddressModel
    {

        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        private int _zipCode;

        public int ZipCode
        {
            get { return _zipCode; }
            set
            {
                if (value.ToString().Length < 4)
                {
                    throw new ArgumentException("value", "ZipCode is not correct");
                }
                else
                {
                    _zipCode = value;
                }
            }
        }



        public string FullAddress { get; private set; }


        public AddressModel(string fullAdress)
        {
            FullAddress = fullAdress;
        }

    }
}
