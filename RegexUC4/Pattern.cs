using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUC4
{
    public class Pattern
    {
        public static string REGEX_MOBILE = "^[1-9]{2}[ ]{1}[0-9]{10}$";

        public bool validateMobile(string mobile)
        {
            return Regex.IsMatch(mobile, REGEX_MOBILE);
        }
    }
}
