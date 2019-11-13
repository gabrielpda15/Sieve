using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sieve.Models.Storage
{
    [Table("CategorySection")]
    public class CategorySection : Base.BaseEntityDescription
    {
    }

    public class Category : CategorySection
    {
        [Required]
        [Display(Name = "Seção")]
        public virtual Section Section { get; set; }
    }
    
    public class Section : CategorySection
    {
    }
}
