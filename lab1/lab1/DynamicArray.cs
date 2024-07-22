using System;

public class DynamicArray
{
    private int[] arr;
    private int capacity;
    private int size; // Last element can be indexed at size-1

    public DynamicArray(int cap)
    { // Class Constructor
        arr = new int[cap];
        capacity = cap;
        size = 0;
    }

    public void pushBack(int data)
    {
        if (size == capacity)
        {
            int[] temp = new int[2 * capacity];

            for (int i = 0; i < size; i++) 
            {
                temp[i] = arr[i];
            }
            arr = temp;
            capacity *= 2;
        }
        arr[size] = data;
        size++;
    }

    public int popBack()
    {
        if (size == 0)
        {
            Console.WriteLine("ERROR");
            return arr[0];
        }
        else
        {
            size--;
            return arr[size];
        }

    }

    public int get(int i)
    { 
        if (i>=size)
        {
           Console.WriteLine("ERROR");   
        }
        return arr[i];
        
        
    }
    // [1,3,4,6,7,0,0]
    // i = 3
    public void set(int i, int value)
    {
        if (i>=size) 
        {
            Console.WriteLine("ERROR");
        }
        else
        {
            arr[i] = value;
        }
        
    }

    public void remove(int i)
    {
        if (i >= size)
        {
            Console.WriteLine("ERROR");
        }
        else
        {
            for (int j = i; j < size; j++)
            {
                arr[j] = arr[j + 1];
            }
            size--;
        }

    }

    public bool isEmpty()
    {
        if (size != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }

    public int getSize()
    {
        return size;
    }

    public void printStructure()
    {

        Console.Write("Size = " + size + ", Cap = " + capacity + ", array = ");

        Console.Write("[ ");

        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine("]");
    }
}