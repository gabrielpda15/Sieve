using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sieve.API.Models.Base
{
    public class BaseEntityDescription : BaseEntity
    {
        [DataType("varchar")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Descrição")]
        [ScaffoldColumn(false)]
        public string Description { get; set; }
    }
}
