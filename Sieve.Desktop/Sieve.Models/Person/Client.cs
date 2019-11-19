using Sieve.Models.Sales;
using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Person
{
    public class Client : Person, INaturalPerson
    {
        [Required]
        [CPF]
        [StringLength(14)]
        [Display("CPF")]
        public string CPF { get; set; }

        [Required]
        [StringLength(30)]
        [Display("Nome")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(80)]
        [Display("Sobrenome")]
        public string LastName { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual Card Card { get; set; }
    }
}
