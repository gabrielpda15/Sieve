using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sieve.Models.Storage
{
    public class Product : Base.BaseEntityDescription
    {
        [DataType("varchar")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Marca")]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Seção")]
        public virtual Section Section { get; set; }

        [Required]
        [Display(Name = "Categoria")]
        public virtual Category Category { get; set; }
    }
}
