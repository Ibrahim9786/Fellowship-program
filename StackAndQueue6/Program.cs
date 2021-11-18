using StackAndQueue5;
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

            LinkedList StartNode = new LinkedList(56);

            LinkedList n1;
            LinkedList n2;

            n1 = StartNode.AddItem(30);
            n2 = n1.AddItem(70);

            Console.WriteLine("List before deletion:");
            StartNode.ListTraverse();

            StartNode.DeleteNode(n2);
            Console.WriteLine("List after deletion of last element:");
            StartNode.ListTraverse();

        }
    }
}