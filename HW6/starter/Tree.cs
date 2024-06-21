using System;

public class Tree // Fix this (inherit the BTreePrinter class here)
{
    public Node root;

    public Tree(Node root)
    {
        // Do something
    }

    public Tree() { } // Dummy constructor (No need to edit)

    public void printTree()
    {
        // Fix this condition
        if (false)
        {
            // Uncomment the following line after you fix the class inheritance problem
            // base.printTree(root);
        }
        else
        {
            Console.WriteLine("Empty tree!!!");
        }
            
    }

    public Node find(int search_key)
    {
        return null; // Call the recursive function
    }

    public static Node find(Node node, int search_key)
    {
        // This function should be recursive
        // Null node should be checked in this function
        return null;
    }

    public Node findMin()
    {
        return null; // Call the recursive function
    }

    public static Node findMin(Node node)
    {
        // This function should be recursive
        return null;
    }

    public Node findMax()
    {
        return null; // Call the recursive function
    }

    public static Node findMax(Node node)
    {
        // This function should be recursive
        return null;
    }


    public Node findClosestLeaf(int search_key)
    {
        return null; // Call the recursive function
    }

    public static Node findClosestLeaf(Node node, int search_key)
    {
        // This function should be recursive
        return null;
    }

    public Node findClosest(int search_key)
    {
        // Please use while loop to implement this function
        // Try not to use recursion

        Node current = root;
        Node closest = null;
        int min_diff = Int32.MaxValue;

        // Use while loop to traverse from root to the closest leaf

        return closest;
    }

    public static void printNode(Node node)
    {
        // Fix the condition
        if (true)
            Console.WriteLine("Node not found!!!");
        else
            Console.WriteLine(); // Fix this to print Node's key
    }

    // Implement this function using the findClosestLeaf technique
    // Do not implement the recursive function
    public void insert(int key)
    {
        // Implement insert() using the non-recursive version
        // This function should call findClosestLeaf()
    }

    public void printPreOrderDFT()
    {
        Console.Write("PreOrder DFT node sequence [ ");
        // Call the recursive version
        Console.WriteLine("]");
    }

    public static void printPreOrderDFT(Node node)
    {
        // this function should be recursive
    }

    public void printInOrderDFT()
    {
        Console.Write("InOrder DFT node sequence [ ");
        // Call the recursive version
        Console.WriteLine("]");
    }

    public static void printInOrderDFT(Node node)
    {
        // this function should be recursive
    }

    public void printPostOrderDFT()
    {
        Console.Write("PostOrder DFT node sequence [ ");
        // Call the recursive version
        Console.WriteLine("]");
    }

    public static void printPostOrderDFT(Node node)
    {
        // this function should be recursive
    }

    public static int height(Node node)
    {
        // Use recursion to implement this function
        // height = length(path{node->deepest child})
        return -2; // Fix this
    }

    public static int size(Node node)
    {
        // Use recursion to implement this function
        // size = #children + 1(itself)
        return -2; // Fix this
    }

    public static int depth(Node root, Node node)
    {
        // Use recursion to implement this function
        // Similar to height() but start from node, go up to root
        // depth = length(path{node->root})
        return -2; // Fix this
    }

    public int height()
    {
        return -2; // Fix this by calling the static function
    }

    public int size()
    {
        return -2; // Fix this by calling the static function
    }

    public int depth()
    {
        return -2; // Fix this by calling the static function
    }

    public Node findKthSmallest(int k)
    {
        // Fix the condition
        if (false)
        {
            Console.WriteLine("Invalid k value");
            return null;
        }
        else
        {
            return findKthSmallest(root, k);
        }
    }

    public static Node findKthSmallest(Node node, int k)
    {
        // this function should be recursive
        return null;
    }

    public static Node findNext(Node node)
    {
        //this function should call other functions
        if (node.right != null)
            return null; // Fix this
        else
            return null; // Fix this
    }

    public static Node leftDescendant(Node node)
    {
        // this function should be recursive
        if (node.left == null)
            return null; // Fix this
        else
            return null; // Fix this
    }

    public static Node rightAncestor(Node node)
    {// Case 1 (first right parent)
        // this function should be recursive
        if (node.parent == null)
        {
            return null;
        }
        else if (node.key < node.parent.key)
            return null; // Fix this
        else
            return null; // Fix this
    }

    public List rangeSearch(int x, int y)
    {
        // use append(node) to add node to the list
        List list = new List(100);
        // do something here
        
        return list;
    }

    // This function is for deleting the root node
    // If the node is not the root, please call the recursive version
    public void delete(int key)
    {
        // There should be 6 cases here
        // Non-root nodes should be forwarded to the static function
    }

    // Use this function to delete non-root nodes
    public static void delete(Node node)
    {
        // There should be 7 cases here
    }
}