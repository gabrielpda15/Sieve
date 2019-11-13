using System.ComponentModel.DataAnnotations;

namespace Sieve.Models.Base
{
    public class BaseEntityDescription : BaseEntity
    {
        [Required]
        [DataType("varchar")]
        [StringLength(255)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
    }
}
