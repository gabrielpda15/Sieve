using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Models.Extensions
{
    public static class StringExtension
    {
        public static bool IsNothing(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static string[] Split(this string str, string separator, StringSplitOptions options = StringSplitOptions.None)
        {
            return str.Split(new string[] { separator }, options);
        }
    }
}
