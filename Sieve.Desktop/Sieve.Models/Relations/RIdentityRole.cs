using Sieve.Models.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Relations
{
    public class RIdentityRole
    {
        public virtual int IdIdentity { get; set; }

        public virtual int IdRole { get; set; }

        public virtual Identity Identity { get; set; }

        public virtual Role Role { get; set; }
}
}
