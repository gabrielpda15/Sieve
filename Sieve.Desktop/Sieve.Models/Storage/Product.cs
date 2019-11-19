using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Storage
{
    public class Product : Base.BaseEntityDescription
    {
        [Required]
        [StringLength(30)]
        [Display("Marca")]
        public string Brand { get; set; }

        [Required]
        [Display("Seção")]
        public virtual Section Section { get; set; }

        [Required]
        [Display("Categoria")]
        public virtual Category Category { get; set; }
    }
}
