using System;

public class Queue
{
    Node[] arr; // circular array
    int capacity;
    int front;
    int back;
    int size;

    public Queue(int cap)
    {
        // Do something
    }

    public void enqueue(Node node)
    {
        if (!isEmpty())
        {
            // Do something
        }
        else
        {
            Console.WriteLine("Queue Overflow!!!");
        }
    }

    public Node dequeue()
    {
        if (!isEmpty())
        {
            // Do something
        }
        else
        {
            Console.WriteLine("Queue Underflow!!!");
        }
        return null;
    }

    public bool isEmpty()
    {
        return false; // Fix this
    }

    public bool isFull()
    {
        return false; // Fix this
    }

    public void printCircularIndices()
    {
        Console.WriteLine("Front index = " + front + " Back index = " + back);
    }

    public void printQueue()
    {
        if (!isEmpty())
        {
            Console.Write("[Front] ");
            // Do something 

            Console.WriteLine("[Back]");
        }
        else
        {
            Console.WriteLine("Empty Queue!!!");
        }
    }
}