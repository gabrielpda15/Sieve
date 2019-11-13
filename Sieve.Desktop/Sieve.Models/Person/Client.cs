using Sieve.Models.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.Models.Person
{
    public class Client : Base.BaseEntity, INaturalPerson
    {
        [Required]
        [DataType("varchar")]
        [StringLength(14)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(30)]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(80)]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [DataType("varchar")]
        [StringLength(22)]
        [Display(Name = "Telefone")]
        public string PhoneNumber { get; set; }

        [DataType("varchar")]
        [StringLength(80)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(255)]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual Card Card { get; set; }
    }
}
