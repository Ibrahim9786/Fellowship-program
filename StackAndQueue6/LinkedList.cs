using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue5
{
    public class LinkedList
    {
        private int item;
        private LinkedList next;

        public LinkedList(int value)
        {
            item = value;
            next = null;
        }
        public LinkedList AddItem(int value)
        {
            LinkedList node = new LinkedList(value);
            if (this.next == null)
            {
                node.next = null;
                this.next = node;
            }
            else
            {
                LinkedList temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }
        public void ListTraverse()
        {
            LinkedList node = this;

            while (node != null)
            {
                Console.WriteLine("-->" + node.item);
                node = node.next;
            }
        }

        public void DeleteNode(LinkedList given)
        {
            LinkedList node = this;

            while (node != null)
            {
                if (node.next == given)
                {
                    node.next = given.next;
                    break;
                }
                node = node.next;
            }
        }
    }
}