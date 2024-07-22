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
            // Do something (Empty list)
        }
        else
        {
            // Do something else (Non-empty list)
        }
    }

    public void pop()
    {
        if (head != null)
        {
            if (head != tail)
            {
                // Do something (List of many nodes)
            }
            else
            {
                // Do something else (List of a single node)
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
        return new Node(0, 0.0);
    }
}