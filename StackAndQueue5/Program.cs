using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleeTheFirstElementInList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();

            list.Add(56);
            Console.WriteLine("56 Added");

            list.Add(30);
            Console.WriteLine("30 Added");

            list.Add(70);
            Console.WriteLine("70 Added");
            Console.WriteLine("-------------");



            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");

            list.Remove(56);
            Console.WriteLine("56 removed");
            Console.WriteLine("-------------");

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}