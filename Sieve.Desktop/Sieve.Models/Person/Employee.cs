using Sieve.Models.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DataType("varchar")]
        [StringLength(14)]
        [Display(Name = "CTPS")]
        public string CTPS { get; set; }

        [Required]
        [Display(Name = "Salário")]
        public double Salary { get; set; }

        [CPF]
        [Required]
        [DataType("varchar")]
        [StringLength(14)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(30)]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(80)]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        public DateTime? Birthday { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(255)]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Phone]
        [DataType("varchar")]
        [StringLength(22)]
        [Display(Name = "Telefone")]
        public string PhoneNumber { get; set; }

        [Email]
        [DataType("varchar")]
        [StringLength(14)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public EmployeeStatus Status { get; set; }

        [Required]
        [DataType("varchar")]
        [StringLength(80)]
        [Display(Name = "Cargo")]
        public string JobRole { get; set; }

        [Required]
        [Display(Name = "Identidade")]
        public virtual Identity Identity { get; set; }
    }
}
