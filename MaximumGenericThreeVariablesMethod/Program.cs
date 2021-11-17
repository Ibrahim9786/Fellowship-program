using System;

namespace MaximumGenericThreeVariablesMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 112, 334, 432, 555, 678, 800 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintMaxValue();
        }
    }
}
