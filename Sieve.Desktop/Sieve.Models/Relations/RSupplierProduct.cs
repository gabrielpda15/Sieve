using Sieve.Models.Person;
using Sieve.Models.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.Models.Relations
{
    [Table("RSupplierProduct")]
    public class RSupplierProduct
    {
        [Key]
        public virtual int IdSupplier { get; set; }

        [Key]
        public virtual int IdProduct { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Product Product { get; set; }
    }
}
