using Sieve.API.Models.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.API.Models.Sales
{
    [Table("Discount")]
    public class Discount : Base.BaseEntity
    {
        [Required(ErrorMessage = "Data Inicial é obrigatório")]
        [Display(Name = "Data Inicial")]
        public DateTime InitialDate { get; set; }

        [Display(Name = "Quantidade Minima")]
        public int? MinQnt { get; set; }

        [Required(ErrorMessage = "Porcentagem é obrigatório")]
        [Display(Name = "Porcentagem")]
        public double Percentage { get; set; }

        [Required(ErrorMessage = "Obrigatoriedade de Cartão é obrigatório")]
        [Display(Name = "Cartão Obrigatório")]
        public bool MustHaveCard { get; set; }

        [Display(Name = "Data Final")]
        public DateTime? ShelfLife { get; set; }

        [Display(Name = "Ativo")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "Produto é obrigatório")]
        [Display(Name = "Produto")]
        public virtual Product Product { get; set; }
    }
}
