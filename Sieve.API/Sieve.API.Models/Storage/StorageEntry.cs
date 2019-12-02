using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.API.Models.Storage
{
    [Table("StorageEntry")]
    public class StorageEntry : Base.BaseEntityDescription
    {
        public enum EntryType
        {
            None = 0, In = 1, Out = 2
        }

        [Required(ErrorMessage = "Data é obrigatória")]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Quantidade é obrigatório")]
        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Tipo é obrigatório")]
        [Display(Name = "Tipo")]
        public EntryType Type { get; set; }

        [Required(ErrorMessage = "Preço é obrigatório")]
        [Display(Name = "Preço")]
        public double Price { get; set; }

        [DataType("varchar")]
        [Required(ErrorMessage = "Lote é obrigatório")]
        [StringLength(30, ErrorMessage = "Lote deve ter no máximo 30 caracteres")]
        [Display(Name = "Lote")]
        public string Batch { get; set; }

        [Required(ErrorMessage = "Data de Validade é obrigatória")]
        [Display(Name = "Data de Validade")]
        public DateTime? ShelfLife { get; set; }   
        
        [Required(ErrorMessage = "Estoque é obrigatório")]
        [Display(Name = "Estoque")]
        public virtual Storage Storage { get; set; }

    }
}
