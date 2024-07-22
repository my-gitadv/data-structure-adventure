using System;

public class Tree : BTreePrinter
{
    public Node root;

    public Tree(Node root)
    {
        this.root = root;
    }

    public Tree() { } // Dummy constructor (No need to edit)

    public void printTree()
    {
        // Fix this condition
        if (root != null)
        {
            // Uncomment the following line after you fix the class inheritance problem
            base.printTree(root);
        }
        else
        {
            Console.WriteLine("Empty tree!!!");
        }
            
    }

    public Node find(int search_key)
    {
        return find(root, search_key);
    }

    public static Node find(Node node, int search_key)
    {

        if (node != null)
        {
           if (search_key == node.key)
           {
               return node;
           }
           else if (search_key < node.key)
           {
               return find(node.left, search_key);
           }
           else
           {
               return find(node.right, search_key);
           }

        }
        else
        {
           return null;

        }

    }

    public Node findMin()
    {
        return findMin(root);
    }

    public static Node findMin(Node node)
    {
       if(node != null)
        {
            if(node.left != null)
            {
                return findMin(node.left);
            }else
                return node;
        }
        else
        {
            return null;
        }
        
    }

    public Node findMax()
    {
        return findMax(root);
    }

    public static Node findMax(Node node)
    {
        if (node != null)
        {
            if (node.right != null)
            {
                return findMax(node.right);
            }
            else
                return node;
        }
        else
        {
            return null;
        }
    }


    public Node findClosestLeaf(int search_key)
    {
        return findClosestLeaf(root, search_key);
    }

    public static Node findClosestLeaf(Node node, int search_key)
    {
        if(node != null)
        {
            if(search_key > node.key)
            {
                if(node.right != null)
                {
                    return findClosestLeaf(node.right, search_key);
                }
                else
                {
                    return node;
                }
            }
            else
            {
                if(node.left != null)
                {
                    return findClosestLeaf(node.left, search_key);
                }
                else
                {
                    return node;
                }
            }
        }
        else
        {
            return null;
        }   
    }

    public Node findClosest(int search_key)
    {

        Node current = root;
        Node closest = null;
        int min_diff = Int32.MaxValue;

        while (current != null)
        {
            //if(search_key)
            if (Math.Abs(current.key - search_key) < min_diff)
            {
                closest = current;
                min_diff = Math.Abs(current.key - search_key);
            }

            if(search_key < current.key)
            {
                if(current.left == null)
                {
                    return closest;
                }
                current = current.left;
            }
            else
            {
                if (current.right == null)
                {
                    return closest;
                }
                current = current.right;
            }
        }

        return closest;
    }

    public static void printNode(Node node)
    {

        if (node == null)
            Console.WriteLine("Node not found!!!");
        else
            Console.WriteLine(node.key);
    }

    // Implement this function using the findClosestLeaf technique
    // Do not implement the recursive function
    public void insert(int key)
    {
        // Implement insert() using the non-recursive version
        // This function should call findClosestLeaf()
        //Node current = new Node();
        if (root == null)
        {
            root = new Node(key);
        }
        else
        {
            Node current = findClosestLeaf(key);

            if (current.key == key)
            {
                Console.WriteLine("Duplicated key!!!");
            }
            else if (key < current.key)
            {
                current.left = new Node(key);
                current.left.parent = current;

            }
            else
            {
                current.right = new Node(key);
                current.right.parent = current;
            }

        }
    }

    public void printPreOrderDFT()
    {
        Console.Write("PreOrder DFT node sequence [ ");
        printPreOrderDFT(root);
        Console.WriteLine("]");
    }

    public static void printPreOrderDFT(Node node) //recursive
    {
        if (node == null)
        {
            return;
        }
        else
        {
            Console.Write(node.key + " ");
            if (node.left != null)
            {
                printPreOrderDFT(node.left);

            }
            if (node.right != null)
            {
                printPreOrderDFT(node.right);

            }
        }
    }

    public void printInOrderDFT()
    {
        Console.Write("InOrder DFT node sequence [ ");
        printInOrderDFT(root);
        Console.WriteLine("]");
    }

    public static void printInOrderDFT(Node node)
    {
        if (node == null)
        {
            return ;
        }
        else
        {
            if(node.left != null)
            {
                printInOrderDFT(node.left);
            }
            Console.Write(node.key + " ");
            if (node.right != null)
            {
                printInOrderDFT(node.right);

            }
        }
    }

    public void printPostOrderDFT()
    {
        Console.Write("PostOrder DFT node sequence [ ");
        printPostOrderDFT(root);
        Console.WriteLine("]");
    }

    public static void printPostOrderDFT(Node node)
    {
        if (node == null)
        {
            return;
        }
        else
        {
            
            if(node.left != null)
            {
                printPostOrderDFT(node.left);
            }
            if(node.right != null)
            {
                printPostOrderDFT(node.right); 
            }
            Console.Write(node.key + " ");
        }
    }

