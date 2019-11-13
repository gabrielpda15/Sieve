using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sieve.API.Models.Sales
{
    public class Card : Base.BaseEntity
    {
        [Required]
        [DataType("varchar")]
        [StringLength(30)]
        [Display(Name = "Titular")]
        public string CardHolder { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(19)]
        [Display(Name = "Número")]
        public string CardNumber { get; set; }

        [Required]
        [Display(Name = "Validade")]
        public DateTime ShelfLife { get; set; }

        [Required]
        [Display(Name = "CVV")]
        public int CVV { get; set; }

        [Required]
        [Display(Name = "Limite")]
        public double Limit { get; set; }

        [Required]
        [Display(Name = "Valor")]
        public double Value { get; set; }

        [Required]
        [Display(Name = "Fechamento")]
        public DateTime Payday { get; set; }
    }
}
