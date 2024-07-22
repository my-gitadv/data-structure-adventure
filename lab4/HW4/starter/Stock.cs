using System;
public class Stock
{
    private List list;
    private int totalShares;

    public Stock(String costBasis)
    {
        switch (costBasis)
        {
            case "FIFO":
                list = new Queue();
                break;
            case "LIFO":
                list = new Stack();
                break;
            default:
                Console.WriteLine("Invalid cost basis. Choose FIFO or LIFO");
                break;
        }
    }

    public void buy(int boughtShares, double boughtPrice)
    {
        // Complete this code
        // Something is missing here

        totalShares += boughtShares;
    }

    public void sell(int soldShares, double soldPrice)
    {
        // Fix the condition
        if (true)
        {
            double realizedGain = 0.0;
            double unrealizedGain = 0.0;

            // Complete this code
            // Something is missing here

            totalShares -= soldShares;
            Console.WriteLine("Realized P/L = " + realizedGain + " Unrealized P/L = " + unrealizedGain);
        }
        else
        {
            Console.WriteLine("Sell command rejected");
        }
    }

    public void showList()
    {
        Node currentNode = list.top();
        Console.Write("head -> ");
        while (currentNode != null)
        {
            Console.Write("[" + currentNode.shares + "@" + currentNode.price + "B] -> ");
            currentNode = currentNode.next;
        }
        Console.WriteLine("tail");
    }
}