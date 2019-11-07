using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Models.Sales
{
    public class Card : Base.BaseEntity
    {
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public DateTime ShelfLife { get; set; }
        public int CVV { get; set; }
        public double Limit { get; set; }
        public double Value { get; set; }
        public DateTime Payday { get; set; }
    }
}
