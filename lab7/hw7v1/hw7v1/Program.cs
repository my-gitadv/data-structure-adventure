using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {

        //BSTree tree = generateTree1();
        //tree.printTree();
        //Console.WriteLine("---- Test1 singleRotateFromLeft at Lv 3 ----");
        //tree.singleRotateFromLeft(tree.find(6));
        //tree.singleRotateFromLeft(tree.find(2));
        //tree.printTree();



        //BSTree tree = generateTree1();
        //Console.WriteLine("---- Test2 singleRotateFromRight at Lv 3 ----");
        //tree.singleRotateFromRight(tree.find(10));
        //tree.singleRotateFromRight(tree.find(14));
        //tree.printTree();



        //BSTree tree = generateTree1();
        //Console.WriteLine("---- Test3 singleRotateFromLeft at Lv 2 ----");
        //tree.singleRotateFromLeft(tree.find(4));
        //tree.printTree();



        //BSTree tree = generateTree1();
        //tree.printTree();
        //Console.WriteLine("---- Test4 singleRotateFromRight at Lv 2 ----");
        //tree.singleRotateFromRight(tree.find(12));
        //tree.printTree();
        //Console.WriteLine("---- Test5 singleRotateFromLeft at Lv 1 ----");
        //tree.singleRotateFromLeft(tree.find(8));
        //tree.printTree();
        //Console.WriteLine("---- Test6 singleRotateFromRight at Lv 1 ----");
        //tree.singleRotateFromRight(tree.find(4));
        //tree.singleRotateFromLeft(tree.find(14));
        //tree.printTree();



        //BSTree tree = generateTree1();
        //tree.printTree();
        //Console.WriteLine("---- Test7 doubleRotateFromRight at Lv 1 ----");
        //tree.doubleRotateFromRight(tree.find(8));
        //tree.printTree();



        //BSTree tree = generateTree1();
        //Console.WriteLine("---- Test8 doubleRotateFromLeft at Lv 1 ----");
        //tree.doubleRotateFromLeft(tree.find(8));
        //tree.printTree();



        //BSTree tree = generateTree1();
        //tree.printTree();
        //Console.WriteLine("---- Test9.1 doubleRotateFromLeft at Lv 2 ----");
        //tree.doubleRotateFromLeft(tree.find(4));
        //tree.printTree();
        //Console.WriteLine("---- Test9.2 doubleRotateFromLeft at Lv 2 ----");
        //tree.doubleRotateFromLeft(tree.find(12));
        //tree.printTree();



        //BSTree tree = generateTree1();
        //tree.printTree();
        //Console.WriteLine("---- Test10.1 doubleRotateFromRight at Lv 2 ----");
        //tree.doubleRotateFromRight(tree.find(4));
        //tree.printTree();
        //Console.WriteLine("---- Test10.2 doubleRotateFromRight at Lv 2 ----");
        //tree.doubleRotateFromRight(tree.find(12));
        //tree.printTree();



        //AVLTree tree = generateTree2();
        //BFT(tree);
        //tree.insert(73); // must perform SingleRotationFromLeft(Node 81)
        //BFT(tree);



        //AVLTree tree = generateTree2();
        //BFT(tree);
        //tree.insert(73); // must perform SingleRotationFromLeft(Node 81)
        //tree.insert(77); // must perform DoubleRotationFromLeft(Node 87)
        //tree.insert(76); // must perform SingleRotationFromLeft(Node 78)
        //tree.insert(80); // must perform DoubleRotationFromRight(Node 69)
        //tree.insert(74); // must perform SingleRotationFromRight(Node 72)
        //tree.insert(64); // do nothing
        //tree.insert(55); // must perform SingleRotationFromLeft(Node 69)
        //tree.insert(70); // must perform DoubleRotationFromRight(Node 51)
        //BFT(tree);



        //AVLTree tree = generateTree2();
        //BFT(tree);
        //tree.insert(73); // must perform SingleRotationFromLeft(Node 81)
        //tree.insert(77); // must perform DoubleRotationFromLeft(Node 87)
        //BFT(tree);



        //AVLTree tree = generateTree3();
        //BFT(tree);
        //tree.delete(1);
        //BFT(tree);



        //AVLTree tree = generateTree3();
        //BFT(tree);
        //tree.delete(4);
        //BFT(tree);



        //AVLTree tree = generateTree3();
        //BFT(tree);
        //tree.delete(16);
        //BFT(tree);



        //AVLTree tree = generateTree3();
        //BFT(tree);
        //tree.delete(21);
        //BFT(tree);



        //AVLTree tree = generateTree3();
        //BFT(tree);
        //tree.delete(35);
        //BFT(tree);



        //AVLTree tree1 = new AVLTree();
        //int[] keyList = { 1, 15, 3, 13, 5, 11, 9, 10, 8, 4, 12, 7, 2, 6, 14 };
        //for (int i = 0; i < keyList.Length; i++)
        //    tree1.insert(keyList[i]); // Test sequential insert into an AVL Tree
        //tree1.printTree();



        //AVLTree tree1 = new AVLTree();
        //int[] keyList = { 1, 15, 3, 13, 5, 11, 9, 10, 8, 4, 12, 7, 2, 6, 14 };

        //for (int i = 0; i < keyList.Length; i++)
        //    tree1.insert(keyList[i]);
        //tree1.printTree();

        //for (int i = 0; i < keyList.Length; i++)
        //{
        //    tree1.delete(keyList[i]);
        //}

        //tree1.printTree();




        //BSTree2 tree = new BSTree2();
        //int[] keys = { 5, 3, 1, 2, 4, 7, 6, 9, 8 };
        //for (int i = 0; i < keys.Length; i++)
        //    tree.insert(keys[i]);
        //tree.printTree();



        //BSTree2 tree = new BSTree2();
        //int[] keys = { 5, 3, 1, 2, 4, 7, 6, 9, 8 };
        //for (int i = 0; i < keys.Length; i++)
        //    tree.insert(keys[i]);
        //Node x = tree.find(2);
        //Console.WriteLine(x.key);



        //BSTree2 tree = new BSTree2();
        //int[] keys = { 5, 3, 1, 2, 4, 7, 6, 9, 8 };
        //for (int i = 0; i < keys.Length; i++)
        //    tree.insert(keys[i]);
        //Node x = tree.find(10);
        //Console.WriteLine(x);



        //BSTree2 tree = new BSTree2();
        //int[] keys = { 5, 3, 1, 2, 4, 7, 6, 9, 8 };
        //for (int i = 0; i < keys.Length; i++)
        //    tree.insert(keys[i]);
        //Node x = tree.findMin();
        //Node y = tree.findMax();
        //Console.WriteLine("Min = " + x.key + ", Max = " + y.key);



        //SplayTree tree = new SplayTree();
        //for (int i = 0; i < 4; i++)
        //    tree.insert(i + 1); // with splay()
        //tree.printTree();
        //Node node;
        //Console.WriteLine("Zig Node (1)");
        //node = tree.find(1, false); // false means no splay()
        //tree.zig(node);
        //tree.printTree();

        //Console.WriteLine("Zig Node (3)");
        //node = tree.find(3, false);
        //tree.zig(node);
        //tree.printTree();

        //Console.WriteLine("Zig Node (2)");
        //node = tree.find(2, false);
        //tree.zig(node);
        //tree.printTree();

        //Console.WriteLine("Zig Node (4)");
        //node = tree.find(4, false);
        //tree.zig(node);
        //tree.printTree();



        //SplayTree tree = new SplayTree();
        //int[] keyList = { 5, 7, 2, 3, 1, 6, 8 };
        //for (int i = 0; i < keyList.Length; i++)
        //{
        //    tree.insert(keyList[i]);    // with splay()
        //    //tree.printTree();
        //}
        //tree.printTree();


        //Node node1, node2, node3, node5, node7;
        ////This find(key, false) means do not splay the node
        //node1 = tree.find(1, false);
        //node2 = tree.find(2, false);
        //node3 = tree.find(3, false);
        //node5 = tree.find(5, false);
        //node7 = tree.find(7, false);

        //Console.WriteLine("ZigZig Node (1)");
        //tree.zigzig(node1);
        //tree.printTree();

        //Console.WriteLine("ZigZag Node (5)");
        //tree.zigzag(node5);
        //tree.printTree();

        //Console.WriteLine("ZigZag Node (5)");
        //tree.zigzag(node5);
        //tree.printTree();

        //Console.WriteLine("ZigZag Node (7)");
        //tree.zigzag(node7);
        //tree.printTree();

        //Console.WriteLine("ZigZag Node (2)");
        //tree.zigzag(node2);
        //tree.printTree();

        //Console.WriteLine("ZigZag Node (3)");
        //tree.zigzag(node3);
        //tree.printTree();

        //Console.WriteLine("ZigZig Node (7)");
        //tree.zigzig(node7);
        //tree.printTree();


        
        Stopwatch stopwatch = new Stopwatch();
        Random rnd = new Random();

        BSTree2 tree1 = new BSTree2();
        stopwatch.Start();
        int N = 40000;
        for (int i = 0; i < N; i++)
            tree1.insert(i);
        stopwatch.Stop();
        Console.WriteLine("Time for sequentially inserting " + N + " objects into BST = " + stopwatch.ElapsedMilliseconds + " msec");
        
        stopwatch.Restart();
        for (int i = 0; i < N; i++)
            tree1.find(rnd.Next(0, N));
        stopwatch.Stop();
        Console.WriteLine("Time for finding " + N + " different objects in BST= " + stopwatch.ElapsedMilliseconds + " msec");

        
        SplayTree tree2 = new SplayTree();
        stopwatch.Restart();
        for (int i = 0; i < N; i++)
            tree2.insert(i);
        stopwatch.Stop();
        Console.WriteLine("Time for sequentially inserting " + N + " objects into SplayTree = " + stopwatch.ElapsedMilliseconds + " msec");

        stopwatch.Restart();
        for (int i = 0; i < N; i++)
            tree2.find(rnd.Next(0, N), true);
        stopwatch.Stop();
        Console.WriteLine("Time for finding " + N + " different objects in SplayTree = " + stopwatch.ElapsedMilliseconds + " msec");

        Console.WriteLine("Which one is faster: BSTree or SplayTree?");
        
    }

    public static BSTree generateTree1()
    // This function is complete, no need to edit
    {
        int[] keyList = { 8, 4, 12, 2, 6, 10, 14, 1, 3, 5, 7, 9, 11, 13, 15 };
        BSTree tree = new BSTree();
        for (int i = 0; i < keyList.Length; i++)
            tree.insert(keyList[i]);
        return tree;
    }

    public static AVLTree generateTree2()
    // This function is complete, no need to edit
    {
        AVLTree tree = new AVLTree();
        int[] keyList = { 51, 30, 69, 18, 42, 63, 87, 12, 24, 36, 45, 57, 66, 81, 93, 15, 21, 27, 33, 39, 48, 54, 60, 75, 84, 90, 96, 72, 78 };
        for (int i = 0; i < keyList.Length; i++)
            tree.insert(keyList[i]);
        return tree;
    }

    public static AVLTree generateTree3()
    // This function is complete, no need to edit
    {
        AVLTree tree = new AVLTree();
        int[] keyList = {21, 8, 34, 3, 16, 26, 42, 2, 5, 11, 18, 23, 31, 37, 47,
            1, 4, 6, 9, 13, 17, 19, 22, 24, 28, 33, 35, 40, 45, 52, 7, 10, 12,
            14, 20, 25, 27, 30, 32, 36, 38, 41, 43, 46, 49, 53, 15, 29, 39, 44,
            48, 51, 54, 50};
        for (int i = 0; i < keyList.Length; i++)
            tree.insert(keyList[i]);
        return tree;
    }

    public static AVLTree generateTree4()
    // This function is complete, no need to edit
    {
        AVLTree tree = new AVLTree();
        int[] keyList = { 10, 5, 13, 3, 8, 11, 15, 1, 4, 7, 9, 12, 14, 2, 6 };
        for (int i = 0; i < keyList.Length; i++)
            tree.insert(keyList[i]);
        return tree;
    }

    public static void BFT(AVLTree tree)
    // This function is complete, no need to edit
    {
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(tree.root);
        Console.Write("BFT [ ");
        while (!(q.Count == 0))
        {
            Node node = q.Dequeue();
            Console.Write(node.key + " ");
            if (node.left != null)
                q.Enqueue(node.left);
            if (node.right != null)
                q.Enqueue(node.right);
        }
        Console.WriteLine("]");

    }
}