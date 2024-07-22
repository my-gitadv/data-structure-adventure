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
        list.push(new Node(boughtShares, boughtPrice));
        totalShares += boughtShares;
    }

    public void sell(int soldShares, double soldPrice)
    {
        // Fix the condition
        if (soldShares <= totalShares)
        {
            double realizedGain = 0.0;
            double unrealizedGain = 0.0;
            totalShares -= soldShares;

            while (list.top() != null && soldShares > 0)
            {
                if (soldShares >= list.top().shares)
                {
                    realizedGain += list.top().shares * (soldPrice - list.top().price);
                    soldShares -= list.top().shares;
                    list.pop();
                }
                else
                {
                    realizedGain += soldShares * (soldPrice - list.top().price);
                    list.top().shares -= soldShares;
                    soldShares = 0;
                }

            }
            Node current = list.top();

            while (current != null)
            {
                unrealizedGain += (soldPrice - current.price) * current.shares;
                current = current.next;
            }

            
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