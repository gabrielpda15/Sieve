using Sieve.API.Models.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.API.Models.Security
{
    [Table("Identity")]
    public class Identity : Base.BaseEntity
    {
        [DataType("varchar")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Usuário")]
        public string Username { get; set; }

        [NotMapped]
        [Required]
        [StringLength(30, MinimumLength = 8)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType("varchar")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Hash da senha")]
        public string PasswordHash { get; set; }

        [DataType("varchar")]
        [StringLength(80)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        public virtual IList<RIdentityRole> Roles { get; set; }
    }
}
