using System;

namespace RegexUC4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            string patt = "91 9919819801";
            Pattern pattern = new Pattern();
            checkvalue = pattern.validateMobile(patt);

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
