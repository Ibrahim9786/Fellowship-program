using System;

namespace NlogApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nlog");
            Addition addition = new Addition();
            Addition.Add(20, 55);
            Console.ReadKey();
        }
    }
}
