using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Person
{
    public interface ILegalPerson : IPerson
    {
        public string CNPJ { get; set; }
        public string CompanyName { get; set; }
        public string TrandingName { get; set; }
    }
}
