using System;
public class List
{
    Node[] arr;
    int capacity;
    int size;

    public List(int cap)
    {
        arr = new Node[cap];
        capacity = cap;
    }

    public void append(Node node)
    {
        if (size < capacity)
        {
            arr[size] = node;
            size++;
        }
    }

    public void printList()
    {
        Console.Write("[Head] ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i].key + " ");
        }
        Console.WriteLine("[Tail] ");
    }
}
