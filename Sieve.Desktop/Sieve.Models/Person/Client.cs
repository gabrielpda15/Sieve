using Sieve.Models.Sales;
using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Person
{
    public class Client : Base.BaseEntity, INaturalPerson
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

        [Phone]
        [StringLength(22)]
        [Display("Telefone")]
        public string PhoneNumber { get; set; }

        [Email]
        [StringLength(80)]
        [Display("Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        [Display("Endereço")]
        public string Address { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual Card Card { get; set; }
    }
}
