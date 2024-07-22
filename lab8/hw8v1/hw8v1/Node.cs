using System;

public class Node
// This node contains information about an investor (investorID) who submits an order (sell order = minHeap, buy order = maxHeap)
// at a certain time (timestamp) and a certain price (price)
{

    public double price;
    public int investorID;
    public int amount;
    public int timestamp; // Heap.push() is the only function that modify this variable
    public bool isMinHeap;

    public Node(double price, int investorID, int amount, bool isMinHeap)
    {
        this.price = price;
        this.investorID = investorID;
        this.amount = amount;
        this.isMinHeap = isMinHeap;
    }

    public bool compare(Node rightNode)
    // This function will return true if Priority(thisNode) > Priority(rightNode)
    // minHeap: the lower the price, the higher the priority // selling
    // maxHeap: the lower the price, the lower the priority  // buying
    // If same price, the smaller the timestamp is, the higher the priority will be
    {
        if (this.price == rightNode.price)
        {
            if (this.timestamp < rightNode.timestamp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (isMinHeap)
            {
                if (this.price < rightNode.price)
                    return true;
                else
                    return false;
            }

            else
            {
                if (this.price < rightNode.price)
                    return false;
                else
                    return true;
            }
        }
    }

    public Node() { } // Dummy constructor, no need to edit
}