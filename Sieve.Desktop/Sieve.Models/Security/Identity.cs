using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Security
{
    public class Identity : Base.BaseEntity
    {
        [Required]
        [StringLength(30)]
        [Display("Usuário")]
        public string Username { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 8)]
        [Display("Senha")]
        public string Password { get; set; }

        public string PasswordHash { get; set; }

        [Email]
        [StringLength(80)]
        [Display("Email")]
        public string Email { get; set; }
    }
}
