using Sieve.Models.Person;
using Sieve.Models.Relations;
using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Sales
{
    public class Order : Base.BaseEntity
    {
        [Required]
        [Display("Data")]
        public DateTime? Date { get; set; }

        [StringLength(255)]
        [Display("Dados da Entrega")]
        public string ShippingData { get; set; }

        [Required]
        [Display("Valor")]
        public double? Value { get; set; }

        public double Shipment { get; set; }

        [Required]
        [Display("Cliente")]
        public virtual Client Client { get; set; }

        public virtual IList<ROrderProduct> Products { get; set; }
    }
}
