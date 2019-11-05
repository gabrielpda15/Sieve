using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Models.Person
{
    public interface INaturalPerson : IPerson
    {
        public string CPF { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
