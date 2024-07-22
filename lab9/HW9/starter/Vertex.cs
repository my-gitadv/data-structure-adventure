using System;

public class Vertex
{

    // Vertex Information
    public String strKey;
    public int intKey;

    // For BFS and DFS only
    public int ccNum;
    public bool visited;
    public int dist;

    // This previous pointer is needed for constructing shortest-path tree
    // Hint: This variable is used only in functions BFS() and getShortestPathList()
    public Vertex prev;

    public Vertex(String key)
    {
        this.strKey = key;
    }

    public Vertex(int key)
    {
        this.intKey = key;
        this.strKey = key.ToString();
    }


}
