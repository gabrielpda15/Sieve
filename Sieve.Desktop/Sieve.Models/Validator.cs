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
        private PropertyInfo property;
        public PropertyValidator(PropertyInfo property)
        {
            this.property = property;
        }

        public IDictionary<string, string> Validate(object value)
        {
            var result = new Dictionary<string, string>();

            foreach (var attrib in property.GetCustomAttributes())
            {
                if (attrib is StringLengthAttribute)
                {

                } 
                else if (attrib is RequiredAttribute)
                {

                }
            }

            return result;
        }
    }
}
