using System;

namespace RegexUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            //below given as fullname and in that last name starts with Cap
            //no instruction given for first name thats why it remain as Cap
            string patt = "Virat Kohli";
            Pattern pattern = new Pattern();
            checkvalue = pattern.validateFullname(patt);

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
