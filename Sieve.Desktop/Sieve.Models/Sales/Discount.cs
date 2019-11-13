using Sieve.Models.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.Models.Sales
{
    [Table("Discount")]
    public class Discount : Base.BaseEntity
    {
        [Required]
        [Display(Name = "Data Inicial")]
        public DateTime InitialDate { get; set; }

        public int? MinQnt { get; set; }

        [Required]
        [Display(Name = "Porcentagem")]
        public double Percentage { get; set; }

        [Required]
        [Display(Name = "Deve ter cartão")]
        public bool MustHaveCard { get; set; }

        public DateTime? ShelfLife { get; set; }

        public bool Active { get; set; }

        [Required]
        [Display(Name = "Produto")]
        public virtual Product Product { get; set; }
    }
}
