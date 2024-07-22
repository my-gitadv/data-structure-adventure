using System;
public class Queue : List
{
    // Implement Queue using Linked List with tail
    Node head;
    Node tail;

    public void push(Node node)
    {
        if (head == null)
        {
            tail = node;
            head = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
    }

    public void pop()
    {
        if (head != null)
        {
            if (head != tail)
            {
                head = head.next;
            }
            else
            {
                head = null;
                tail = null;
            }
        }
        else
        {
            Console.WriteLine("Error: Queue Underflow");
        }
    }

    public Node top()
    {
        // Fix this
        return head;
    }
}