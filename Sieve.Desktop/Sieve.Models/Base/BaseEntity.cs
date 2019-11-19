using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.Models.Base
{
    public class BaseEntity : IEntity
    {
        public virtual int Id { get; set; }

        public string CreationUser { get; set; }

        public string EditionUser { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? EditionDate { get; set; }
    }
}
