using System;

namespace RegexUc1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            //below given as fullname and in that first name starts with Cap
            string patt = "Virat kohli";
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
