using Sieve.Models.Person;
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
    public sealed class EntityValidator<TEntity> where TEntity : class, Base.IEntity
    {
        public EntityValidator() { }

        public PropertyValidator Property(Expression<Func<TEntity, object>> selector)
        {
            return new PropertyValidator(GetPropertyFromExpression(selector));
        }

        public IDictionary<string, IDictionary<string, string>> Validate(TEntity entity)
        {
            var result = new Dictionary<string, IDictionary<string, string>>();

            foreach (var property in typeof(TEntity).GetProperties())
            {
                if (!new PropertyValidator(property).Validate(property.GetValue(entity), out IDictionary<string, string> errors))
                    result.Add(property.Name, errors);
            }

            return result;
        }

        private PropertyInfo GetPropertyFromExpression<T, TResult>(Expression<Func<T, TResult>> propertyLambda)
        {
            MemberExpression Exp = null;

            if (propertyLambda.Body is UnaryExpression)
            {
                var UnExp = (UnaryExpression)propertyLambda.Body;
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

    public sealed class PropertyValidator
    {
        private const string STR_LEN_MAX_AND_MIN = "{0} deve ter entre {1} e {2} caracteres.";
        private const string STR_LEN_ONLY_MAX = "{0} deve ter no máximo {1} caracteres.";
        private const string REQUIRED = "{0} é um campo obrigatório!";
        private const string INVALID = "{0} inválido!";

        private static readonly Regex PHONE_REGEX = new Regex(@"^[+]{1}[(]*[0-9]{1,4}[)]* [0-9]{1,3} [-\s\./0-9]{1,10}$");
        private static readonly Regex CNPJ_REGEX = new Regex(@"^[0-9]{2}[\.]{1}[0-9]{3}[\.]{1}[0-9]{3}[\/]{1}[0-9]{4}[-]{1}[0-9]{2}$");
        private static readonly Regex CPF_REGEX = new Regex(@"[0-9]{3}[\.]{1}[0-9]{3}[\.]{1}[0-9]{3}[-]{1}[0-9]{2}");
        private static readonly Regex EMAIL_REGEX = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$");

        private PropertyInfo property;
        public PropertyValidator(PropertyInfo property)
        {
            this.property = property;
        }

        public bool Validate(object value, out IDictionary<string, string> errors)
        {
            errors = new Dictionary<string, string>();
            var name = property.GetCustomAttribute<DisplayAttribute>().Name;

            foreach (var attrib in property.GetCustomAttributes())
            {
                if (attrib is StringLengthAttribute)
                {
                    var max = (attrib as StringLengthAttribute).MaximumLength;
                    var min = (attrib as StringLengthAttribute).MinimumLength;
                    var str = value as string;

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
                        if (string.IsNullOrWhiteSpace(value as string))
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
                    if (!CPF_REGEX.IsMatch(value as string))
                    {
                        errors.Add("CPF", string.Format(INVALID, name));
                    }
                    else if (!CpfCnpjValidator.IsValidCPF(value as string))
                    {
                        errors.Add("CPF", string.Format(INVALID, name));
                    }
                }
                else if (attrib is CNPJAttribute)
                {
                    if (!CNPJ_REGEX.IsMatch(value as string))
                    {
                        errors.Add("CNPJ", string.Format(INVALID, name));
                    }
                    else if (!CpfCnpjValidator.IsValidCNPJ(value as string))
                    {
                        errors.Add("CNPJ", string.Format(INVALID, name));
                    }
                }
                else if (attrib is PhoneAttribute)
                {
                    if (!PHONE_REGEX.IsMatch(value as string))
                    {
                        errors.Add("Phone", string.Format(INVALID, name));
                    }
                }
                else if (attrib is EmailAttribute)
                {
                    if (!EMAIL_REGEX.IsMatch(value as string))
                    {
                        errors.Add("Email", string.Format(INVALID, name));
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
