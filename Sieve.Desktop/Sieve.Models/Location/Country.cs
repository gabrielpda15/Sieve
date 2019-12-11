using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Models.Location
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Country entity)
            {
                return entity.Id == this.Id;
            }

            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
