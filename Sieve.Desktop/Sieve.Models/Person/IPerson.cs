using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Person
{
    public interface IPerson
    {
         string PhoneNumber { get; set; }
         string Email { get; set; }
         string Address { get; set; }
    }
}
