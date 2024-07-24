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

        {
            long hash = 0;
            long pPow = 1;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                hash = (hash + (long)c * pPow) % p;
                pPow = (pPow * x) % p;
            }

            return (int)hash;
        }

    }

    public int getListIndex(String s)
    {
        // Please copy/modify code from the similar function in HashTable.cs here

        {
            int bin = polyHash(s);

            for (int k = 0; k < cap; k++)
            {
                bin = (bin + k) % cap;
                if (vertexList[bin] != null && vertexList[bin].strKey == s)
                    return bin;
                if (vertexList[bin] == null)
                    return bin;

            }

            return -1;

        }
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
        int bin = getListIndex(key);
        vertexList[bin] = new Vertex(key);
        adjacencyList[bin] = new LinkedList<int>();
        size++;

    }

    public void addEdge(String source, String destination)
    {
        // Map city names to integers (array indices)
        // Then call base.addEdge() to connect these two cities together
        int u = getListIndex(source);
        int v = getListIndex(destination);

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
            adjacencyList[u].AddLast(v);
            adjacencyList[v].AddLast(u);


        }
        else
        {
            Console.WriteLine("There is already a path connecting vertex " + u + " and vertex " + v);
        }

    }

    public void BFS(Vertex s)
    {
        Queue<Vertex> q = new Queue<Vertex>();

        // Set all Vertex.dist to Infinity (Use int.MaxValue to represent Infinity)
        foreach (Vertex u in vertexList) 
        {
            if (u != null)
            {
                u.dist = int.MaxValue;
                u.prev = null;
            }
            
        }

        // Set dist of the start vertex (s) to 0
        s.dist = 0;
        // Enqueue the start vertex to an empty queue
        q.Enqueue(s);

        // [*] Check if the queue is not empty
        // Dequeue to obtain the current vertex
        // Get a list of all vertices that are connected to current vertex
        while (q.Count > 0)
        {
            Vertex u = q.Dequeue();
            foreach (int v_con in adjacencyList[getListIndex(u.strKey)])
            {
                if (vertexList[v_con] != null && vertexList[v_con].dist == int.MaxValue)
                {
                    q.Enqueue(vertexList[v_con]);
                    vertexList[v_con].dist = u.dist + 1;
                    vertexList[v_con].prev = u;
                }

            }

        }

        // Traverse all the list, and check if the dist value of anyone are still infinity or not
        // If yes,  enqeueu that vertex into the queue
        //          increase the dist variable of that vertex by one
        //          set the prev variable of that vertex to the current vertex

        // Repeat [*]
    }

    public Stack<Vertex> getShortestPathList(Vertex S, Vertex U)
    {
        // Create a stack
        Stack<Vertex> stack = new Stack<Vertex>();

        // Start from city U
        // [*] push the current city into the stack
        // Go back one city using U.prev
        // Repeat [*] until you reach the city S
        while (U.strKey != S.strKey)
        {
            stack.Push(U);
            U = U.prev;
        }

        // return the stack
        return stack; // Fix this
    }

    public void printShortestPath(String s_str, String u_str)
    {
        // Map city names to index numbers
        int s = getListIndex(s_str);
        int u = getListIndex(u_str);

        // Get vertices from the vertexList
        Vertex S = vertexList[s];
        Vertex U = vertexList[u];

        // Run BFS() at the starting city
        this.BFS(S);

        // Get shortestPartList(starting city, ending city)
        Stack<Vertex> path = new Stack<Vertex>();
        path = getShortestPathList(S, U);

        // Traverse all the stack and print the city name
        Console.Write(S.strKey + " -> ");
        while (path.Count > 0) 
        {
            Console.Write(path.Pop().strKey + " -> ");
        }
        Console.WriteLine(" ");

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