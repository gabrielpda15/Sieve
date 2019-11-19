using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Storage
{
    public class Storage : Base.BaseEntity
    {
        [Required]
        [Display("Produto")]
        public virtual Product Product { get; set; }

        [Required]
        [Display("Preço Total")]
        public double? TotalPrice { get; set; }

        [Required]
        [Display("Preço Médio")]
        public double? AvgPrice { get; set; }

        [Required]
        [Display("Quantidade Total")]
        public int? TotalQnt { get; set; }
    }
}
