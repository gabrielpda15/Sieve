using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Sales
{
    public class Card : Base.BaseEntity
    {
        [Required]
        [StringLength(30)]
        [Display("Titular")]
        public string CardHolder { get; set; }

        [Required]
        [StringLength(19)]
        [Display("Número")]
        public string CardNumber { get; set; }

        [Required]
        [Display("Validade")]
        public DateTime? ShelfLife { get; set; }

        [Required]
        [Display("CVV")]
        public int? CVV { get; set; }

        [Required]
        [Display("Limite")]
        public double? Limit { get; set; }

        [Required]
        [Display("Valor")]
        public double? Value { get; set; }

        [Required]
        [Display("Fechamento")]
        public DateTime? Payday { get; set; }
    }
}
