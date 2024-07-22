using System;
using System.Collections.Generic;

public class HashGraph : Graph
{

    int p; // Big Prime (for PolyHash())
    int x; // Small number (for PolyHash())

    public HashGraph(int cap, int p, int x) : base(cap) // Forward the parameter cap to Graph's constructor
    {
        this.p = p;
        this.x = x;
    }

    public int polyHash(String s)
    {
        // Please copy code from the similar function in HashTable.cs here
        
        return 0;   // Fix this
    }

    public int getListIndex(String s)
    {
        // Please copy/modify code from the similar function in HashTable.cs here

        return 0;   // Fix this
    }

    public void addVertex(String key)
    {
        if (size == cap)
        {
            Console.WriteLine("Vertex list is full. You need to rehash");
            return;
        }
        
        // Map the String key to the array index (use getListIndex())
        // Add the appropriate objects in vertexList and adjacencyList
        
    }

    public void addEdge(String source, String destination)
    {
        // Map city names to integers (array indices)
        // Then call base.addEdge() to connect these two cities together

    }

    public void BFS(Vertex s)
    {
        // Set all Vertex.dist to Infinity (Use int.MaxValue to represent Infinity)

        // Set dist of the start vertex (s) to 0

        // Enqueue the start vertex to an empty queue

        // [*] Check if the queue is not empty
        // Dequeue to obtain the current vertex
        // Get a list of all vertices that are connected to current vertex

        // Traverse all the list, and check if the dist value of anyone are still infinity or not
        // If yes,  enqeueu that vertex into the queue
        //          increase the dist variable of that vertex by one
        //          set the prev variable of that vertex to the current vertex

        // Repeat [*]
    }

    public Stack<Vertex> getShortestPathList(Vertex S, Vertex U)
    {
        // Create a stack

        // Start from city U
        // [*] push the current city into the stack
        // Go back one city using U.prev
        // Repeat [*] until you reach the city S

        // return the stack
        return null; // Fix this
    }

    public void printShortestPath(String s_str, String u_str)
    {
        // Map city names to index numbers
        // Get vertices from the vertexList
        // Run BFS() at the starting city
        // Get shortestPartList(starting city, ending city)
        // Traverse all the stack and print the city name
    }

    public void showVertexList()
    // This function is complete, no need to edit
    {
        for (int i = 0; i < vertexList.Length; i++)
        {
            if (vertexList[i] != null)
                Console.WriteLine("vertexList[" + i + "] contains " + vertexList[i].strKey);
            else
                Console.WriteLine("vertexList[" + i + "] null");
        }
    }

}