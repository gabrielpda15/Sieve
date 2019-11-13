using System;

namespace Sieve.Models.Base
{
    public interface IEntity
    {
        int Id { get; set; }
        string CreationUser { get; set; }
        string EditionUser { get; set; }
        DateTime? CreationDate { get; set; }
        DateTime? EditionDate { get; set; }        
    }
}
