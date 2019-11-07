using Sieve.API.Models.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.API.Models.Relations
{
    [Table("RIdentityRole")]
    public class RIdentityRole
    {
        [Key]
        public virtual int IdIdentity { get; set; }

        [Key]
        public virtual int IdRole { get; set; }

        public virtual Identity Identity { get; set; }

        public virtual Role Role { get; set; }
}
}
