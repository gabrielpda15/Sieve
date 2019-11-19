using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Models.Utility
{
    public class AddressAttribute : ValidationAttribute
    {
        public AddressAttribute() : base() { }
    }

    public class CEPAttribute : ValidationAttribute
    {
        public CEPAttribute() : base() { }
    }

    public class CPFAttribute : ValidationAttribute
    {
        public CPFAttribute() : base() { }
    }

    public class CNPJAttribute : ValidationAttribute
    {
        public CNPJAttribute() : base() { }
    }

    public class EmailAttribute : ValidationAttribute
    {
        public EmailAttribute() : base() { }
    }

    public class PhoneAttribute : ValidationAttribute
    {
        public PhoneAttribute() : base() { }
    }

    public class RequiredAttribute : ValidationAttribute
    {
        public RequiredAttribute() : base() { }
    }

    public class StringLengthAttribute : ValidationAttribute
    {
        public int MaximumLength { get; private set; }
        public int MinimumLength { get; set; }

        public StringLengthAttribute(int maxLength) : base() 
        {
            this.MaximumLength = maxLength;
        }
    }

    public class DisplayAttribute : Attribute
    {
        public string Name { get; private set; }

        public DisplayAttribute(string name) : base()
        {
            this.Name = name;
        }
    }

    public class ValidationAttribute : Attribute
    {
        public string ErrorMessage { get; set; }

        public ValidationAttribute() : base() { }
    }
}
