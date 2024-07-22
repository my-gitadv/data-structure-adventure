using System;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class SplayTree : BTreePrinter
{
    Node root;

    public SplayTree(Node root)
    // This function is complete, no need to edit
    {
        this.root = root;
        root.parent = null; // Clear parent of the root (Important for SplayTree)
    }

    public SplayTree() { } // Dummy Constructor, no need to edit

    public void zig(Node x)
    // zig() function will move up the node x one level
    // Case 1: x == root
    // Case 2-3: x.parent == root (sig from left, zig from right)
    // Case 4-5: x.parent != root (sig from left, zig from right)
    {
        //Console.WriteLine("Perform zig on Node(" + x.key + ")");

        Node y = x.parent;
        if (y == null)
        {
            Console.WriteLine("Cannot perform Zig operation on the root node");
        }
        else if (y == root)
        {
            if (x.key < y.key)
            {
                // Zig from left

                y.left = x.right;
                if (x.right != null){
                    x.right.parent = y;
                }
                x.right = y;
                y.parent = x;
                


            }
            else
            {
                y.right = x.left;
                if (x.left != null){
                    x.left.parent = y;
                }
                x.left = y;
                y.parent = x;

            }
            x.parent = null;
            root = x;

        }
        else
        {
            if (x.key < y.key)
            {
                // Zig from left
                Node w = y.parent;

                y.left = x.right;
                if (x.right != null){
                    x.right.parent = y;
                }
                x.right = y;
                y.parent = x;

                if (w.key < x.key)
                {
                    w.right = x;
                }
                else
                {
                    w.left = x;
                }
                x.parent = w;
                

            }
            else
            {
                Node w = y.parent;

                y.right = x.left;
                if (x.left != null){
                    x.left.parent = y;
                }
                x.left = y;
                y.parent = x;

                if (w.key < x.key)
                {
                    w.right = x;
                }
                else
                {
                    w.left = x;
                }
                x.parent = w;
                
            }

        }

    }

    public void zigzig(Node x)
    // zigzig() function will move up node x two levels along the outer path
    // Pls call zig() to perform zigzig()
    {
        

        zig(x.parent);
        zig(x);

    }

    public void zigzag(Node x)
    // zigzag() function will move up node x two levels along the inner path
    // Pls call zig() to perform zigzag()
    {
        // Do something
        zig(x);
        zig(x);

    }

    public void splay(Node x)
    // This function will iteratively splay (move up) node x all the way to the root
    {
            while (x != null && x != root)
        {
            Node y = x.parent;
            if (y == root)
            {
                 zig(x);
                 break;
            }else
            {
                if (y.key < y.parent.key) 
                { 
                    if (x.key < y.key)
                    {
                        zigzig(x);
                        //x = x.parent;
                    }
                    else
                    {
                        zigzag(x);
                        //x = x.parent;
                    }
                }
                else
                {
                    if(x.key > y.key)
                    {
                        zigzig(x);
                        //x = x.parent;
                    }
                    else
                    {
                        zigzag(x);
                        //x = x.parent;
                    }
                }
            }
            
        }
    }
    
    public void insert(int key)
    // This function is ALMOST complete
    // Modify this function to have the splaying feature
    // This can be done by calling the splay() function something in the code
    {
        Node current = root;
        if (current == null)
        {
            root = new Node(key);
        }
        else
        {
            while (current != null)
            {
                if (key == current.key)
                {
                    Console.WriteLine("Duplicated key:" + key);
                    break;
                }
                else if (key < current.key)
                {//Go left
                    if (current.left == null)
                    {
                        current.left = new Node(key);
                        current.left.parent = current;
                        splay(current.left);
                        break;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = new Node(key);
                        current.right.parent = current;
                        splay(current.right);
                        break;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
            }
        }
    }

    public Node find(int search_key, bool withSplay)
    // This function is ALMOST complete
    // Modify this function to have the splaying feature (if withSplay is true)
    // This can be done by calling the splay() function
    {
        Node current = root;
        while (current != null)
        {
            if (search_key == current.key)
            {
                return current;
            }
            else if (search_key < current.key)
            {
                current = current.left;
            }
            else
            {
                current = current.right;
            }
        }
        return null;
    }
   
    public Node findMin()
    // (In this HW) This function does not need the splaying feature
    // This function is complete, DO NOT edit this function
    {
        Node current = root.left;
        while (current.left != null)
            current = current.left;
        return current;
    }


    public int height()
    // This is another version of height() but find the BST height iteratively rather than recursively
    // This function is complete, no need to edit
    {
        if (root == null)
            return -1;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);
        int height = -1;
        while (true)
        {
            int nodeCount = q.Count;
            if (nodeCount == 0)
                return height;
            height++;
            while (nodeCount > 0)
            {
                Node newnode = q.Dequeue();
                if (newnode.left != null)
                    q.Enqueue(newnode.left);
                if (newnode.right != null)
                    q.Enqueue(newnode.right);
                nodeCount--;
            }
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