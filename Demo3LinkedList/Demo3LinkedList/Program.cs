using System;

namespace Demo3LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.pushFront(3);
            list.pushFront(4);
            list.pushFront(5);
            list.printHead2Tail();
        }
    }
}
