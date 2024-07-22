using System;
using System.Collections.Generic;

public class Graph
{

    protected Vertex[] vertexList; // This list contain vertices
    protected LinkedList<int>[] adjacencyList; // Graph implemented by Adjacency List

    protected int cap;
    protected int size;
    public int cc;

    public Graph(int cap)
    {
        // Pls initialize all varibles here

    }

    public void addVertex(int key)
    {
        if (size == cap)
        {
            Console.WriteLine("Vertex list is full. You need to recreate the Graph");
            return;
        }

        // Create Vertex object and the LinkedList object
        // Add these objects to the corresponding arrays
        // finally, size++;
    }

    // Two way edge
    // If you make a path from u to v, you must make a path from v to u
    public void addEdge(int u, int v)
    {
        if (vertexList[u] == null)
        {
            Console.WriteLine("Source node does not exist");
            return;
        }
        if (vertexList[v] == null)
        {
            Console.WriteLine("Destination node does not exist");
            return;
        }
        // Check if there is already a path from u to v
        if (!isConnected(u, v))
        {
            // Add edge that links from Vertex(u) to Vertex(v)
            // and then that links from Vertex(v) to Vertex(u)
        }
        else
        {
            Console.WriteLine("There is already a path connecting vertex " + u + " and vertex " + v);
        }
    }

    public bool isConnected(int u, int v)
    // Check if Vertex(u) and Vertex(v) has an edge to one another
    {
        return false; // Fix this
    }

    public void showAdjacentVertices(int u)
    // This function is complete, no need to edit
    // Please study how this function works
    // if you understand it, you should understand the whole homework
    {
        Vertex v = vertexList[u];
        Console.Write("Vertex " + v.strKey + " connected to the following vertices: ");

        LinkedList<int> list = adjacencyList[u];
        foreach (int vertex_index in list)
        {
            Console.Write(vertexList[vertex_index].strKey + ", ");
        }
        Console.WriteLine();
    }

    public void Explore(Vertex v)
    {

        // Mark this vertex for visited

        // Stamp the current cc number to this vertex (ccNum)

        // Print vertex
        Console.Write(v.strKey + "/" + v.ccNum + " -> ");

        // Get the list of all vertices that are connected to Vertex v

        // Traverse through the list and check if anyone are already visited or not
        // If no, then explore the vertex

    }

    public void DFS()
    {

        // Set cc (connected component number) to 1

        // Traverse all vertices and check if they are visited or not
        // If no, then explore the vertex, then increase cc by 1

        Console.WriteLine();
    }

 }
