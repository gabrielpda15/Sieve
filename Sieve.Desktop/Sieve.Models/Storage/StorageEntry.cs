using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
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
        [Display("Data")]
        public DateTime? Date { get; set; }

        [Required]
        [Display("Quantidade")]
        public int? Quantity { get; set; }

        [Required]
        [Display("Tipo")]
        public EntryType Type { get; set; } = EntryType.None;

        [Required]
        [Display("Preço")]
        public double? Price { get; set; }

        [Required]
        [StringLength(30)]
        [Display("Lote")]
        public string Batch { get; set; }

        [Required]
        [Display("Data de Validade")]
        public DateTime? ShelfLife { get; set; }

        [Required]
        [Display("Estoque")]
        public virtual Storage Storage { get; set; }

    }
}
