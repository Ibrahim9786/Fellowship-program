using System;
using System.Collections.Generic;
using System.Text;

namespace MaximunOfThreeIntegers
{
    public class MaxNumber
    {
        public static void maxNumber()
        {
            int num1 = 80;
            int num2 = 100;
            int num3 = 15;

            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 ||
               num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 ||
                num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                Console.WriteLine("num 1 is greater i.e., " + num1);
            }

            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 ||
               num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 ||
                num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                Console.WriteLine("num 2 is greater i.e., " + num2);
            }

            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 ||
               num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 ||
                num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
            {
                Console.WriteLine("num 3 is greater i.e., " + num3);
            }
            Console.ReadKey();
        }
    }
}
