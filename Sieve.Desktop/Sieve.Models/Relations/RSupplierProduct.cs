using Sieve.Models.Person;
using Sieve.Models.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Relations
{
    public class RSupplierProduct
    {
        public virtual int IdSupplier { get; set; }

        public virtual int IdProduct { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Product Product { get; set; }
    }
}
