using System;

namespace Addition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator ojcCalculator = new Calculator();
            Console.WriteLine("total value=" + ojcCalculator.isSum(30,20));
            Console.ReadKey();
        }
    }
}
