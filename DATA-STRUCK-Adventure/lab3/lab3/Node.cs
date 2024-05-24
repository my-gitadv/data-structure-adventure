using System;

public class Node
{
    public int student_id;
    public String name;
    public double gpa;

    public Node next;
    public Node previous;

    // Constructor 1
    public Node(int id, String name, double gpa)
    {
        this.student_id = id;
        this.name = name;
        this.gpa = gpa;
    }

    // Constructor 2
    public Node(String name)
    {
        this.name = name;
    }

    // Constructor 3 (dummy)
    public Node()
    {
        // You can leave this function blank
    }

    public void printIDName()
    {
        Console.WriteLine("StudentID: " + student_id + " , Name: " + name);
    }

}
