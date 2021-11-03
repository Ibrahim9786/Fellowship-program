using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public void printPrimeNumber()
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("Number is Prime.");
            }
            else
            {
                Console.Write("Number is not Prime.");
            }
            Console.ReadKey();
        }
    }
}
