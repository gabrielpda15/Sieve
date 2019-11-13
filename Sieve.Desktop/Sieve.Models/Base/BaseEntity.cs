using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.Models.Base
{
    public class BaseEntity : IEntity
    {
        [Key]
        public virtual int Id { get; set; }

        [DataType("varchar")]
        [StringLength(30)]
        public string CreationUser { get; set; }

        [DataType("varchar")]
        [StringLength(30)]
        public string EditionUser { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? EditionDate { get; set; }
    }
}
