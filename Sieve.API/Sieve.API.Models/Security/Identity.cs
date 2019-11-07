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
        [Required(ErrorMessage = "Usuário é obrigatório")]
        [StringLength(30, ErrorMessage = "Usuário deve ter no máximo 30 caracteres")]
        [Display(Name = "Usuário")]
        public string Username { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Senha é obrigatória")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Senha deve ter no máximo 30 caracteres")]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType("varchar")]
        [Required(ErrorMessage = "Hash da senha é obrigatório")]
        [StringLength(255, ErrorMessage = "Hash da senha deve ter no máximo 255 caractéres")]
        public string PasswordHash { get; set; }

        [DataType("varchar")]
        [StringLength(80, ErrorMessage = "Email deve ter no máximo 80 caracteres")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
