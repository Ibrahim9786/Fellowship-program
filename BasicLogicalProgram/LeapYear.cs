using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgram
{
    class LeapYear
    {
        public void printLeapYear()
        {
            int Year;

            Console.Write("Input the Year ");

            Year = int.Parse(Console.ReadLine());

            if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
            {
                Console.WriteLine("The entered year {0} is a Leap Year", Year);
            }
            else
            {
                Console.WriteLine("The entered year {0} is not a Leap Year", Year);
            }
            Console.ReadLine();
        }
    }
}
