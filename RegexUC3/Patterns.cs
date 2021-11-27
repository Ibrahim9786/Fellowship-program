using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUC3
{
    public class Patterns
    {
        public static string REGEX_EMAIL = "^[a-z]{3}[.]{1}[a-z]{3}[@]{1}[a-z]{2}[.]{1}[a-z]{2}[.]{1}[a-z]{2}$";

        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}
