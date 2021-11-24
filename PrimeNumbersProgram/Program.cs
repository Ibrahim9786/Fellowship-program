using System;

namespace PrimeNumbersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, ctr, strno, eeno;

            strno = 0;
            eeno = 1000;

            Console.WriteLine("The prime numbers between {0} and {1} are : \n", strno, eeno);

            for (num = strno; num <= eeno; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                {
                    Console.Write("{0}\n", num);
                }

            }
            Console.Write("\n");

        }

    }
}