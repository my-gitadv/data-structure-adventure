using System;

public class BSTree2 : BTreePrinter
{
    Node root;

    public Node find(int search_key)
    // Implement this function using the iterative method (while loop)
    // Do not use the recursion
    {
        // Do something
        
        return null; // Fix this
    }

    public Node findMin()
    // Implement this function using the iterative method (while loop)
    // Do not use the recursion
    {
        // Do something

        return null; // Fix this
    }

    public Node findMax()
    // Implement this function using the iterative method (while loop)
    // Do not use the recursion
    {
        // Do something

        return null; // Fix this
    }

    public void insert(int key)
    // Implement this function using the iterative method (while loop)
    // Do not use the recursion
    {
        // Do something
    }

    public void printTree()
    // This function is complete, no need to edit
    {
        if (root == null)
            Console.WriteLine("Empty tree!!!");
        else
            base.printTree(root);
    }
}