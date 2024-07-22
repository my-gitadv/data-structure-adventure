using System;

public class Stack
{
    Node[] arr; // regular array
    int capacity;
    int size;

    public Stack(int cap)
    {
        this.arr = new Node[cap];
        this.capacity = cap;
        this.size = 0;
    }

    public void push(Node node)
    {
        if (!isFull())
        {
            arr[size] = node;
            size++;
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
            size--;
            return arr[size];

        }
        else
        {
            Console.WriteLine("Stack Underflow!!!");
        }
        return null;
    }
    public bool isFull()
    {
        if (size == capacity)
        {
            return true;
        }
        else 
        {
            return false;
        } 
    }
    public bool isEmpty()
    {
        if (size == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void printStack()
    {
        
        if (!isEmpty())
        {
            Console.Write("[Bottom] ");

            for( int i = 0; i < size; i++)
            {
                Console.Write(arr[i].data + " ");
            }

            Console.WriteLine("[Top]");
        }
        else
        {
            Console.WriteLine("Empty Stack!!!");
        }
    }
}