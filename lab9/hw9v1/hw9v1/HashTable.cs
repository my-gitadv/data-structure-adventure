using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

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

        int bin = getIndex(s);
        arr[bin] = s;


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
        int bin = polyHash(s);

        for (int k = 0; k < capacity; k++)
        {
            bin = (bin + k) % capacity;
            if (arr[bin] == s)
                return bin;
            if (arr[bin] == null)
                return bin;

        }

        return -1;

    }

    public int polyHash(String s)
    // Check the slide for the pseudocode
    // If you want to access a char of string s at index i, use s[i]
    // If you want to get the ASCII code of char c, use (int)c

    {
        long hash = 0;
        long pPow = 1;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            hash = (hash + (long)c * pPow) % p;
            pPow = (pPow * x) % p;
        }

        return (int) hash;
    }

}