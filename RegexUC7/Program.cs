using System;

namespace RegexUC7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            //for the same adding two numerics
            //given as atleast one numerics to add
            string patt = "Passwords98";
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
