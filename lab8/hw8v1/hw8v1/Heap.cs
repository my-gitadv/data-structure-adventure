using System;

public class Heap
{
    int capacity;
    Node[] arr;
    int size;

    bool isMinHeap;  // true if minHeap, false if maxHeap

    int timer;    // For each push, the timer will increase by 1

    public Heap(bool isMinHeap, int cap)
    {
        // Initialize the heap here
        // Don't forget that we will build the binary heap using...ARRAY
        // ... the concept of "Complete binary tree based on the array implementation"
        // ... The 0 index will not be used, The index starts from 1 (remember?)
        this.size = 0;
        this.capacity = cap;
        this.arr = new Node[cap];

    }
    public Node top()
    {
        return arr[1];
    }

    public void push(Node node)
    {
        // Increase timestamp each time you push something into the Queue
        timer++;
        node.timestamp = timer; // Stamp the time number to the node

        // To do:
        // 1. Push the new node at the end of the array (via back pointer)
        // 2. Sift (percolate) it up the heap
        //      * Check priority of the current node with its parent
        //      * Swap the current node if the priority is higher than the parent
        //      * Repeat the process until reaching the root or there is no swap (Pls use while loop)
        // 3. Increase the heap size

        

        arr[size + 1] = node;
        int k = size + 1;
        size++;
        while (k > 1 && arr[k].compare(arr[k/2]))
        {
            swap(k, k / 2);
            k = k / 2;
        }

    }

    public Node pop()
    {

        // To do:
        // 1. Mark the root for return (Don't forget to return this node)
        // 2. Move the last node to the root (change pointer, set null)
        // 3. Decrease the heap size
        // 4. Sift (percolate) it down the heap
        //      * Check priority of the current node with both children
        //      * Swap the current node with the lower priority child
        //      * Repeat the process until the node has no child or there is no swap (Pls use while loop)

        int i = 1;
        Node temp = arr[i];

        arr[i] = arr[size];
        arr[size] = null;
        size--;

        while (i < size)
        {
            if (arr[i *2 + 1] == null || arr[i * 2].compare(arr[i*2 + 1]))
            {
                if (arr[i * 2] != null && !arr[i].compare(arr[i * 2]))
                {
                    swap(i,i*2);
                    i = i * 2;
                }
                else
                {
                    break;
                }
            }
            else
            {
                if (arr[i * 2 + 1] != null && !arr[i].compare(arr[i * 2 + 1]))
                {
                    swap(i, i * 2 + 1);
                    i = i * 2 + 1;
                }
                else
                {
                    break;
                }
            }
        }
        //if (size >= 0)
            return temp;
        //else return null;
    }

    public void swap(int index1, int index2)
    // This is an optional function, you may use it if you know what it is
    // This function is complete, no need to edit
    {
        Node temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }

    public void printArray()
    // This is an optional function, you may use it if you know what it is
    // This function is complete, no need to edit
    {
        Console.Write("[");
        for (int i = 1; i <= size; i++)
        {
            Console.Write(arr[i].price);
            if (i < size)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }

}
