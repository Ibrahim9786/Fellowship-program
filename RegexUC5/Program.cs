using System;

namespace RegexUC5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            //In the question, they only mention that minimum 8 characters
            //here using 9 characters
            string patt = "passwords";
            Patterns pattern = new Patterns();
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
