using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Models.Location
{
    public class City : Base.BaseEntity
    {
        public string Name { get; set; }
        public virtual int RegionId { get; set; }
        public virtual int CountryId { get; set; }
    }
}
