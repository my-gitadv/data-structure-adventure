using System;

public class Queue
{
    Node[] arr; // circular array
    int capacity;
    int front;  //front update when pop
    int back; //back update when push
    int size; //size is actual number of values

    public Queue(int cap)
    {
        this.arr = new Node[cap];
        this.capacity = cap;
        this.front = 0;
        this.back = 0;
        this.size = 0;
    }

    public void enqueue(Node node)
    {
        if (!isFull())
        {
            arr[back] = node;
            back = (back+1) % capacity;
            size++;
            
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
            int temp = front;
            front = (front+1) % capacity;
            size--;
            return arr[temp];
            
        }
        else
        {
            Console.WriteLine("Queue Underflow!!!");
        }
        return null;
    }

    public bool isEmpty()
    {
        if (size == 0) return true;
        else return false;

    }

    public bool isFull()
    {
        if (size == capacity) return true;
        else return false;
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

            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[(front + i) % capacity].data + " ");
            }
            Console.WriteLine("[Back]");
        }
        else
        {
            Console.WriteLine("Empty Queue!!!");
        }
    }
}