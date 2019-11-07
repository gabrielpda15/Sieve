using Sieve.API.Models.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Models.Person
{
    public class Employee : Base.BaseEntity, INaturalPerson
    {
        public enum EmployeeStatus
        {

        }

        public string CTPS { get; set; }
        public double Salary { get; set; }
        public string CPF { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public EmployeeStatus Status { get; set; }
        public string JobRole { get; set; }
        public virtual Identity Identity { get; set; }
    }
}
