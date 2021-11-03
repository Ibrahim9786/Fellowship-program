using System;

namespace LogicalPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
        Label: Console.WriteLine("1.Fibonacci Series \n 2.Perfect number \n 3.Prime number \n 4.Reverse a number");
            Console.WriteLine("Type the option");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("1.print the Fibonacci Series ");
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.printFibonacciSeries();
                    break;

                case 2:
                    Console.WriteLine("1.print the Perfect number ");
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.printPerfectNumber();
                    break;

                case 3:
                    Console.WriteLine("1.print the Prime number ");
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.printPrimeNumber();
                    break;

                case 4:
                    Console.WriteLine("1.print the Reverse a number ");
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.printReverseNumber();
                    break;



                default:
                    Console.WriteLine("invalid option");
                    break;

            }
            Console.WriteLine("Do yoy want to continue,, y/n");
            if (Console.ReadKey().KeyChar.ToString() == "y")
            {
                goto Label;
            }

            Console.ReadKey();
        }
    }
}
