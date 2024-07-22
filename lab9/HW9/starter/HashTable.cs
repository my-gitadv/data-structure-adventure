using System;

public class HashTable
{
    String[] arr;
    int size;
    int capacity;

    // Hashing parameters
    int p; // Big Prime (for PolyHash())
    int x; // Small number (for PolyHash())

    public HashTable(int cap, int p, int x)
    {
        arr = new String[cap];
        this.capacity = cap;
        this.p = p;
        this.x = x;
    }

    public void addString(String s)
    {
        // Add string s to the array at the unoccupied slot
        // You should call getIndex() to check unoccupied slot
    }

    public int getIndex(String s)
    // This function has 2 roles
    // [1] Find an empty space to push the string object
    // [2] Find location of the string
    // The algorithm is followed
    // 1. Hash the string and get the index
    // 2. If the arr[index] is empty, then return index
    // 3. If the arr[index] equals the string, then also return index
    // 4. Perform the quadratic probing and repeat 2.-3. until found the location
    {
        // Do something

        return 0;   // Fix this
    }

    public int polyHash(String s)
    // Check the slide for the pseudocode
    // If you want to access a char of string s at index i, use s[i]
    // If you want to get the ASCII code of char c, use (int)c
    {
        int hash = 0;
        // Do something

        return hash;
    }

}