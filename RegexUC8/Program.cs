using System;

namespace RegexUC8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            //given as exactly 1 special character in the password
            string patt = "Passwords@98";
            Pattern pattern = new Pattern();
            checkvalue = pattern.validatePassword(patt);

            if (checkvalue)
            {
                Console.WriteLine("Pattern matched and correct");
            }
            else
            {
                Console.WriteLine("Not matched");
            }
        }
    }
}
