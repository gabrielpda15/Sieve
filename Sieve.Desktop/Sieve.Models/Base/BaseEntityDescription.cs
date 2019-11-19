using Sieve.Models.Utility;

namespace Sieve.Models.Base
{
    public class BaseEntityDescription : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Display("Descrição")]
        public string Description { get; set; }
    }
}
