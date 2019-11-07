using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sieve.API.Models.Base
{
    public class BaseEntityDescription : BaseEntity
    {
        [DataType("varchar")]
        [Required(ErrorMessage = "Descrição é obrigatório")]
        [StringLength(255, ErrorMessage = "Descrição deve ter no máximo 255 caracteres")]
        [Display(Name = "Descrição")]
        [ScaffoldColumn(false)]
        public string Description { get; set; }
    }
}
