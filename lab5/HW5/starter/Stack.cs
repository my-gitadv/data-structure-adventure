using System;

public class Stack
{
    Node[] arr; // regular array
    int capacity;
    int size;

    public Stack(int cap)
    {
        // Do something
    }

    public void push(Node node)
    {
        if (!isEmpty())
        {
            // Do something

        }
        else
        {
            Console.WriteLine("Stack Overflow!!!");
        }
    }
    public Node pop()
    {
        if (!isEmpty())
        {
            // Do something

        }
        else
        {
            Console.WriteLine("Stack Underflow!!!");
        }
        return null;
    }
    public bool isFull()
    {
        return false; // Fix this
    }
    public bool isEmpty()
    {
        return false; // Fix this
    }

    public void printStack()
    {
        // Fix the condition
        if (true)
        {
            Console.Write("[Bottom] ");
            // Do something

            Console.WriteLine("[Top]");
        }
        else
        {
            Console.WriteLine("Empty Stack!!!");
        }
    }
}