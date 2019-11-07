using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sieve.API.Models.Storage
{
    public class Storage : Base.BaseEntity
    {
        [Required(ErrorMessage = "Produto é obrigatório")]
        [Display(Name = "Produto")]
        public virtual Product Product { get; set; }

        [Required(ErrorMessage = "Preço Total é obrigatório")]
        [Display(Name = "Preço Total")]
        public double TotalPrice { get; set; }

        [Required(ErrorMessage = "Preço Médio é obrigatório")]
        [Display(Name = "Preço Médio")]
        public double AvgPrice { get; set; }

        [Required(ErrorMessage = "Quantidade Total é obrigatório")]
        [Display(Name = "Quantidade Total")]
        public int TotalQnt { get; set; }
    }
}
