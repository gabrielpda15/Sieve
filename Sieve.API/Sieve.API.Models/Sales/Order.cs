using Sieve.API.Models.Person;
using Sieve.API.Models.Relations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Models.Sales
{
    public class Order : Base.BaseEntity
    {
        public DateTime Date { get; set; }
        public string ShippingData { get; set; }
        public double Value { get; set; }
        public double Shipment { get; set; }
        public virtual Client Client { get; set; }
        public virtual IList<ROrderProduct> Products { get; set; }
    }
}
