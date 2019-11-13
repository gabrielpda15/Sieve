using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sieve.Models.Storage
{
    public class StorageEntry : Base.BaseEntityDescription
    {
        public enum EntryType
        {
            None = 0, In = 1, Out = 2
        }

        [Required]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        public EntryType Type { get; set; }

        [Required]
        [Display(Name = "Preço")]
        public double Price { get; set; }

        [DataType("varchar")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Lote")]
        public string Batch { get; set; }

        [Required]
        [Display(Name = "Data de Validade")]
        public DateTime? ShelfLife { get; set; }

        [Required]
        [Display(Name = "Estoque")]
        public virtual Storage Storage { get; set; }

    }
}
