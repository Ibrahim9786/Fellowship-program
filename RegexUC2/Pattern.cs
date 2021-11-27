using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUC2
{
    public class Pattern
    {
        public static string REGEX_FULLNAME = "^[V]{1}[a-z]{4}[ ]{1}[K]{1}[a-z]{4}";

        public bool validateFullname(string fullname)
        {
            return Regex.IsMatch(fullname, REGEX_FULLNAME);
        }
    }
}
