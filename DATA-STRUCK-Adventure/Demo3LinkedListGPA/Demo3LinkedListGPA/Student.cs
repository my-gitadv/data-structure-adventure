using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3LinkedListGPA
{
    internal class Student
    {
        public String name;
        public String student_id;
        public double gpa;

        public Student(String name, String student_id, int gpa)
        {
            this.name = name;
            this.student_id = student_id;
            this.gpa = gpa;
        }
    }

    
}
