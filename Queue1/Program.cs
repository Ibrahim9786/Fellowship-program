using System;

namespace Queue1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue list = new LinkedListQueue();
            list.Enqueue(56);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Display();

            Console.ReadKey();
        }
    }
}
