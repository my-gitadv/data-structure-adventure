using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3LinkedList
{
    internal class LinkedList
    {
        public Node head;

        public void pushFront(int key)
        {
            Node tmp = new Node(key);
            if( head == null)
            {
                head = tmp;
            }
            else
            {
                tmp.next = head;
                head = tmp;
            }

        }

        public void printHead2Tail()
        {
            Node current = head;
            while( current != null )
            {
                Console.Write(current.key + " -> ");
                current = current.next;
            }
        }
    }
}
