using System;

public class DoublyLinkedList
{
    Node head;
    Node tail;
    String listName;
    
    public DoublyLinkedList(String name)
    {
        this.listName = name;
        head = null;
        tail = null; 
    }

    public void popBack()
    {
        if (isEmpty())
        {
            Console.WriteLine("ERROR");
        }
        else
        {
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.previous;
                tail.next = null;
            }
        }
    }

    public void popFront()
    {
        if (isEmpty())
        {
            Console.WriteLine("ERROR");
        }
        else
        {
            if(head == tail)
            {
                head = null;
                tail = null;
            }else
            {
                head = head.next;
                head.previous = null;
            }
        }
    }

    public Node topFront()
    {
        if (isEmpty())
        {
            Console.WriteLine("ERROR");
            return new Node("Empty List!");
        }
        else
        {
            return head;
        }
    }

    public Node topBack()
    {
        if (isEmpty())
        {
            Console.WriteLine("ERROR");
            return new Node("Empty List");
        }
        else
        {
            return tail;
        }
    }

    public void pushFront(Node node)
    {
        if (isEmpty())
        {
            head = node;
            tail = node;

        }
        else
        {
            head.previous = node;
            node.next = head;
            head = node;           

        }
    }

    public void pushBack(Node node)
    {
        if (isEmpty())
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            node.previous = tail;
            tail = node;

        }
    }

    public Node findNode(int id)
    {
        if (isEmpty())
        {
            return new Node("Empty List!");
        }
        else
        {
            Node current = new Node();
            current = head;

            while(current != null){
                if (current.student_id == id){
                    return current;
                }
                current = current.next;
            }
            return new Node("Student Not Found!");
        }
    }

    public Node eraseNode(int id)
    {
        if (isEmpty())
        {
            Console.WriteLine("ERROR");
            return new Node("Empty List!");
        }
        else
        {
            Node current = new Node();
            current = head;

            while (current != null){
                if (current.student_id == id){
                    if(current.previous == null) {
                        head = head.next;
                        head.previous = null;
                        return current;
                    }else if(current.next == null){
                        tail = tail.previous;
                        tail.next = null;
                        return current;
                    }else{
                        (current.previous).next = current.next;
                        current.next = current.previous;
                        return current;
                    }
                }
                current = current.next;
            }
            return new Node("Student Not Found!");
        }
    }

    public void addNodeAfter(Node refNode, Node newNode)
    {
        if (refNode.next == null)
        {
            refNode.next = newNode;
            newNode.previous = refNode;
            tail = newNode;
        }
        else
        {
            newNode.previous = refNode;
            newNode.next = refNode.next;
            (refNode.next).previous = newNode;
            refNode.next = newNode;
        }
    }

    public void addNodeBefore(Node refNode, Node newNode)
    {
        if(refNode.previous == null)
        {
            newNode.next = refNode;
            refNode.previous = newNode;
            head = newNode;
        }
        else
        {
            newNode.previous = refNode.previous;
            newNode.next = refNode;
            (refNode.previous).next = newNode;
            refNode.previous = newNode;
        }
    }

    public bool isEmpty()
    {
        
        if (head == null)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public void merge(DoublyLinkedList list)
    {
        
        tail.next = list.head;
        list.head.previous = tail;
        tail = list.tail;
    }

    public void printStructure()
    {
       Node current = head;
        Console.Write(listName + ": head <->");
        while(current != null)
        {
            Console.Write("{" + current.student_id + "} <-> ");
            current = current.next;
        }
        Console.WriteLine("tail");

    }

    // This may be useful for you for implementing printStructure()
    public void printStructureBackward()
    {
        Node current = tail;
        Console.Write(listName + ": tail <-> ");
        while (current != null)
        {
            Console.Write("{" + current.student_id + "} <-> ");
            current = current.previous;
        }

        Console.WriteLine("head");
    }

    public Node whoGotHighestGPA()
    {
        if (isEmpty())
        {
            return new Node("Empty List!");
        }
        else
        {
            Node top = new Node();
            Node current = head;
            
            while (current != null)
            {
                if (current.gpa >= top.gpa)
                {
                    top = current;
                }
                current = current.next;
            }
            
            return top;
        }
    }
}