using Newtonsoft.Json;
using Sieve.Models.Person;
using Sieve.Models.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sieve.Models.Utility
{
    public sealed class EntityValidator<TEntity> where TEntity : class
    {
        public EntityValidator() { }

        public PropertyValidator<TEntity> Property(Expression<Func<TEntity, object>> selector)
        {
            return new PropertyValidator<TEntity>(GetPropertyFromExpression(selector));
        }

        public bool Validate(TEntity entity, out IDictionary<string, IDictionary<string, string>> errors)
        {
            errors = new Dictionary<string, IDictionary<string, string>>();

            foreach (var property in typeof(TEntity).GetProperties())
            {
                if (!new PropertyValidator<TEntity>(property).Validate(entity, out var propErrors))
                    errors.Add(property.Name, propErrors);
            }

            if (errors.Count > 0)
            {
                return false;
            }
            else
            {
                errors = null;
                return true;
            }
        }

        private PropertyInfo GetPropertyFromExpression<T, TResult>(Expression<Func<T, TResult>> propertyLambda)
        {
            MemberExpression Exp;

            if (propertyLambda.Body is UnaryExpression UnExp)
            {
                if (UnExp.Operand is MemberExpression)
                {
                    Exp = (MemberExpression)UnExp.Operand;
                }
                else
                    throw new ArgumentException();
            }
            else if (propertyLambda.Body is MemberExpression)
            {
                Exp = (MemberExpression)propertyLambda.Body;
            }
            else
            {
                throw new ArgumentException();
            }

            return (PropertyInfo)Exp.Member;
        }
    }

    public sealed class PropertyValidator<TEntity> where TEntity : class
    {
        private const string STR_LEN_MAX_AND_MIN = "{0} deve ter entre {1} e {2} caracteres.";
        private const string STR_LEN_ONLY_MAX = "{0} deve ter no máximo {1} caracteres.";
        private const string REQUIRED = "{0} é um campo obrigatório!";
        private const string INVALID = "{0} inválido!";

        private static readonly Regex PHONE_REGEX = new Regex(@"^[+]{1}[(]*[0-9]{1,4}[)]* [0-9]{1,3} [-\s\./0-9]{1,10}$");
        private static readonly Regex CNPJ_REGEX = new Regex(@"^[0-9]{2}[\.]{1}[0-9]{3}[\.]{1}[0-9]{3}[\/]{1}[0-9]{4}[-]{1}[0-9]{2}$");
        private static readonly Regex CPF_REGEX = new Regex(@"[0-9]{3}[\.]{1}[0-9]{3}[\.]{1}[0-9]{3}[-]{1}[0-9]{2}");
        private static readonly Regex EMAIL_REGEX = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$");

        private readonly PropertyInfo property;
        public PropertyValidator(PropertyInfo property)
        {
            this.property = property;
        }

        public bool Validate(TEntity entity, out IDictionary<string, string> errors)
        {
            errors = new Dictionary<string, string>();
            var value = this.property.GetValue(entity);
            var name = property.GetCustomAttribute<DisplayAttribute>()?.Name;

            foreach (var attrib in property.GetCustomAttributes())
            {
                if (attrib is StringLengthAttribute)
                {
                    var max = (attrib as StringLengthAttribute).MaximumLength;
                    var min = (attrib as StringLengthAttribute).MinimumLength;
                    var str = value != null ? (string)value : "";

                    if (min != 0)
                    {
                        if (!(str.Length >= min && str.Length <= max))
                        {
                            errors.Add("StringLength", string.Format(STR_LEN_MAX_AND_MIN, name, min, max));
                        }
                    }
                    else
                    {
                        if (str.Length > max)
                        {
                            errors.Add("StringLength", string.Format(STR_LEN_ONLY_MAX, name, max));
                        }
                    }
                } 
                else if (attrib is RequiredAttribute)
                {
                    if (property.PropertyType == typeof(string))
                    {
                        if (string.IsNullOrWhiteSpace((string)value))
                        {
                            errors.Add("Required", string.Format(REQUIRED, name));
                        }
                    }
                    else if (property.PropertyType.BaseType == typeof(Enum))
                    {
                        if ((int)value == 0)
                        {
                            errors.Add("Required", string.Format(REQUIRED, name));
                        }
                    }
                    else
                    {
                        if (value == null)
                        {
                            errors.Add("Required", string.Format(REQUIRED, name));
                        }
                    }
                }
                else if (attrib is CPFAttribute)
                {
                    var str = value != null ? (string)value : "";
                    if (!CPF_REGEX.IsMatch(str))
                    {
                        errors.Add("CPF", string.Format(INVALID, name));
                    }
                    else if (!CpfCnpjValidator.IsValidCPF(str))
                    {
                        errors.Add("CPF", string.Format(INVALID, name));
                    }
                }
                else if (attrib is CNPJAttribute)
                {
                    var str = value != null ? (string)value : "";
                    if (!CNPJ_REGEX.IsMatch(str))
                    {
                        errors.Add("CNPJ", string.Format(INVALID, name));
                    }
                    else if (!CpfCnpjValidator.IsValidCNPJ(str))
                    {
                        errors.Add("CNPJ", string.Format(INVALID, name));
                    }
                }
                else if (attrib is PhoneAttribute)
                {
                    if (!PHONE_REGEX.IsMatch(value != null ? (string)value : ""))
                    {
                        errors.Add("Phone", string.Format(INVALID, name));
                    }
                }
                else if (attrib is EmailAttribute)
                {
                    if (!EMAIL_REGEX.IsMatch(value != null ? (string)value : ""))
                    {
                        errors.Add("Email", string.Format(INVALID, name));
                    }
                }
                else if (attrib is CEPAttribute)
                {
                    var postalCodes = JsonConvert.DeserializeObject<IDictionary<string, string>>(Properties.Resources.PostalCodes);
                    var country = ((string)value)?.Split("=>")[0];
                    var code = ((string)value)?.Split("=>")[1];

                    Regex regex;
                    if (postalCodes.ContainsKey(country.ToUpper()))
                        regex = new Regex(postalCodes[country.ToUpper()]);
                    else
                        regex = new Regex(postalCodes["US"]);

                    if (!regex.IsMatch(code))
                    {
                        errors.Add("CEP", string.Format(INVALID, name));
                    }
                }
                else if (attrib is AddressAttribute)
                {
                    var val = new EntityValidator<Address>();
                    if (!val.Validate((Address)value, out var adrsErrors))
                    {
                        errors.Add("Address", string.Format(INVALID, name));
                    }

                }
            }

            if (errors.Count > 0)
            {
                return false;
            }
            else
            {
                errors = null;
                return true;
            }
        }
    }
}
