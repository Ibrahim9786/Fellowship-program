using System;

namespace RegexUC9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkvalue;
            //given as exactly 1 special character in the password


            // A.Valid Emails
            //1.abc@yahoo.com,
            //2.abc - 100@yahoo.com,
            //3.abc.100@yahoo.com
            //2.abc111@abc.com,
            //4.abc - 100@abc.net,
            //5.abc.100@abc.com.au
            //6.abc@1.com,
            //7.abc@gmail.com.com
            //8.abc + 100@gmail.com


            //            B.Invalid Emails(TLD -Top Level Domains)
            //1.abc – must contains “@” symbol
            //2.abc@.com.my – tld can not start with dot “.”
            //3.abc123@gmail.a – “.a” is not a valid tld, last tld must contains at least two
            //characters
            //4.abc123@.com – tld can not start with dot “.”
            //5.abc123@.com.com – tld can not start with dot “.”
            //6. .abc@abc.com – email’s 1st character can not start with “.”
            //7.abc() * @gmail.com – email’s is only allow character, digit, underscore and dash
            //8.abc@% *.com – email’s tld is only allow character and digit
            //9.abc..2002@gmail.com – double dots “.” are not allow
            //10.abc.@gmail.com – email’s last character can not end with dot “.”
            //11.abc@abc @gmail.com – double “@” is not allow
            //12.abc@gmail.com.1a - email’s tld which has two characters can not contains digit
            //13.abc@gmail.com.aa.au - cannont have multiple email’s tld

            //i have clear all the above valid and invalid emails
            //so Im checking 1.abc@yahoo.com - this valid email only


            string patt = "abc@yahoo.com";
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
