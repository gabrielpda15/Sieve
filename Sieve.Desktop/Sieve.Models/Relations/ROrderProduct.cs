using Sieve.Models.Sales;
using Sieve.Models.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.Models.Relations
{
    [Table("ROrderProduct")]
    public class ROrderProduct
    {
        [Key]
        public virtual int IdOrder { get; set; }

        [Key]
        public virtual int IdProduct { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
