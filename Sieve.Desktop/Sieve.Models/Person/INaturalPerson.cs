using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Person
{
    public interface INaturalPerson : IPerson
    {
        string CPF { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime? Birthday { get; set; }
    }
}
