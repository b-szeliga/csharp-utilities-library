using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtilitiesLibrary
{
    public static class StringLib
    {
        public static string Capitalize(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }

        public static bool ValidatePESEL(this string str)
        {
            string pattern = @"^\d{11}$";
            Regex rg = new Regex(pattern);
            return rg.IsMatch(str);
        }

        public static bool ValidatePhone(this string str)
        {
            string pattern = @"(?<!\w)(\(?(\+|00)?48\)?)?[ -]?\d{3}[ -]?\d{3}[ -]?\d{3}(?!\w)";
            Regex rg = new Regex(pattern);
            return rg.IsMatch(str);
        }

        public static bool ValidateEmail(this string str)
        {
            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                            + "@"
                            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            Regex rg = new Regex(pattern);
            return rg.IsMatch(str);
        }
    }
}
