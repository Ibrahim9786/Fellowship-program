using SimpleLinkedList;
using System;
using System.Collections.Generic;

namespace StackAndQueue2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Display();


            Console.WriteLine("----------------");

            list.Add(30);
            list.Display();

            Console.WriteLine("----------------");

            list.Add(56);
            list.Display();

            Console.WriteLine("----------------");

            Console.ReadKey();
        }
    }
}
