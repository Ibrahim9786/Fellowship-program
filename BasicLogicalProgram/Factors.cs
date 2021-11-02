using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgram
{
    class Factors
    {
        public void printFactors()
        {
            int a, b;
            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + a);
                }
            }
            Console.ReadLine();



        }
    }
}
