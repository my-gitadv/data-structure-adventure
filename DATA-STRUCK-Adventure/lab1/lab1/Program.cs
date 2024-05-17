using System;

public class Program
{
    static void Main(string[] args)
    {

        /* DynamicArray var = new DynamicArray(2);
         var.printStructure();
         var.pushBack(5);
         var.pushBack(6);
         var.printStructure();
         var.pushBack(7);
         var.printStructure();
         var.pushBack(8);
         var.printStructure();
         var.pushBack(9);
         var.printStructure();
         */



      /* DynamicArray var = new DynamicArray(2);
        for (int i = 0; i < 10; i++)
        {
            var.pushBack(i * i + 1);
        }
        var.printStructure();
        Console.WriteLine(var.get(3));
        var.set(3, 555);
        Console.WriteLine(var.get(3));
        var.remove(3);
        var.printStructure();
      */
        


        /*
        DynamicArray var = new DynamicArray(2);
        for (int i = 0; i < 10; i++)
        {
            var.pushBack(i * i + 1);
        }
        var.printStructure();
        Console.WriteLine(var.get(10));
        var.set(10, 555);
        var.remove(10);
        var.printStructure();
        */
        

        /*
        DynamicArray var = new DynamicArray(2);
        Console.WriteLine(var.popBack());
        var.pushBack(555);
        Console.WriteLine(var.popBack());
        */
        

        /*
        DynamicArray var = new DynamicArray(2);
        Console.WriteLine(var.isEmpty());
        var.pushBack(555);
        Console.WriteLine(var.isEmpty());
        */

        
        DynamicArray var = new DynamicArray(2);
        Console.WriteLine(var.getSize());
        var.pushBack(555);
        Console.WriteLine(var.getSize());
        
    }
}