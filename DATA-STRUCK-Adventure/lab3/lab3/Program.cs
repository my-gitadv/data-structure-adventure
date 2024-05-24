using System;

public class Program
{
    static void Main(string[] args)
    {


        //Node node;
        //DoublyLinkedList list1 = new DoublyLinkedList("list1");
        //node = new Node(5906001, "Matthew", 3.50);
        //list1.pushFront(node);
        //node = new Node(5906002, "Mark", 2.75);
        //list1.pushFront(node);
        //node = new Node(5906003, "Luke", 3.00);
        //list1.pushFront(node);
        //node = new Node(5906004, "John", 3.75);
        //list1.pushFront(node);
        //list1.printStructure();
        //DoublyLinkedList list2 = new DoublyLinkedList("list2");
        //list2.pushBack(new Node(5906005, "James", 3.25));
        //list2.pushBack(new Node(5906006, "Peter", 2.85));
        //list2.pushBack(new Node(5906007, "John", 2.50));
        //list2.pushBack(new Node(5906008, "Jude", 3.15));
        //list2.printStructure();
        //list1.merge(list2);
        //list1.printStructure();


        
        //Node node;
        //DoublyLinkedList list = new DoublyLinkedList("list3");
        //node = list.topFront();
        //node.printIDName();
        //node = list.topBack();
        //node.printIDName();
        //list.pushBack(new Node(5906001, "Matthew", 3.50));
        //list.pushBack(new Node(5906002, "Mark", 2.75));
        //list.pushBack(new Node(5906003, "Luke", 3.00));
        //node = list.topFront();
        //node.printIDName();
        //node = list.topBack();
        //node.printIDName();


        
        //DoublyLinkedList list = new DoublyLinkedList("list4");
        //list.printStructure();
        //list.popFront();
        //list.pushBack(new Node(5906001, "Matthew", 3.50));
        //list.pushBack(new Node(5906002, "Mark", 2.75));
        //list.pushBack(new Node(5906003, "Luke", 3.00));
        //list.pushBack(new Node(5906004, "John", 3.75));
        //list.printStructure();
        //list.popFront();
        //list.printStructure();
        //list.popBack();
        //list.printStructure();
        //list.popFront();
        //list.printStructure();
        //list.popBack();
        //list.printStructure();
        //list.popBack();


        
        Node node;
        DoublyLinkedList list = new DoublyLinkedList("list5");
        node = list.whoGotHighestGPA();
        node.printIDName();
        list.pushBack(new Node(5906001, "Matthew", 3.25));
        list.pushBack(new Node(5906002, "Mark", 2.75));
        list.pushBack(new Node(5906003, "Luke", 3.00));
        list.printStructure();
        node = list.whoGotHighestGPA();
        node.printIDName();
        Node newNode = new Node(5906004, "John", 3.30);
        list.addNodeBefore(node, newNode);
        list.printStructure();
        list.addNodeAfter(list.whoGotHighestGPA(), new Node(5906005, "James", 3.40));
        list.printStructure();
        (list.whoGotHighestGPA()).printIDName();



        /*
        Node node;
        DoublyLinkedList list = new DoublyLinkedList("list6");
        list.pushBack(new Node(5906001, "Matthew", 3.00));
        list.pushBack(new Node(5906002, "Mark", 2.75));
        list.pushBack(new Node(5906003, "Luke", 3.25));
        list.printStructure();
        node = list.whoGotHighestGPA();
        node.printIDName();
        Node newNode = new Node(5906004, "John", 3.30);
        list.addNodeAfter(node, newNode);
        list.printStructure();
        list.addNodeBefore(list.whoGotHighestGPA(), new Node(5906005, "James", 3.30));
        list.printStructure();
        (list.whoGotHighestGPA()).printIDName();
        */

        /*
        DoublyLinkedList list = new DoublyLinkedList("list7");
        (list.findNode(5906001)).printIDName();
        (list.eraseNode(5906001)).printIDName();
        list.pushBack(new Node(5906001, "Matthew", 3.50));
        list.pushBack(new Node(5906002, "Mark", 2.75));
        list.pushBack(new Node(5906003, "Luke", 3.00));
        list.pushBack(new Node(5906004, "John", 3.75));
        list.pushBack(new Node(5906005, "James", 3.25));
        list.pushBack(new Node(5906006, "Peter", 2.85));
        list.printStructure();
        (list.findNode(5906001)).printIDName();
        (list.findNode(5906006)).printIDName();
        (list.findNode(5906007)).printIDName();
        Node node = list.findNode(5906003);
        list.addNodeAfter(node, new Node(5906007, "John", 2.50));
        list.printStructure();
        (list.eraseNode(5906001)).printIDName();
        list.printStructure();
        (list.eraseNode(5906006)).printIDName();
        list.printStructure();
        (list.eraseNode(5906003)).printIDName();
        list.printStructure(); (list.eraseNode(5906003)).printIDName();
        list.printStructure();
        */
    }
}