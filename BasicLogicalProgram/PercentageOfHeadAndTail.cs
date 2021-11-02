using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class PercentageOfHeadAndTail
    {
        public void printHaidAndTail()
        {
            int head = 0;
            int tail = 0;
            int CoinResult = 0;

            Random random = new Random();

            Console.WriteLine("Enter the input of coin flip");

            int readInputFromUserNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < readInputFromUserNum; i++)
            {
                CoinResult = random.Next(0, 2);
                if (CoinResult == 0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }
            double resultHead = (head * 100) / readInputFromUserNum;
            double resultTail = (tail * 100) / readInputFromUserNum;

            Console.WriteLine("Head is flip" + resultHead);
            Console.WriteLine("Tail is flip" + resultTail);
        }
    }
}
