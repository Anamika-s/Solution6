using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    [Serializable]
      class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

    }
}
