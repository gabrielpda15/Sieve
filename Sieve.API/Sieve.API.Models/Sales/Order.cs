using Sieve.API.Models.Person;
using Sieve.API.Models.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sieve.API.Models.Sales
{
    public class Order : Base.BaseEntity
    {
        [Required]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [DataType("varchar")]
        [StringLength(255)]
        [Display(Name = "Dados da Entrega")]
        public string ShippingData { get; set; }

        [Required]
        [Display(Name = "Valor")]
        public double Value { get; set; }

        public double Shipment { get; set; }

        [Required]
        [Display(Name = "Cliente")]
        public virtual Client Client { get; set; }

        public virtual IList<ROrderProduct> Products { get; set; }
    }
}
