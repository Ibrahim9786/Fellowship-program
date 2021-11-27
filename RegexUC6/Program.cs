using System;

namespace RegexUC6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            //in the question given atleast 1 uppercase
            //among 9 characters, representing P as a uppercase here
            //we can also change it to more than 1 uppercase
            string patt = "PasswordS";
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
