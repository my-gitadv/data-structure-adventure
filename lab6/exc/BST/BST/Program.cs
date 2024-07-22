using System;
public class Program
{
    static void Main(string[] args)
    {

        //Tree tree = new Tree();
        //tree.printTree();



        //Tree tree = constructTree1();
        //tree.printTree();



        //Tree tree = constructTree1();
        //Node node = tree.find(3);
        //Tree.printNode(node);



        //Tree tree = constructTree1();
        //Node node = tree.find(4);
        //Tree.printNode(node);



        //Tree tree = constructTree1();
        //tree.printTree();
        //Node node = tree.findMin(); Tree.printNode(node);
        //node = tree.findMax(); Tree.printNode(node);



        //Tree tree = constructTree1();
        //tree.printTree();
        //Node node = tree.find(3);
        //node = Tree.findMin(node); Tree.printNode(node);
        //node = Tree.findMax(node); Tree.printNode(node);



        //Tree tree = constructTree2();
        //tree.printTree();
        //Node node = tree.findClosestLeaf(46);
        //Tree.printNode(node);
        //node = tree.findClosest(46);
        //Tree.printNode(node);



        //Tree tree = constructTree1();
        //tree.printTree();
        //Node node = tree.findClosestLeaf(-999); Tree.printNode(node);
        //node = tree.findClosestLeaf(999); Tree.printNode(node);
        //node = tree.findClosest(-999); Tree.printNode(node);
        //node = tree.findClosest(999); Tree.printNode(node);



        //Tree tree = constructTree1();
        //tree.printTree();
        //Node node = tree.findClosest(6);
        //node = Tree.findMin(node); Tree.printNode(node);
        //node = Tree.findMax(node); Tree.printNode(node);



        //Tree tree = constructTree1();
        //tree.printTree();
        //tree.printPreOrderDFT();
        //tree.printInOrderDFT();
        //tree.printPostOrderDFT();



        //Tree tree = constructTree3();
        //tree.printTree();

        //Node node = tree.find(7);
        //Console.WriteLine("Node " + node.key + "'s Size = " + Tree.size(node));
        //Console.WriteLine("Node " + node.key + "'s Depth = " + Tree.depth(tree.root, node));
        //Console.WriteLine("Node " + node.key + "'s Height = " + Tree.height(node));

        //Console.WriteLine("Tree Size = " + tree.size());
        //Console.WriteLine("Tree Depth = " + tree.depth());
        //Console.WriteLine("Tree Height = " + tree.height());



        //Tree tree = new Tree();
        //Console.WriteLine("Tree Size = " + tree.size());
        //Console.WriteLine("Tree Depth = " + tree.depth());
        //Console.WriteLine("Tree Height = " + tree.height());
        //tree.insert(55);
        //Console.WriteLine("Tree Size = " + tree.size());
        //Console.WriteLine("Tree Depth = " + tree.depth());
        //Console.WriteLine("Tree Height = " + tree.height());



        //Tree tree = constructTree3();
        //tree.printTree();
        //Node n;
        //int[] data = { 5, 7, 1, 9, 8 };
        //int s, h, d;
        //for (int i = 0; i < data.Length; i++)
        //{
        //    n = tree.find(data[i]);
        //    s = Tree.size(n);
        //    h = Tree.height(n);
        //    d = Tree.depth(tree.root, n);
        //    Console.WriteLine("Node key " + n.key + " : size=" + s + " height=" + h + " depth=" + d);
        //}



        //Tree tree = new Tree();
        //int[] keyList = { 5, 2, 3, 9, 1, 10, 8, 7 };
        //for (int i = 0; i < keyList.Length; i++)
        //    tree.insert(keyList[i]);
        //tree.printTree();
        //Node node = tree.findKthSmallest(6);
        //Console.WriteLine("The Node key " + node.key + " is the 6th smallest node");

        //Console.Write("The 4th, 5th, 6th smallest nodes are node keys ");
        //for (int i = 4; i <= 6; i++)
        //{
        //    node = tree.findKthSmallest(i);
        //    Console.Write(node.key + " ");
        //}
        //Console.WriteLine();



        Tree tree = new Tree();
        int[] keyList = { 6, 7, 9, 5, 3, 10, 11, 8, 1 };
        for (int i = 0; i < keyList.Length; i++)
            tree.insert(keyList[i]);
        tree.printTree();

        List list = tree.rangeSearch(4, 8);
        list.printList();

        //list = tree.rangeSearch(-99, 4);
        //list.printList();

        //list = tree.rangeSearch(-99, 99);
        //list.printList();


        /*
        Tree tree = new Tree();
        int[] keyList = { 5, 3, 7 };
        for (int i = 0; i < keyList.Length; i++)
            tree.insert(keyList[i]);
        tree.printTree();
        tree.delete(0);
        Console.WriteLine("-----");
        tree.delete(5); tree.printTree();
        tree.delete(7); tree.printTree();
        tree.delete(3);
        Console.WriteLine("-----");
        tree.printTree();
        tree.delete(0);
        Console.WriteLine("-----");
        */

        /*
        Tree tree = new Tree();
        int[] keyList = { 5, 3, 7 };
        for (int i = 0; i < keyList.Length; i++)
            tree.insert(keyList[i]);
        tree.printTree();
        tree.delete(0);
        Console.WriteLine("-----");
        tree.delete(3); tree.printTree();
        tree.delete(7); tree.printTree();
        tree.delete(5);
        Console.WriteLine("-----");
        tree.printTree();
        tree.delete(0);
        Console.WriteLine("-----");
        */

        /*
        Tree tree = constructTree4();
        tree.printTree();
        tree.delete(10); tree.printTree();
        tree.delete(9); tree.printTree();
        */

        /*
        Tree tree = constructTree4();
        tree.printTree();
        tree.delete(1); tree.printTree();
        tree.delete(2); tree.printTree();
        tree.delete(3); tree.printTree();
        */

        /*
        Tree tree = constructTree4();
        tree.printTree();
        tree.delete(6); tree.printTree();
        tree.delete(7); tree.printTree();
        */

        /*
        Tree tree = constructTree4();
        tree.printTree();
        tree.delete(9); tree.printTree();
        tree.delete(7); tree.printTree();
        */
    }

    public static Tree constructTree1()
    {
        Node root = new Node(5);
        root.left = new Node(3);
        root.left.left = new Node(1);
        root.left.left.right = new Node(2);
        root.right = new Node(7);
        root.right.right = new Node(9);
        root.right.right.left = new Node(8);
        root.right.right.right = new Node(10);
        return new Tree(root);
    }

    public static Tree constructTree2()
    {
        Node root = new Node(50);
        root.left = new Node(30);
        root.left.left = new Node(10);
        root.left.left.right = new Node(20);
        root.right = new Node(70);
        root.right.right = new Node(90);
        root.right.right.left = new Node(80);
        root.right.right.right = new Node(99);
        return new Tree(root);
    }

    public static Tree constructTree3()
    {
        Tree tree = new Tree();
        int[] keyList = { 5, 3, 1, 2, 7, 9, 10, 8 };
        for (int i = 0; i < keyList.Length; i++)
            tree.insert(keyList[i]);
        return tree;
    }

    public static Tree constructTree4()
    {
        Tree tree = new Tree();
        int[] keyList = { 5, 3, 7, 1, 6, 9, 2, 8, 10 };
        for (int i = 0; i < keyList.Length; i++)
            tree.insert(keyList[i]);
        return tree;
    }
}