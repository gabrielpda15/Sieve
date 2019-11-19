using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Models.Person
{
    public class Person : Base.BaseEntity, IPerson
    {
        public Person()
        {
            this.AddressObj = new Address();
        }

        [Phone]
        [StringLength(22)]
        [Display("Telefone")]
        public string PhoneNumber { get; set; }

        [Email]
        [StringLength(80)]
        [Display("Email")]
        public string Email { get; set; }

        public Address AddressObj { get; set; }

        [Required]
        [StringLength(255)]
        [Display("Endereço")]
        public string Address { get => this.AddressObj?.ToString(); set => AddressObj = new Address(value); }
    }
}
