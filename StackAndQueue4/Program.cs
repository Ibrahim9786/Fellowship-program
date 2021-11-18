using System;

namespace StackAndQueue4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine("Initially");
            list.Add(56);
            list.Add(70);
            list.Display();

            Console.WriteLine("-------------------------");


            Console.WriteLine("After inserting 30 between 56 and 70");
            list.InsertAtPerticularPosition(2, 30);
            list.Display();

            Console.WriteLine("After inserting 30 between 56 and 70");
            list.Add(1, 70);
            list.Display();

            Console.ReadKey();
        }
    }
}
