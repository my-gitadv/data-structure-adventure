using System;

public class BSTree : BTreePrinter
{
    public Node root;

    public void singleRotateFromLeft(Node y)
    {
        // Do something

    }

    public void singleRotateFromRight(Node y)
    {
        // Do something

    }

    public void doubleRotateFromLeft(Node y)
    {
        // Do something

    }

    public void doubleRotateFromRight(Node y)
    {
        // Do something

    }

    public Node find(int search_key)
    // This function is complete, no need to edit
    {
        return find(root, search_key);
    }

    public static Node find(Node node, int search_key)
    // This function is complete, no need to edit
    {
        if (search_key == node.key)
            return node;
        else if ((search_key < node.key) && (node.left != null))
            return find(node.left, search_key);
        else if ((search_key > node.key) && (node.right != null))
            return find(node.right, search_key);
        else
            return null;
    }

    public static Node findMin(Node node)
    // This function is complete, no need to edit
    {
        if (node.left == null)
            return node;
        else
            return findMin(node.left);
    }

    public static Node findMax(Node node)
    // This function is complete, no need to edit
    {
        if (node.right == null)
            return node;
        else
            return findMax(node.right);
    }

    public void insert(int key)
    // This function is complete, no need to edit
    {
        if (root == null)
            root = new Node(key);
        else
            insert(root, key);
    }

    public static void insert(Node node, int key)
    // This function is complete, no need to edit
    {
        if (key == node.key)
            Console.WriteLine("Duplicated key!!!");
        else if (key < node.key)
            if (node.left == null)
            {
                node.left = new Node(key);
                node.left.parent = node;
            }
            else
                insert(node.left, key);
        else if (node.right == null)
        {
            node.right = new Node(key);
            node.right.parent = node;
        }
        else
            insert(node.right, key);
    }

    public void delete(int key)
    // This function is complete, no need to edit
    {
        if (root == null)
            Console.WriteLine("Empty Tree!!!");
        else if (root.key == key)
            if (root.left == null && root.right == null)
                root = null;
            else if (root.left != null && root.right == null)
            {
                root = root.left;
                root.parent = null;
            }
            else if (root.left == null && root.right != null)
            {
                root = root.right;
                root.parent = null;
            }
            else
            {
                Node minRightSubTree = findMin(root.right);
                root.key = minRightSubTree.key;
                delete(minRightSubTree);
            }
        else
        {
            Node deletingNode = find(root, key);
            if (deletingNode != null)
                delete(deletingNode);
            else
                Console.WriteLine("Key not found!!!");
        }
    }

    public static void delete(Node node)
    // This function is complete, no need to edit
    {
        Node parentNode = node.parent;
        if (node.left == null && node.right == null)
            if (node.key < parentNode.key)
                parentNode.left = null;
            else
                parentNode.right = null;
        else if (node.left != null && node.right == null)
            if (node.key < parentNode.key)
            {
                parentNode.left = node.left;
                node.left.parent = parentNode;
            }
            else
            {
                parentNode.right = node.left;
                node.left.parent = parentNode;
            }
        else if (node.left == null && node.right != null)
            if (node.key < parentNode.key)
            {
                parentNode.left = node.right;
                node.right.parent = parentNode;
            }
            else
            {
                parentNode.right = node.right;
                node.right.parent = parentNode;
            }
        else if (node.left != null && node.right != null)
        {
            Node minRightSubTree = findMin(node.right);
            node.key = minRightSubTree.key;
            delete(minRightSubTree);
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