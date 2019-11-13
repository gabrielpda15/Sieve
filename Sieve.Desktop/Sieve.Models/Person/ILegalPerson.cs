using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Person
{
    public interface ILegalPerson : IPerson
    {
        string CNPJ { get; set; }
        string CompanyName { get; set; }
        string TrandingName { get; set; }
    }
}
