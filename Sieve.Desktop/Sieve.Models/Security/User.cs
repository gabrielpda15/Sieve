using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Models.Security
{
    public class User
    {
        [Required]
        [StringLength(30)]
        [Display("Usuário")]
        public string Username { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 8)]
        [Display("Senha")]
        public string Password { get; set; }
    }
}
