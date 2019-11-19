using Sieve.Models.Sales;
using Sieve.Models.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Relations
{
    public class ROrderProduct
    {
        public virtual int IdOrder { get; set; }

        public virtual int IdProduct { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
