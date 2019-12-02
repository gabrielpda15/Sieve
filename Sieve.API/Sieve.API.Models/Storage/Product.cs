using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.API.Models.Storage
{
    [Table("Product")]
    public class Product : Base.BaseEntityDescription
    {
        [DataType("varchar")]
        [Required(ErrorMessage = "Marca é obrigatório")]
        [StringLength(30, ErrorMessage = "Marca deve ter no máximo 30 caracteres")]
        [Display(Name = "Marca")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Seção é obrigatório")]
        [Display(Name = "Seção")]
        public virtual Section Section { get; set; }

        [Required(ErrorMessage = "Categoria é obrigatória")]
        [Display(Name = "Categoria")]
        public virtual Category Category { get; set; }
    }
}
