using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Models.Location
{
    public class Region : Base.BaseEntity
    {
        public string Name { get; set; }
        public virtual int CountryId { get; set; }
        public virtual IList<City> Cities { get; set; }
    }
}
