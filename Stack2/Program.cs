using System;

namespace Stack2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack list = new LinkedListStack();

            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();
            list.Peak();
            list.Pop();
            list.Display();
            list.IsEmpty();
            list.Display();

            Console.ReadKey();
        }
    }
}
