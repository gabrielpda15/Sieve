using Sieve.Models.Storage;
using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Sales
{
    public class Discount : Base.BaseEntity
    {
        [Required]
        [Display("Data Inicial")]
        public DateTime? InitialDate { get; set; }

        public int? MinQnt { get; set; }

        [Required]
        [Display("Porcentagem")]
        public double? Percentage { get; set; }

        [Required]
        [Display("Deve ter cartão")]
        public bool? MustHaveCard { get; set; }

        [Required]
        [Display("Vencimento")]
        public DateTime? ShelfLife { get; set; }

        [Required]
        [Display("Ativo")]
        public bool? Active { get; set; }

        [Required]
        [Display("Produto")]
        public virtual Product Product { get; set; }
    }
}
