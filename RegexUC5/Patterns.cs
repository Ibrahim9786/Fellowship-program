using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUC5
{
    public class Patterns
    {
        public static string REGEX_PASSWORD = "^[a-z]{9}$";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