    public static int height(Node node)
    {
        // Use recursion to implement this function
        // height = length(path{node->deepest child})

        if (node == null)
        {
            return -1;
        }
        else
        {
            return 1 + Math.Max(height(node.left), height(node.right));
        }
        
    }

    public static int size(Node node)
    {
        // Use recursion to implement this function
        // size = #children + 1(itself)
        if(node == null)
        {
            return 0;
        }
        else
        {
            return 1 + size(node.left) + size(node.right);
        }
    }

    public static int depth(Node root, Node node)
    {
        // Use recursion to implement this function
        // Similar to height() but start from node, go up to root
        // depth = length(path{node->root})
        if (node == null)
        {
            return -1;
        }
        else
        {
            if (node.parent != null)
            {
                return 1 + depth(root, node.parent);
            }
            else
            {
                return 0;
            }
            
        }
        
    }

    public int height()
    {
        return height(root);
    }

    public int size()
    {
        return size(root);
    }

    public int depth()
    {
        return height(root);
    }

    public Node findKthSmallest(int k)
    {
        // Fix the condition
        if (k < 0 && k > size(root))
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

        int l = size(node.left);
        if (k == l + 1)
        {
            return node;
        }
        else if (k < l + 1)
        {
            return findKthSmallest(node.left, k);
        }
        else
        {
            return findKthSmallest(node.right, (k - l - 1));
        }

    }

    public static Node findNext(Node node)
    {
        //this function should call other functions
        if (node.right != null)
            return leftDescendant(node.right);
        else
        {
             return rightAncestor(node);         
        }
        
    }

    public static Node leftDescendant(Node node)
    {
        // this function should be recursive
        if (node.left == null)
            return node;
        else
            return leftDescendant(node.left);
    }

    public static Node rightAncestor(Node node)
    {// Case 1 (first right parent)
        // this function should be recursive
        if (node.parent == null)
        {
            return node;
        }
        else if (node.key < node.parent.key)
            return node.parent;
        else
            return rightAncestor(node.parent);
    }

    public List rangeSearch(int x, int y)
    {
        // use append(node) to add node to the list
        List list = new List(100);
        // do something here

        Node start = findClosest(x);
        Node max = findMax(root);
        if(y > max.key)
        {
            y = max.key;
        }
        
        while(start.key <= y)
        {
            if(start.key >= x)
            {
                list.append(start);
                if(start.key == y)
                {
                    break;
                }
            }
            start = findNext(start);
        }
        
        return list;
    }







    // This function is for deleting the root node
    // If the node is not the root, please call the recursive version
    public void delete(int key)
    {
        // There should be 6 cases here
        // Non-root nodes should be forwarded to the static function
        Node node = find(key);
        if (root == null)
        {
            Console.WriteLine("Empty Tree!!!");
        }
        else if (node == null)
        {
            Console.WriteLine("Key not found!!!");

        }
        else if (node.parent == null && node.key == key)
        { 
            if (root.left == null && root.right == null)
            {
                root = null;
            }else if (root.right == null && root.left != null)
            {
                root.key = root.left.key;
                root.left.parent = null;
                root.left = null;
            }else if (root.left == null && root.right != null)
            {
                root.key = root.right.key;
                root.right.parent = null;
                root.right = null;
            }
            else
            {
                root.key = root.right.key;
                root.right = null;
            }
        }
        else
        {
            delete(node);
        }

            

    }

    // Use this function to delete non-root nodes
    public static void delete(Node node)
    {
        // There should be 7 cases here
        Node parent = node.parent;
        if (node.left == null && node.right == null)
        {
            if (parent.left != null)
            {
                if (parent.left.key == node.key)
                {
                    parent.left = null;
                }
            }
            if (parent.right != null)
            {
                if (parent.right.key == node.key)
                {
                    parent.right = null ;
                }
            }
        }
        else if (node.right == null && node.left != null && parent.left.key == node.key)
        {
            node.left.parent = parent;
            parent.left = node.left;
        } else if (node.left == null && node.right != null && parent.left.key == node.key)
        {
            node.right.parent = parent;
            parent.left = node.right;
        } else if (node.right == null && node.left != null && parent.right.key == node.key)
        {
            node.left.parent = parent;
            parent.right = node.left;

        } else if (node.left == null && node.right != null && parent.right.key == node.key)
        {
            node.right.parent = parent;
            parent.right = node.right;
        }
        else
        {
            Node temp = findMin(node.right);
            node.key = temp.key;

            if (temp.parent.left != null)
            {
                if (temp.parent.left.key == temp.key)
                {
                    temp.parent.left = null;

                }
            }
            if (temp.parent.right != null)
            {
                if (temp.parent.right.key == temp.key)
                {
                    temp.parent.right = null;

                }
            }
        }

    }
}