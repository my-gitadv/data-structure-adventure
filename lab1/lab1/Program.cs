using System;

public class Program
{
    static void Main(string[] args)
    {

        Dynamicarray var = new dynamicarray(2);
        var.printstructure();
        var.pushback(5);
        var.pushback(6);
        var.printstructure();
        var.pushback(7);
        var.printstructure();
        var.pushback(8);
        var.printstructure();
        var.pushback(9);
        var.printstructure();




        // DynamicArray var = new DynamicArray(2);
        // for (int i = 0; i < 10; i++)
        // {
        //     var.pushBack(i * i + 1);
        // }
        // var.printStructure();
        // Console.WriteLine(var.get(3));
        // var.set(3, 555);
        // Console.WriteLine(var.get(3));
        // var.remove(3);
        // var.printStructure();





        // DynamicArray var = new DynamicArray(2);
        // for (int i = 0; i < 10; i++)
        // {
        //     var.pushBack(i * i + 1);
        // }
        // var.printStructure();
        // Console.WriteLine(var.get(10));
        // var.set(10, 555);
        // var.remove(10);
        // var.printStructure();




        // DynamicArray var = new DynamicArray(2);
        // Console.WriteLine(var.popBack());
        // var.pushBack(555);
        // Console.WriteLine(var.popBack());




        // DynamicArray var = new DynamicArray(2);
        // Console.WriteLine(var.isEmpty());
        // var.pushBack(555);
        // Console.WriteLine(var.isEmpty());



        // DynamicArray var = new DynamicArray(2);
        // Console.WriteLine(var.getSize());
        // var.pushBack(555);
        // Console.WriteLine(var.getSize());

    }
}