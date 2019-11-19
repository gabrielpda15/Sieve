using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sieve.Models.Utility
{
    public static class CpfCnpjValidator
    {
        public static bool IsValidCPF(string cpf)
        {
            var valueValidLength = 11;
            var multipliersForFirstDigit = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multipliersForSecondDigit = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            return IsValid(cpf.Replace(".", "").Replace("-", ""), valueValidLength, multipliersForFirstDigit, multipliersForSecondDigit);
        }

        public static bool IsValidCNPJ(string cnpj)
        {
            var valueValidLength = 14;
            var multipliersForFirstDigit = new[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multipliersForSecondDigit = new[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            return IsValid(cnpj.Replace(".", "").Replace("-", "").Replace("/", ""), valueValidLength, multipliersForFirstDigit, multipliersForSecondDigit);
        }

        private static bool IsValid(
            string value,
            int valueValidLength,
            int[] multipliersForFirstDigit,
            int[] multipliersForSecondDigit)
        {
            var isInvalid =
                IsInvalidLength(value, valueValidLength) ||
                IsNotNumbersOnly(value) ||
                IsInvalidMod11(multipliersForFirstDigit, multipliersForSecondDigit, value);

            return !isInvalid;
        }

        private static bool IsInvalidLength(
            string value,
            int valueValidLength)
        {
            return value.Length != valueValidLength;
        }

        private static bool IsNotNumbersOnly(
            string value)
        {
            return !Regex.IsMatch(value, @"\d+");
        }

        private static bool IsInvalidMod11(
            int[] multipliersForFirstDigit,
            int[] multipliersForSecondDigit,
            string value)
        {
            var firstDigit = GetFirstDigit(multipliersForFirstDigit, value);
            var secondDigit = GetSecondDigit(multipliersForSecondDigit, value, firstDigit);
            var expectedSufix = string.Concat(firstDigit, secondDigit);
            var isInvalid = !value.EndsWith(expectedSufix);
            return isInvalid;
        }

        private static int GetFirstDigit(
            int[] multipliers,
            string value)
        {
            var valueToWork = value.Substring(0, multipliers.Length);
            var sum = multipliers
                .Select((d, i) => new
                {
                    Value = int.Parse(valueToWork[i].ToString()),
                    Multiplier = multipliers[i]
                })
                .Sum(d => d.Value * d.Multiplier);
            var rest = sum % 11;
            var firstDigit = rest < 2 ? 0 : 11 - rest;
            return firstDigit;
        }

        private static int GetSecondDigit(
            int[] multipliers,
            string value,
            int firstDigit)
        {
            var valueToWork = string.Concat(value.Substring(0, multipliers.Length - 1), firstDigit);
            var sum = multipliers
                .Select((d, i) => new
                {
                    Value = int.Parse(valueToWork[i].ToString()),
                    Multipler = d
                })
                .Sum(d => d.Value * d.Multipler);
            var rest = sum % 11;
            var secondDigit = rest < 2 ? 0 : 11 - rest;
            return secondDigit;
        }
    }
}
