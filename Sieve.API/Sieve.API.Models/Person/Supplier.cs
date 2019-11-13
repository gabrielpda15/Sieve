using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sieve.API.Models.Person
{
    public class Supplier : Base.BaseEntity, INaturalPerson, ILegalPerson
    {
        public enum SupplierType { None = 0, Service = 1, Product = 2}

        [DataType("varchar")]
        [StringLength(18)]
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [DataType("varchar")]
        [StringLength(14)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [DataType("varchar")]
        [StringLength(30)]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [DataType("varchar")]
        [StringLength(80)]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [DataType("varchar")]
        [StringLength(80)]
        [Display(Name = "Razão Social")]
        public string CompanyName { get; set; }

        [DataType("varchar")]
        [StringLength(30)]
        [Display(Name = "Nome Fantasia")]
        public string TrandingName { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(22)]
        [Display(Name = "Telefone")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(60)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(255)]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        public DateTime? Birthday { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(80)]
        [Display(Name = "Serviço")]
        public string Service { get; set; }

        public SupplierType Type { get; set; }

        public TimeSpan ShippingTime { get; set; }

        [DataType("varchar")]
        [StringLength(255)]
        [Display(Name = "Observação")]
        public string Obs { get; set; }
    }
}
