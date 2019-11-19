using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Models.Person
{
    public class Address
    {
        public Address() { }

        public Address(string address)
        {

        }

        public bool IsValid()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
