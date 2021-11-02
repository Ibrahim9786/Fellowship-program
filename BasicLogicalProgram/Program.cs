using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
        Label: Console.WriteLine("1.print the percentage coin flip \n 2.Leap year \n 3.Power of Two \n 4.Harmonic Number \n 5.Factors \n 6.Quotient and Remainder \n 7.Swapping \n 8.Even or Odd \n 9.Vowels or Consonants \n 10.Largest number among three");
            Console.WriteLine("Type the option");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("1.print the percentage coin flip ");
                    PercentageOfHeadAndTail percentageOfHeadAndTail = new PercentageOfHeadAndTail();
                    percentageOfHeadAndTail.printHaidAndTail();
                    break;

                case 2:
                    Console.WriteLine("2.Leap year");
                    LeapYear leapYear = new LeapYear();
                    leapYear.printLeapYear();
                    break;

                case 3:
                    Console.WriteLine("3.Power of Two");
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.printPowerOfTwo();
                    break;


                case 4:
                    Console.WriteLine("4.Harmonic number");
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.printHarmonicNumber();
                    break;

                case 5:
                    Console.WriteLine("5.Factor");
                    Factors factors = new Factors();
                    factors.printFactors();
                    break;

                case 6:
                    Console.WriteLine("6.Quotient and Remainder");
                    QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                    quotientAndRemainder.printQuotientAndRemainder();
                    break;

                case 7:
                    Console.WriteLine("7.Swapping");
                    Swapping swapping = new Swapping();
                    swapping.printSwapping();
                    break;

                case 8:
                    Console.WriteLine("8.Even or Odd");
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.printEvenOrOdd();
                    break;

                case 9:
                    Console.WriteLine("9.Vowels or Consonants");
                    VowelsOrConsonants vowelsOrConsonants = new VowelsOrConsonants();
                    vowelsOrConsonants.printVowelsOrConsonants();
                    break;

                case 10:
                    Console.WriteLine("10.Largest number among three");
                    LargestNumberAmongThree largestNumberAmongThree = new LargestNumberAmongThree();
                    largestNumberAmongThree.printLargestNUmberAmongThree();
                    break;

                default:
                    Console.WriteLine("invalid option");
                    break;

            }
            Console.WriteLine("Do yoy want to continue,, y/n");
            if (Console.ReadKey().KeyChar.ToString() == "y") ;
            {
                goto Label;
            }

            Console.ReadKey();
        }
    }
}
