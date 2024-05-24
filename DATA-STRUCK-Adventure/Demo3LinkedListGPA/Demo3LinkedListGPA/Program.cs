using System;

namespace Demo3LinkedListGPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array db = new Array(10);
            db.addStudent(new Student("Matthew", "5906001", 3.5));
            db.addStudent(new Student("Mark", "5906002", 2.75));
            Student top = db.findTopStudent();
            Console.WriteLine("The top student is " + top.name + "id = " + top.student_id);
        }
    }
}
