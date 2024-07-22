﻿using System;
using System.Collections.Generic;

public class GenericCollectionTest
{
    public static void genericLinkedListTest()
    // Fix this function to have the output as shown in the HW
    {
        // Create a LinkedList object that can contains Integer
        // Name the variable to list


        int x;
        for (int i = 1; i < 10; i += 2)
        {
            x = i;
            // Add keys to the LinkedList object (list)

        }

        // Check if 5 is contained in the list
        bool check = false; // Fix this
        Console.WriteLine("5 is in the list = " + check);

        // Check if 6 is contained in the list
        check = true; // Fix this
        Console.WriteLine("6 is in the list = " + check);

        //Show all elements in the list
        // Fix all of these
        int e = 0;
        Console.Write(e + ", ");
        Console.WriteLine();
    }

    public static void genericQueueTest()
    // Fix this function to have the output as shown in the HW
    {
        // Create a queue object that can contain String's
        // Name the varible to q

        String[] names = { "Abraham", "Andrew", "Benjamin", "Claudia", "Gabriel" };
        for (int i = 0; i < names.Length; i++)
        {
            // Add names[i] to the queue object (q)

        }

        Console.WriteLine("Top = " + "Patiwet");        // Fix this
        Console.WriteLine("1st Pop = " + "Patiwet");    // Fix this
        Console.WriteLine("2nd Pop = " + "Patiwet");    // Fix this
        Console.WriteLine("3rd Pop = " + "Patiwet");    // Fix this
    }

    public static void genericStackTest()
    // Fix this function to have the output as shown in the HW
    {
        // Create a stack of object that can contain String's
        // Name the varible to s

        String[] names = { "Abraham", "Andrew", "Benjamin", "Claudia", "Gabriel" };
        for (int i = 0; i < names.Length; i++)
        {
            // Push names[i] into the stack object (s)

        }

        Console.WriteLine("Top = " + "Patiwet");        // Fix this
        Console.WriteLine("1st Pop = " + "Patiwet");    // Fix this
        Console.WriteLine("2nd Pop = " + "Patiwet");    // Fix this
        Console.WriteLine("3rd Pop = " + "Patiwet");    // Fix this
    }

    public static void arrayOfListTest()
    // Fix this function to have the output as shown in the HW
    {
        // This part is to create an array of LinkedList (each LinkedList contains String's)
        // This section is complete, no need to edit
        // Your task is to understand my code
        LinkedList<String>[] arr = new LinkedList<String>[5];
        String[] names = { "Abraham", "Andrew", "Benjamin", "Claudia", "Gabriel" };
        for (int i = 0; i < 5; i++)
        {
            LinkedList<String> list = new LinkedList<String>();
            for (int j = 0; j <= i; j++)
            {
                list.AddLast(names[j]);
            }
            arr[i] = list;
        }

        // Once you understand the above section, pls fix the following code to correct the results

        // Show all elements for each list
        for (int i = 0; i < arr.Length; i++)
        {

            // Fix these lines
            Console.Write("arr[" + i + "] = ");
            String s = "Patiwet";
            Console.Write(s + ", ");
            Console.WriteLine();
        }

        // Check if "Benjamin" is contained in any list
        for (int i = 0; i < arr.Length; i++)
        {
            // Do something

            Console.WriteLine("Benjamin is contained in arr[" + i + "]? = " + false);   // Fix this
        }
    }
}