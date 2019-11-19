using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Models.Location
{
    public class Country : Base.BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual IList<Region> Regions { get; set; }
    }
}
