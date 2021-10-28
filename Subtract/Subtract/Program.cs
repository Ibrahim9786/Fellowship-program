using System;

namespace Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Sub ojcSub = new Sub();
            Console.WriteLine("result=" + ojcSub.isSubtract(30,22));
            Console.ReadKey();
        }
    }
}
