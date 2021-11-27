using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUC8
{
    public class Pattern
    {
        public static string REGEX_PASSWORD = "^[A-Za-z]{9}[@]{1}[0-9]{2}$";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
