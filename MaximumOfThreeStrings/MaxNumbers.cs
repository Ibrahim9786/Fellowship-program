using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximunOfThreeStrings
{
    public class MaxNumbers
    {
        public static void maxNumbers()
        {
            string char1 = "Apple";
            string char2 = "Peach";
            string char3 = "Banana";

            if (char1.CompareTo(char2) > 0 && char1.CompareTo(char3) > 0 ||
               char1.CompareTo(char2) >= 0 && char1.CompareTo(char3) > 0 ||
                char1.CompareTo(char2) > 0 && char1.CompareTo(char3) >= 0)
            {
                Console.WriteLine("char 1 is greater: " + char1);
            }

            if (char2.CompareTo(char1) > 0 && char2.CompareTo(char3) > 0 ||
               char2.CompareTo(char1) >= 0 && char2.CompareTo(char3) > 0 ||
                char2.CompareTo(char1) > 0 && char2.CompareTo(char3) >= 0)
            {
                Console.WriteLine("char 2 is greater: " + char2);
            }

            if (char3.CompareTo(char1) > 0 && char3.CompareTo(char2) > 0 ||
               char3.CompareTo(char1) >= 0 && char3.CompareTo(char2) > 0 ||
                char3.CompareTo(char1) > 0 && char3.CompareTo(char2) >= 0)
            {
                Console.WriteLine("char 3 is greater: " + char3);
            }
            Console.ReadKey();
        }
    }
}
