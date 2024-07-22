using System;
public class Node // Fix this line (inherit the BTreePrinter class)
{
    public Node left;
    public Node right;
    public int data;


    public Node(int data)
    {
        // Do something
    }

    public void printTree()
    {
        // Understand this line before uncommenting
        // base.printTree(this);
    }

    public void printBFT()
    {
        Queue q = new Queue(50);
        Node currentNode = this;
        Console.Write("BFT node sequence [ ");
        // Do something

        Console.WriteLine("]");
    }

    public void printDFT()
    { // PreOrder                
        Stack s = new Stack(50);
        Console.Write("DFT node sequence [ ");
        // Do something

        Console.WriteLine("]");
    }
}
