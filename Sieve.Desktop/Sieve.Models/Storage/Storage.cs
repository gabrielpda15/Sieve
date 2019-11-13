using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sieve.Models.Storage
{
    public class Storage : Base.BaseEntity
    {
        [Required]
        [Display(Name = "Produto")]
        public virtual Product Product { get; set; }

        [Required]
        [Display(Name = "Preço Total")]
        public double TotalPrice { get; set; }

        [Required]
        [Display(Name = "Preço Médio")]
        public double AvgPrice { get; set; }

        [Required]
        [Display(Name = "Quantidade Total")]
        public int TotalQnt { get; set; }
    }
}
