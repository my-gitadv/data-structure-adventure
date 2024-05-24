using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3LinkedListGPA
{
    internal class Array
    {
        Student[] arr;
        int cap;
        int size = 0;
        

        public Array(int cap)
        {
            this.cap = cap;
            arr = new Student[cap];
        }

        public void addStudent(Student student)
        {
            arr[size] = student;
            size++;
        }
        public Student findTopStudent()
        {
            Student top = arr[0];
            for (int i = 0;i<size; i++)
            {
                if (arr[i].gpa > top)
                {
                    top = arr[i];
                }
            }
            return top;
        }
    }
    
}
