using System;

public class BSTree2 : BTreePrinter
{
    Node root;

    public Node find(int search_key)
    // Implement this function using the iterative method (while loop)
    // Do not use the recursion
    {
        Node current = root;
        while (current != null)
        {
            if (search_key == current.key)
                return current;
            else if ((search_key < current.key) && (current.left != null))
                current = current.left;
            else if ((search_key > current.key) && (current.right != null))
                current = current.right;
            else
                return null;
        }
        return current;
        
    }

    public Node findMin()
    // Implement this function using the iterative method (while loop)
    // Do not use the recursion
    {
        Node current = root;
        if (current == null){
            return null;
        }
        while (current != null)
        {
            if (current.left == null)
                return current;
            else
                current = current.left;
        }
        return current;


    }

    public Node findMax()
    // Implement this function using the iterative method (while loop)
    // Do not use the recursion
    {
        Node current = root;
        if (current == null){
            return null;
        }
        while (current != null)
        {
            if (current.right == null)
                return current;
            else
                current = current.right;
        }

        return current;

    }

    public void insert(int key)
    // Implement this function using the iterative method (while loop)
    // Do not use the recursion
    {
        Node current = root;

        if (root == null)
            root = new Node(key);
        else
            while (current != null)
            {
            if (key == current.key){
                Console.WriteLine("Duplicated key!!!");
                return;
            }
            else if (key < current.key)
                if (current.left == null)
                {
                    current.left = new Node(key);
                    current.left.parent = current;
                    return;
                }
                else
                    current = current.left;
            else if (current.right == null)
            {
                current.right = new Node(key);
                current.right.parent = current;
                return;
            }
            else
                current = current.right;
            }
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