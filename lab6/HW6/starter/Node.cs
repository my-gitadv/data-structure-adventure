using System;
public class Node
{
    public Node left;
    public Node right;
    public Node parent;
    public int key;

    public Node(int key)
    {
        this.key = key;
    }
}