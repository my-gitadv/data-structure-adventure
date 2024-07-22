using System;
using System.Security.Cryptography.X509Certificates;
public class Node : BTreePrinter
{
    public Node left;
    public Node right;
    public int data;


    public Node(int data)
    {
        this.data = data;
        this.left = null;
        this.right = null;
    }

    public void printTree()
    {
        // Understand this line before uncommenting
        base.printTree(this);
    }

    public void printBFT()
    {
        Queue q = new Queue(50);
        Node currentNode = this;
        Console.Write("BFT node sequence [ ");
        
        if (currentNode == null) 
        {
            return;
        }
        else
        {
            q.enqueue(currentNode);
            while (!q.isEmpty())
            {
                currentNode = q.dequeue();
                Console.Write(currentNode.data + " ");
                if (currentNode.left != null) 
                {
                    q.enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    q.enqueue(currentNode.right);
                }
            }
        }


        Console.WriteLine("]");
    }

    public void printDFT()
    { // PreOrder                
        Stack s = new Stack(50);
        Node currentNode = this;
        Console.Write("DFT node sequence [ ");

        if (currentNode == null)
        {
            return;
        }
        else
        {
            s.push(currentNode);
            while (!s.isEmpty())
            {
                currentNode = s.pop();
                Console.Write(currentNode.data + " ");
                if (currentNode.right != null)
                {
                    s.push(currentNode.right);
                }
                if (currentNode.left != null)
                {
                    s.push(currentNode.left);
                }
            }
        }


        Console.WriteLine("]");
    }
}
