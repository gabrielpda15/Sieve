using Sieve.Models.Security;
using Sieve.Models.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.Models.Person
{
    public class Employee : Base.BaseEntity, INaturalPerson
    {
        public enum EmployeeStatus
        {
            None = 0, Working = 1, Fired = 2, Vacation = 3, Leave = 4
        }

        [Required]
        [StringLength(14)]
        [Display("CTPS")]
        public string CTPS { get; set; }

        [Required]
        [Display("Salário")]
        public double? Salary { get; set; }

        [CPF]
        [Required]
        [StringLength(14)]
        [Display("CPF")]
        public string CPF { get; set; }

        [Required]
        [StringLength(30)]
        [Display("Nome")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(80)]
        [Display("Sobrenome")]
        public string LastName { get; set; }

        public DateTime? Birthday { get; set; }

        [Required]
        [StringLength(255)]
        [Display("Endereço")]
        public string Address { get; set; }

        [Phone]
        [StringLength(22)]
        [Display("Telefone")]
        public string PhoneNumber { get; set; }

        [Email]
        [StringLength(14)]
        [Display("Email")]
        public string Email { get; set; }

        [Required]
        [Display("Status")]
        public EmployeeStatus Status { get; set; } = EmployeeStatus.None;

        [Required]
        [StringLength(80)]
        [Display("Cargo")]
        public string JobRole { get; set; }

        [Required]
        [Display("Identidade")]
        public virtual Identity Identity { get; set; }
    }
}
