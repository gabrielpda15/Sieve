using Sieve.Models.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sieve.Models
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
                result.Add(property.Name, new PropertyValidator(property).Validate(property.GetValue(entity)));
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


        private PropertyInfo property;
        public PropertyValidator(PropertyInfo property)
        {
            this.property = property;
        }

        public IDictionary<string, string> Validate(object value)
        {
            var result = new Dictionary<string, string>();
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
                            result.Add("StringLength", string.Format(STR_LEN_MAX_AND_MIN, name, min, max));
                        }
                    }
                    else
                    {
                        if (str.Length > max)
                        {
                            result.Add("StringLength", string.Format(STR_LEN_ONLY_MAX, name, max));
                        }
                    }
                } 
                else if (attrib is RequiredAttribute)
                {
                    if (property.PropertyType == typeof(string))
                    {
                        if (string.IsNullOrWhiteSpace(value as string))
                        {
                            result.Add("Required", string.Format(REQUIRED, name));
                        }
                    }
                    else
                    {
                        if (value == null)
                        {
                            result.Add("Required", string.Format(REQUIRED, name));
                        }
                    }
                }
            }

            return result;
        }
    }
}
