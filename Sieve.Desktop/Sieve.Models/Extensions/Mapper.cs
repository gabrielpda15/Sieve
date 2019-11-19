using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Models.Extensions
{
    internal static class Mapper
    {
        public static TOutput Map<TInput, TOutput>(this TInput input, Func<TInput, TOutput> mapper)
        {
            return mapper(input);
        }
    }
}
