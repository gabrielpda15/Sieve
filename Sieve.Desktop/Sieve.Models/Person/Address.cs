using Newtonsoft.Json;
using Sieve.Models.Extensions;
using Sieve.Models.Location;
using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Models.Person
{
    public class Address
    {
        [CEP]
        [Required]
        [Display("Código Postal")]
        public string PostalCode { get; set; }

        [Required]
        [Display("Endereço")]
        public string Street { get; set; }

        [Required]
        [Display("Número")]
        public string Number { get; set; }

        [Required]
        [Display("Bairro")]
        public string Neighborhood { get; set; }

        [Required]
        [Display("Cidade")]
        public City City { get; set; }

        [Required]
        [Display("Estado")]
        public Region Region { get; set; }

        [Required]
        [Display("País")]
        public Country Country { get; set; }

        public string Complement { get; set; }

        public Address() 
        {
            this.PostalCode = null;
            this.Street = null;
            this.Number = null;
            this.Neighborhood = null;
            this.Complement = null;
            this.City = null;
            this.Region = null;
            this.Country = null;
        }

        public Address(string address) : this()
        {
            var x = JsonConvert.DeserializeObject<AddressDTO>(address);

            this.PostalCode = x.PostalCode;
            this.Street = x.Street;
            this.Number = x.Number;
            this.Neighborhood = x.Neighborhood;
            this.Complement = x.Complement;
            this.City = x.City.Map(y => new City { Id = y.Id, Name = y.Name });
            this.Region = x.Region.Map(y => new Region { Id = y.Id, Name = y.Name });
            this.Country = x.Country.Map(y => new Country { Id = y.Id, Name = y.Name });
        }

        private bool IsValid()
        {
            return new EntityValidator<Address>().Validate(this, out var errors);
        }

        public override string ToString()
        {
            if (this.IsValid())
                return JsonConvert.SerializeObject(this.Map(x => new AddressDTO(x)), Formatting.None);
            else
                return null;
        }

        private class AddressDTO
        {
            public string PostalCode { get; set; }
            public string Street { get; set; }
            public string Number { get; set; }
            public string Neighborhood { get; set; }
            public CityDTO City { get; set; }
            public RegionDTO Region { get; set; }
            public CountryDTO Country { get; set; }
            public string Complement { get; set; }

            public class CityDTO
            {
                public int Id { get; set; }
                public string Name { get; set; }
            }

            public class RegionDTO
            {
                public int Id { get; set; }
                public string Name { get; set; }
            }

            public class CountryDTO
            {
                public int Id { get; set; }
                public string Name { get; set; }
            }

            public AddressDTO(Address address)
            {
                this.PostalCode = address.PostalCode;
                this.Street = address.Street;
                this.Number = address.Number;
                this.Neighborhood = address.Neighborhood;
                this.Complement = address.Complement;
                this.City = address.City.Map(x => new CityDTO { Id = x.Id, Name = x.Name });
                this.Region = address.Region.Map(x => new RegionDTO { Id = x.Id, Name = x.Name });
                this.Country = address.Country.Map(x => new CountryDTO { Id = x.Id, Name = x.Name });
            }
        }
    }
}
