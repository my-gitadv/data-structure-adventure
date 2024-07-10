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
        // Don't forget that we will build the binary heap using...
        // ... the concept of "Complete binary tree based on the array implementation"
        // ... The 0 index will not be used, The index starts from 1 (remember?)

    }
    public Node top()
    {
        return null; // FIX THIS
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
        
        return null; // You may have to fix this line

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
