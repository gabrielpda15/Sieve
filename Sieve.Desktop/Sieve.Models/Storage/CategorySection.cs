using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Storage
{
    public class CategorySection : Base.BaseEntityDescription
    {
    }

    public class Category : CategorySection
    {
        [Required]
        [Display("Seção")]
        public virtual Section Section { get; set; }
    }
    
    public class Section : CategorySection
    {
    }
}
