using System;
using System.Collections.Generic;


public class BTreePrinter
{

    protected void printTree(Node node)
    {
        int maxLevel = this.maxLevel(node);
        List<Node> singletonList = new List<Node>();
        singletonList.Add(node);

        printNodeInternal(singletonList, 1, maxLevel);
    }

    private void printNodeInternal(List<Node> nodes, int level, int maxLevel)
    {
        if (nodes.Count==0 || isAllElementsNull(nodes))
            return;

        int floor = maxLevel - level;
        int endgeLines = (int)Math.Pow(2, (Math.Max(floor - 1, 0)));
        int firstSpaces = (int)Math.Pow(2, (floor)) - 1;
        int betweenSpaces = (int)Math.Pow(2, (floor + 1)) - 1;

        printWhitespaces(firstSpaces);

        List<Node> newNodes = new List<Node>();
        foreach (Node node in nodes)
        {
            if (node != null)
            {
                Console.Write(node.key);
                newNodes.Add(node.left);
                newNodes.Add(node.right);
            }
            else
            {
                newNodes.Add(null);
                newNodes.Add(null);
                Console.Write(" ");
            }

            printWhitespaces(betweenSpaces);
        }
        Console.WriteLine("");

        for (int i = 1; i <= endgeLines; i++)
        {
            for (int j = 0; j < nodes.Count; j++)
            {
                printWhitespaces(firstSpaces - i);
                if (nodes[j] == null)
                {
                    printWhitespaces(endgeLines + endgeLines + i + 1);
                    continue;
                }

                if (nodes[j].left != null)
                    Console.Write("/");
                else
                    printWhitespaces(1);

                printWhitespaces(i + i - 1);

                if (nodes[j].right != null)
                    Console.Write("\\");
                else
                    printWhitespaces(1);

                printWhitespaces(endgeLines + endgeLines - i);
            }

            Console.WriteLine("");
        }

        printNodeInternal(newNodes, level + 1, maxLevel);
    }

    private void printWhitespaces(int count)
    {
        for (int i = 0; i < count; i++)
            Console.Write(" ");
    }

    private int maxLevel(Node node)
    {
        if (node == null)
            return 0;

        return Math.Max(maxLevel(node.left), maxLevel(node.right)) + 1;
    }

    private bool isAllElementsNull(List<Node> list)
    {
        foreach (Node obj in list)
        {
            if (obj != null)
                return false;
        }

        return true;
    }
}
