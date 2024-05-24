using System;

namespace Demo3ArrayGPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array db = new Array(10);
            LinkedList db = new LinkedList();
            db.addStudent(new Student("Matthew", "5906001", 3.5));
            db.addStudent(new Student("Mark", "5906002", 2.75));
            db.addStudent(new Student("Luke", "5906003", 3.00));
            db.addStudent(new Student("John", "5906004", 3.75));
            db.addStudent(new Student("James", "5906005", 3.25));
            Student top = db.findTopStudent();
            Console.WriteLine("The top student is " + top.name + ", id = " + top.student_id);

        }
    }
}
