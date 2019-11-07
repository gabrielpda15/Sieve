using Sieve.API.Models.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Models.Person
{
    public class Client : Base.BaseEntity, INaturalPerson
    {
        public string CPF { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }
        public virtual Card Card { get; set; }
    }
}
