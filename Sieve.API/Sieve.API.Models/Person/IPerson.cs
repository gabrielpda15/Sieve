using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Models.Person
{
    public interface IPerson
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
