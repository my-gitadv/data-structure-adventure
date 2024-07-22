using System;
public class Stack : List
{
    // Implement Stack using Linked List without tail
    Node head;

    public void push(Node node)
    {
        
        if (head == null)
        {
            head = node;
        }
        else
        {
            node.next = head;
            head = node;
        }
    }

    public void pop()
    {
        // Fix the condition
        if (head != null)
        {
            head = head.next;
        }
        else
        {
            Console.WriteLine("Error: Stack Underflow");
        }

    }

    public Node top()
    {
        // Fix this
        return head;
        //return new Node(0, 0.0);
    }
}