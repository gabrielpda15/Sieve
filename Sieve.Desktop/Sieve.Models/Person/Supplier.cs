using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Person
{
    public class Supplier : Base.BaseEntity, INaturalPerson, ILegalPerson
    {
        public enum SupplierType { None = 0, Service = 1, Product = 2}

        [CNPJ]
        [StringLength(18)]
        [Display("CNPJ")]
        public string CNPJ { get; set; }

        [CPF]
        [StringLength(14)]
        [Display("CPF")]
        public string CPF { get; set; }

        [StringLength(30)]
        [Display("Nome")]
        public string FirstName { get; set; }

        [StringLength(80)]
        [Display("Sobrenome")]
        public string LastName { get; set; }

        [StringLength(80)]
        [Display("Razão Social")]
        public string CompanyName { get; set; }

        [StringLength(30)]
        [Display("Nome Fantasia")]
        public string TrandingName { get; set; }

        [Phone]
        [Required]
        [StringLength(22)]
        [Display("Telefone")]
        public string PhoneNumber { get; set; }

        [Email]
        [Required]
        [StringLength(60)]
        [Display("Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        [Display("Endereço")]
        public string Address { get; set; }

        public DateTime? Birthday { get; set; }

        [Required]
        [StringLength(80)]
        [Display("Serviço")]
        public string Service { get; set; }

        [Required]
        [Display("Tipo")]
        public SupplierType Type { get; set; } = SupplierType.None;

        public TimeSpan ShippingTime { get; set; }

        [StringLength(255)]
        [Display("Observação")]
        public string Obs { get; set; }
    }
}
