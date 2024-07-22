﻿using System;

public class Program
{
    static void Main(string[] args)
    {

        //Node a = new Node(7);
        //a.printTree();


        //Node tree = constructTree1();
        //tree.printTree();



        //Node tree = constructTree2();
        //tree.printTree();



        //Stack s = new Stack(4);
        //s.pop();

        //s = new Stack(4);
        //s.push(new Node(5));
        //s.push(new Node(6));
        //s.push(new Node(7));
        //s.push(new Node(8));
        //s.printStack();
        //s.push(new Node(9));



        //Stack s = new Stack(4);
        //s.push(new Node(5));
        //s.push(new Node(6));
        //s.push(new Node(7));
        //s.push(new Node(8));
        //s.push(new Node(9));
        //Console.WriteLine(s.pop().data);
        //Console.WriteLine(s.pop().data);
        //Console.WriteLine(s.pop().data);
        //s.printStack();



        //Queue q = new Queue(4);
        //q.dequeue();
        //q.enqueue(new Node(5));
        //q.enqueue(new Node(6));
        //q.enqueue(new Node(7));
        //q.enqueue(new Node(8));
        //q.printQueue();
        //q.enqueue(new Node(9));



        //Queue q = new Queue(4);
        //q.enqueue(new Node(5));
        //q.enqueue(new Node(6));
        //q.enqueue(new Node(7));
        //q.enqueue(new Node(8));
        //q.enqueue(new Node(9));
        //Console.WriteLine(q.dequeue().data);
        //Console.WriteLine(q.dequeue().data);
        //Console.WriteLine(q.dequeue().data);
        //q.printQueue();



        //Queue q = new Queue(4);
        //q.printCircularIndices();
        //q.enqueue(new Node(5));
        //q.enqueue(new Node(6));
        //q.printCircularIndices();
        //q.enqueue(new Node(7));
        //q.enqueue(new Node(8));
        //q.printCircularIndices();
        //q.printQueue();
        //Console.WriteLine(q.dequeue().data);
        //q.printCircularIndices();
        //Console.WriteLine(q.dequeue().data);
        //q.printCircularIndices();
        //Console.WriteLine(q.dequeue().data);
        //q.printCircularIndices();
        //q.enqueue(new Node(9));
        //q.enqueue(new Node(10));
        //q.enqueue(new Node(11));
        //q.printQueue();



        //Node tree = constructTree1();
        //tree.printTree();
        //tree.printBFT();
        //tree.printDFT();



        Node tree = constructTree2();
        tree.printTree();
        tree.printBFT();
        tree.printDFT();

    }

    public static Node constructTree1()
    {
        Node root = new Node(3); // Fix this

        root.left = new Node(7);
        root.right = new Node(5);

        root.left.left = new Node(2);
        root.left.right = new Node(6);
        root.right.right = new Node(9);

        root.left.right.left = new Node(1);
        root.left.right.right = new Node(8);
        root.right.right.left = new Node(4);

        return root;
    }
    public static Node constructTree2()
    {
        Node root = new Node(1); // Fix this

        root.left = new Node(2);
        root.right = new Node(3);

        root.left.left = new Node(4);
        root.left.right = new Node(5);
        root.right.right = new Node(6);

        root.left.right.left = new Node(7);
        root.left.right.right = new Node(8);
        root.right.right.left = new Node(9);

        root.left.right.right.right = new Node(10);


        return root;
    }
}