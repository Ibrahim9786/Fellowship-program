using System;

namespace RegexUC3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            string patt = "abc.xyz@bl.co.in";
            Patterns pattern = new Patterns();
            checkvalue = pattern.validateEmail(patt);

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
