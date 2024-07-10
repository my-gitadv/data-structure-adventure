using System;

public class AVLTree : BSTree
{
    public AVLTree(Node root)
    // This function is complete, no need to edit
    {
        this.root = root;
        root.parent = null; // Clear parent of the root (Important for spliting)
    }

    public AVLTree() { } // Dummy Constructor, no need to edit

    public void rebalance(AVLTree tree, Node node)
    {
        int balanceFactor = height(node.left) - height(node.right);              // Calculate balanceFactor
        if (Math.Abs(balanceFactor) > 1)
        {                                   // Use balanceFactor to check if unbalanced?
            if (balanceFactor > 1)
            {                               // Use balanceFactor to check if left heavy?
                if (height(node.left.left) > height(node.left.right))
                {                           // Use the grandchild to check if Outer or Inner?
                    Console.WriteLine("Perform SingleRotateFromLeft(Node " + node.key + ")");
                    singleRotateFromLeft(node);
                    return;


                }
                else
                {
                    Console.WriteLine("Perform DoubleRotateFromRight(Node " + node.key + ")");
                    doubleRotateFromLeft(node);
                    return;

                }
            }
            else
            {
                if (height(node.right.right) > height(node.right.left))
                {                           // Use the grandchild to check if Outer or Inner?
                    Console.WriteLine("Perform SingleRotateFromRight(Node " + node.key + ")");    // Fix ??? and call a function
                    singleRotateFromRight(node);
                    return;



                }
                else
                {
                    Console.WriteLine("Perform DoubleRotateFromRight(Node " + node.key + ")");    // Fix ??? and call a function
                    doubleRotateFromRight(node);
                    return;

                }
            }
        }
        if (node.parent != null){
            rebalance(tree, node.parent);
        }
    }

    public new void insert(int key)
    // This function is complete, no need to edit
    {
        //Console.WriteLine(key);

        if (root == null)
            root = new Node(key);
        else
            insert(this, root, key);
    }

    public void insert(AVLTree tree, Node node, int key)
    // Fix this function to have the rebalancing feature
    // There should be a rebalance() function call somewhere in the code
    {
        if (key == node.key)
            Console.WriteLine("Duplicated key:" + key);
        else if (key < node.key)
            if (node.left == null)
            {
                node.left = new Node(key);
                node.left.parent = node;
                rebalance(tree, node.left);

            }
            else
                insert(tree, node.left, key);
        else
            if (node.right == null)
            {
                node.right = new Node(key);
                node.right.parent = node;
                rebalance(tree, node.right);

        }
        else
                insert(tree, node.right, key);

    }

    public new void delete(int key)
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
                delete(this, minRightSubTree);
            }
        else
        {
            Node deletingNode = find(key);
            if (deletingNode != null)
                delete(this, deletingNode);
            else
                Console.WriteLine("Key not found!!!");
        }
    }

    public void delete(AVLTree tree, Node node)
    // This function is ALMOST complete, need to have the rebalacing feature
    // Hint: Use while loop to iteratively rebalance nodes along the path to the root
    {
        Node parentNode = node.parent;
        if (node.left == null && node.right == null)
            if (node.key < parentNode.key)
            {
                parentNode.left = null;
                while (parentNode.parent != null)
                {
                    rebalance(this, parentNode);
                    parentNode = parentNode.parent;

                }

            }

            else
                parentNode.right = null;
        else if (node.left != null && node.right == null)
            if (node.key < parentNode.key)
            {
                parentNode.left = node.left;
                node.left.parent = parentNode;
                while (parentNode != null)
                {
                    rebalance(this, parentNode);
                    parentNode = parentNode.parent;

                }

            }
            else
            {
                parentNode.right = node.left;
                node.left.parent = parentNode;
                while (parentNode != null)
                {
                    rebalance(this, parentNode);
                    parentNode = parentNode.parent;

                }

            }
        else if (node.left == null && node.right != null)
            if (node.key < parentNode.key)
            {
                parentNode.left = node.right;
                node.right.parent = parentNode;
                while (parentNode != null)
                {
                    rebalance(this, parentNode);
                    parentNode = parentNode.parent;

                }

            }
            else
            {
                parentNode.right = node.right;
                node.right.parent = parentNode;
                while (parentNode != null)
                {
                    rebalance(this, parentNode);
                    parentNode = parentNode.parent;

                }

            }
        else if (node.left != null && node.right != null)
        {
            Node minRightSubTree = AVLTree.findMin(node.right);
            node.key = minRightSubTree.key;
            delete(tree, minRightSubTree);
            Node current = node;
            while (current != null)
            {

                rebalance(this, current);
                current = current.parent;

            }
        }


    }  

    public static int height(Node node)
    // This function is complete, no need to edit
    // Use this function to check the node height
    {
        if (node == null)
            return -1;
        else
            return 1 + Math.Max(height(node.left), height(node.right));
    }

}