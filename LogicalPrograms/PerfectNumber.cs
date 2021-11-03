using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public void printPerfectNumber()
        {
            int num = 496;
            int i = 1;
            int total = 0;

            for (i = 1; i < num; i++)
            {
                if (num % i == 0)
                    total += i;
            }
            if (total == num)
                Console.Write("{0} is a perfect number", num);
            else
                Console.Write("{0} is not a perfect number", num);
        }
    }
}
