using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3ArrayGPA
{
    internal class LinkedList
    {
        public Student head;

        public void addStudent(Student student)
        {
            if (head == null)
            {
                head = student;
            }
            else
            {
                student.next = head;
                head = student;
            }
            
        }
        public Student findTopStudent()
        {

            Student current = head;
            Student top = head;

            while (current != null)
            {
                if (current.gpa > top.gpa)
                {
                    top = current;
                }
                current = current.next;
            }
            return top;
        }
    }
}
