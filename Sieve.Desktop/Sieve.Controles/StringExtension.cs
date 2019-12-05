using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve.Controles
{
    public static class StringExtension
    {
        public enum MaskType { None, Money, CPF, CNPJ, Phone }

        public static string Format(this string value, MaskType mask)
        {
            string newValue;
            int j;
            switch (mask)
            {
                case MaskType.Money: // R$ 12.354,00
                    j = 0;
                    newValue = "";
                    for (int i = value.Length - 1; i >= 0; i--)
                    {
                        newValue += value[i];

                        if (i < value.Length - 3)
                        {
                            if (++j == 3)
                            {
                                j = 0;
                                newValue += '.';
                            }
                        }
                    }
                    newValue += " $R";

                    return new string(newValue.Reverse().ToArray());
                case MaskType.Phone: // (14) 92315-5445
                    var temp = string.Format("({0}) {1}", new string(value.Take(2).ToArray()), new string(value.Skip(2).ToArray()));
                    newValue = "";
                    for (int i = temp.Length - 1; i >= 0; i--)
                    {
                        newValue += temp[i];
                        if (i == temp.Length - 4) newValue += '-';
                    }
                    return new string(newValue.Reverse().ToArray());
                case MaskType.CPF: // 123.456.789-65
                    j = 0;
                    newValue = "";
                    for (int i = value.Length - 1; i >= 0; i--)
                    {
                        newValue += value[i];

                        if (i == value.Length - 2) newValue += '-';

                        if (i < value.Length - 2)
                        {
                            if (++j == 3 && i != 0)
                            {
                                j = 0;
                                newValue += '.';
                            }
                        }
                    }
                    return new string(newValue.Reverse().ToArray());
                case MaskType.CNPJ: // 49.383.925/0001-58
                    j = 0;
                    newValue = "";
                    for (int i = value.Length - 1; i >= 0; i--)
                    {
                        newValue += value[i];

                        if (i == value.Length - 2) newValue += '-';

                        if (i == value.Length - 6) newValue += '/';

                        if (i < value.Length - 6)
                        {
                            if (++j == 3 & i != 0)
                            {
                                j = 0;
                                newValue += '.';
                            }
                        }

                    }
                    return new string(newValue.Reverse().ToArray());
                default:
                    return value;
            }
        }

        public static string Unformat(this string value, MaskType type)
        {
            switch (type)
            {
                case MaskType.Money:
                    return value.Replace("R$ ", "").Replace(".", "");
                case MaskType.Phone:
                    return value.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                case MaskType.CPF:
                    return value.Replace(".", "").Replace("-", "");
                case MaskType.CNPJ:
                    return value.Replace(".", "").Replace("-", "").Replace("/", "");
                default:
                    return value;
            }
        }


    }
}
