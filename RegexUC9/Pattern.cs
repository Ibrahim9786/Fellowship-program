using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUC9
{
    public class Pattern
    {
        public static string REGEX_PASSWORD = "^[a-z]{3}[@]{1}[a-z]{5}[.]{1}[a-z]{3}$";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
